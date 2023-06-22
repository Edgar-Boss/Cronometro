using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using Microcharts.Forms;
using SkiaSharp;
using System.IO;
using Cronometro.Model;
using Cronometro.ViewModel;
using PanCardView;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;

namespace Cronometro.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEstadisticas : ContentPage
    {
        List<TimeSpan> tiempos;
        List<DateTime> fechas;

        public PaginaEstadisticas()
        { 
            InitializeComponent();
            DescargarDatos();
            int cont = ObetenerTiempos().Count-1;
            CarreteTiempos.SelectedIndex = cont;
            Mostrargrafica(cont);
            ListaRegistros();   
        }
        private void DescargarDatos()
        {
            tiempos = ObetenerTiempos();
            fechas = ObtenerFecha();
        }
        private List<TimeSpan> ObetenerTiempos()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tiempos.txt");
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filePath); // Leer datos desde el archivo
            }
            catch (FileNotFoundException ex)
            {
                List<string> lista = new List<string>();
                File.WriteAllLines(filePath, lista);//Escribir datos en el archivo
            }


            lines = File.ReadAllLines(filePath);

            List<TimeSpan> readDateList = lines.Select(line => TimeSpan.Parse(line)).ToList();// Convertir las cadenas a una lista de DateTime
            // Convertir la lista de DateTime a una lista de cadenas
            return readDateList;
        }

        private List<DateTime> ObtenerFecha()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "fechas.txt");
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filePath); // Leer datos desde el archivo
            }
            catch (FileNotFoundException ex)
            {
                List<string> lista = new List<string>();
                File.WriteAllLines(filePath, lista);//Escribir datos en el archivo
            }


            lines = File.ReadAllLines(filePath);

            List<DateTime> readDateList = lines.Select(line => DateTime.Parse(line)).ToList();// Convertir las cadenas a una lista de DateTime

            // Convertir la lista de DateTime a una lista de cadenas


            return readDateList;


        }
        private void Mostrargrafica(int ind)
        {
            
            List<string> tiempos_string = tiempos.Select(dt => dt.ToString()).ToList();
            List<string> fechas_string = fechas.Select(dt => dt.ToString()).ToList();
            /////////////////////////////////////////////////////////////////////////////////
            
            var entries = new List<ChartEntry>();
            string col = "#19AEF9";//
    
            for (int i = 0; i < tiempos.Count; i++)
            {

                if (i == ind)
                    col = "#9AE349";
                else
                    col = "#19AEF9";

                var entry = new ChartEntry((float)tiempos[i].TotalSeconds)
                {
                    Color = SKColor.Parse(col),
                    Label = tiempos.ElementAt(i).ToString(@"hh\:mm\:ss\.ff"),
                    ValueLabel = i.ToString()
                };
                entries.Add(entry);
            }

            // Convierte la lista de ChartEntry en un array
            var entriesArray = entries.ToArray();

            // Crea el objeto LineChart y configúralo
            var chart = new LineChart()
            {
                LabelTextSize = 25,
                Entries = entriesArray,
                LineMode = LineMode.Spline,
                LineSize = 8,
                PointMode = PointMode.Circle,
                PointSize = 18,
            };

            var chartview = new ChartView { Chart = chart };
            
            grafica.Chart = chartview.Chart;
        }


        public void ListaRegistros()
        {
            List<TimeSpan> tiempos = ObetenerTiempos();
            List<DateTime> fechas = ObtenerFecha();

            var lista = new List<RegistrosCLS>();

            for (int k = 0; k < tiempos.Count(); k++)
            {
                lista.Add(new RegistrosCLS
                {
                    Id = k,
                    Tiempo = tiempos.ElementAt(k).ToString(@"hh\:mm\:ss\.ff"),
                    Fecha = fechas.ElementAt(k).ToString()
                });
            }

            BindingContext =new RegistrosVM(lista);
        }

       
        private void CarreteTiempos_ItemAppeared(CardsView view, PanCardView.EventArgs.ItemAppearedEventArgs args)
        {  
            Mostrargrafica(view.SelectedIndex);
        }

        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            tiempos.RemoveAt(int.Parse(btn.ClassId));
            fechas.RemoveAt(int.Parse(btn.ClassId));
            GuardarDatos();
            if (int.Parse(btn.ClassId) < tiempos.Count())
            {
                
                Mostrargrafica(int.Parse(btn.ClassId));
                CarreteTiempos.SelectedIndex = int.Parse(btn.ClassId);
            }
            else
            {
                Mostrargrafica(tiempos.Count() - 1);
                CarreteTiempos.SelectedIndex = tiempos.Count() - 1;
            }
            
            ListaRegistros();
        }


        private void GuardarDatos()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tiempos.txt");
            string filePath_date = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "fechas.txt");
            

            // Convertir la lista de DateTime a una lista de cadenas
            List<string> dateStringList = tiempos.Select(dt => dt.ToString()).ToList();
            List<string> datetringlist_date = fechas.Select(dt => dt.ToString()).ToList();

            //// Escribir datos en el archivo
            File.WriteAllLines(filePath, dateStringList);
            File.WriteAllLines(filePath_date, datetringlist_date);
        }
    }
}