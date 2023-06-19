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

namespace Cronometro.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEstadisticas : ContentPage
    {
       
        public PaginaEstadisticas()
        {
            InitializeComponent();
            Mostrar_grafica();
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
       
        private void Mostrar_grafica()
        {
            List<TimeSpan> tiempos = ObetenerTiempos();

            List<string> tiempos_string = tiempos.Select(dt => dt.ToString()).ToList();

            /////////////////////////////////////////////////////////////////////////////////
            var entries = new List<ChartEntry>();

            for (int i = 0; i < tiempos.Count; i++)
            {
                  
                var entry = new ChartEntry((float)tiempos[i].TotalSeconds)
                {
                    Color = SKColor.Parse("#19AEF9"),
                    Label = tiempos.ElementAt(i).ToString(@"hh\:mm\:ss\.ff"),
                    ValueLabel = tiempos[i].TotalSeconds.ToString()
                };

                entries.Add(entry);
            }

            // Convierte la lista de ChartEntry en un array
            var entriesArray = entries.ToArray();

            // Crea el objeto LineChart y configúralo
            var chart = new LineChart()
            {
                LabelTextSize=25,
                Entries = entriesArray,
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointMode = PointMode.Square,
                PointSize = 18,
            };

            var chartview = new ChartView { Chart = chart };
            grafica.Chart = chartview.Chart;

            /////////////////////////////////////////////////////////////////////////////////
            //var entries = new[]
            //{
            //    new ChartEntry(tot_poc)
            //    {
            //        Color = SKColor.Parse("#19AEF9"),
            //        Label = tiempos.ElementAt(0),
            //        ValueLabel = "50",
            //    },
            //    new ChartEntry(tot_poc)
            //    {
            //        Color = SKColor.Parse("#34768C"),
            //        Label = tiempos.ElementAt(1),
            //        ValueLabel = "50",
            //    },
            //    new ChartEntry(tot_poc + 10)
            //    {
            //        Color = SKColor.Parse("#FF0000"),
            //        Label = tiempos.ElementAt(2),
            //        ValueLabel = "60",
            //    },
            //    new ChartEntry(tot_poc - 20)
            //    {
            //        Color = SKColor.Parse("#00FF00"),
            //        Label = tiempos.ElementAt(3),
            //        ValueLabel = "30",
            //    }
            //};
            
            //var chart = new LineChart()
            //{
            //    Entries = entries,
            //    LineMode = LineMode.Spline,
            //    LineSize = 8,
            //    PointMode = PointMode.Circle,
            //    PointSize = 18,
            //};
            
            //var chartview = new ChartView { Chart = chart };
            //grafica.Chart = chartview.Chart;
        }
    }
}