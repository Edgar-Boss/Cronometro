using Cronometro.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.IO;
using Cronometro.ViewModel;
using System.Linq;
using MarcTron.Plugin;
using Cronometro.View;


namespace Cronometro
{
    public partial class MainPage : ContentPage
    {
        List<TiempoCLS> ListaTiempos = new List<TiempoCLS>();
        private bool isRunning = false;
        private TimeSpan elapsedTime = TimeSpan.Zero;
        private DateTime startTime;
        private DateTime StartLap;
        bool giro = false;
        bool f_lap = true;
        TimeSpan parcial = TimeSpan.Zero;

        public MainPage()
        {
            CrossMTAdmob.Current.OnInterstitialLoaded += (sender, e) => { CrossMTAdmob.Current.ShowInterstitial(); };
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_circulo;
            frm_tap.GestureRecognizers.Add(tap);

        }
       
        private void Pausa_resume()
        {
            if (isRunning)//pausar
            {
                isRunning = false;
                startButton.Text = "Start";
                stopButton.IsEnabled = true;
                stopButton.IsVisible = true;
                LapButton.IsEnabled = false;
                LapButton.IsVisible = false;
                BtnSave.IsEnabled = true;
                BtnSave.IsVisible = true;


            }
            else//iniciar
            {
                isRunning = true;
                iniciar_tiempo();
                startButton.Text = "Pause";
                LapButton.IsEnabled = true;
                LapButton.IsVisible = true;
                stopButton.IsEnabled = false;
                stopButton.IsVisible = false;
                BtnSave.IsEnabled = false;
                BtnSave.IsVisible = false;
            }
        }
        private async void AnimCirculo()
        {
            await frm_circulo.ScaleTo(0.99, 110, null);
            await frm_circulo.ScaleTo(1.03, 170, null);
            await frm_circulo.ScaleTo(1, 170, null);
        }

        private async void AnimBoton(object sender)
        {
            Button boton = (Button)sender;

            await boton.ScaleTo(1.1, 100);
            await boton.ScaleTo(1, 100);

        }
        private async void AnimImageBoton(object sender)
        {
            ImageButton boton = (ImageButton)sender;

            await boton.ScaleTo(1.1,100);
            await boton.ScaleTo(1,100);

        }
        private void iniciar_tiempo()
        {
            Girar();
            startTime = DateTime.Now - elapsedTime;
            StartLap = DateTime.Now - parcial;
            Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            {
                if (!isRunning)
                    return false;
               
                elapsedTime = DateTime.Now - startTime;
                parcial = DateTime.Now - StartLap;
                timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");
                LblParcial.Text = parcial.ToString(@"hh\:mm\:ss\.ff");
                return true;
            });
        }
        private async void Girar()
        {
            if (giro == false)
            {
                while (isRunning)
                {
                    giro = true;
                    await frm_circulo.RelRotateTo(45, 200);
                }
                giro = false;
            }
            
        }
        private async void MoverCirculo(bool mov)
        {
            if (mov)
            {
                var altura = abl.Height / 10;
                await grd_base.TranslateTo(0, -altura * 2, 500);
            }
            else
            {
                await grd_base.TranslateTo(0, 0, 500);
            }
            
        }
        private async void MoverBotones(bool mov)
        {
            if (mov)
            {
                await frm_botones.TranslateTo(0, 100, 500);

                await stk_lap.FadeTo(1, 150);
            }
            else
            {
                await frm_botones.TranslateTo(0, 0, 500);
            }
            
            
        }
        private void Tap_circulo(object sender, EventArgs e)
        {
            Pausa_resume();
            AnimCirculo();
        }
        private async void LapButton_Clicked(object sender, EventArgs e)
        {
            AnimImageBoton(sender);
            TiempoCLS t = new TiempoCLS();
            t.Total = elapsedTime;
            t.Vuelta = ListaTiempos.Count + 1;
            StartLap = DateTime.Now;
            
            stk_lap.IsVisible = true;
            stk_lap.IsEnabled = true;
            if (f_lap)
            {
                MoverCirculo(true);
                MoverBotones(true);
                t.Parcial = elapsedTime;
                await stk_lap.FadeTo(0, 0);
                f_lap = false;
            }
            else 
            {
                t.Parcial = parcial;
            }
            ListaTiempos.Add(t);
            BindingContext = new TiemposVM(ListaTiempos);



        }
        private void StopButton_Clicked(object sender, EventArgs e)
        {
            AnimBoton(sender);
            isRunning = false;
            f_lap = true;
            elapsedTime = TimeSpan.Zero;
            parcial = TimeSpan.Zero;

            timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");
            LblParcial.Text = parcial.ToString(@"hh\:mm\:ss\.ff");

           
            startButton.Text = "Start";
            ListaTiempos.Clear();
            BindingContext = new TiemposVM(ListaTiempos);
            MoverBotones(false);
            MoverCirculo(false);
            stk_lap.IsVisible = false;
            stk_lap.IsEnabled = false;
            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;
            stopButton.IsVisible = false;
            BtnSave.IsEnabled = false;
            BtnSave.IsVisible = false;

        }
        private void StartButton_Clicked(object sender, EventArgs e)
        {
            Pausa_resume();
            AnimBoton(sender);
            stopButton.IsEnabled = true;

        }
        
        private void BtnSave_Clicked(object sender, EventArgs e)
        {

            AnimImageBoton(sender);
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tiempos.txt");
            string filePath_date = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "fechas.txt");
            string[] lines;
            string[] lines_date;

            try
            {
                lines = File.ReadAllLines(filePath); // Leer datos desde el archivo
                lines_date = File.ReadAllLines(filePath_date);
            }
            catch (FileNotFoundException ex)
            {
                List<string> lista = new List<string>();
                List<string> lista_date = new List<string>();
                File.WriteAllLines(filePath, lista);//Escribir datos en el archivo
                File.WriteAllLines(filePath_date, lista_date);
            }


            lines = File.ReadAllLines(filePath);
            lines_date = File.ReadAllLines(filePath_date);
           
            List<TimeSpan> readDateList = lines.Select(line => TimeSpan.Parse(line)).ToList();// Convertir las cadenas a una lista de DateTime
            List<DateTime> readdateList_date = lines_date.Select(line => DateTime.Parse(line)).ToList();

            readdateList_date.Add(DateTime.Now);
            readDateList.Add(elapsedTime);

            // Convertir la lista de DateTime a una lista de cadenas
            List<string> dateStringList = readDateList.Select(dt => dt.ToString()).ToList();
            List<string> datetringlist_date = readdateList_date.Select(dt => dt.ToString()).ToList();

            //// Escribir datos en el archivo
            File.WriteAllLines(filePath, dateStringList);
            File.WriteAllLines(filePath_date, datetringlist_date);
            DisplayAlert("Marca guardada","La marca se ha guardado correctamente","ok");
        }

        async private void BtnEstadisticas_Clicked(object sender, EventArgs e)
        {
            AnimImageBoton(sender);
            CrossMTAdmob.Current.LoadInterstitial("ca-app-pub-8967169262052512/2052349351");

            await Navigation.PushAsync(new PaginaEstadisticas());
        }
    }
}
























