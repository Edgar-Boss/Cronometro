using Cronometro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Cronometro.ViewModel;

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
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_circulo;
            frm_tap.GestureRecognizers.Add(tap);

        }

        private void Tap_circulo(object sender, EventArgs e)
        {
            Pausa_resume();
            AnimCirculo();
           
            
        }

        private void Pausa_resume()
        {
            if (isRunning)
            {
                isRunning = false;
                startButton.Text = "Start";
            }
            else
            {
                isRunning = true;
                iniciar_tiempo();
                startButton.Text = "Pause";
            }
        }
  
        private void StartButton_Clicked(object sender, EventArgs e)
        {
            Pausa_resume();
            AnimStart();
            stopButton.IsEnabled = true;
            
        }
        private async void AnimCirculo()
        {
            await frm_circulo.ScaleTo(0.99, 110, null);
            await frm_circulo.ScaleTo(1.03, 170, null);
            await frm_circulo.ScaleTo(1, 170, null);
        }
        private async void AnimStart()
        {
            await startButton.ScaleTo(1.05, 100);
            await startButton.ScaleTo(1, 100);
        }
        private async void StopButton_Clicked(object sender, EventArgs e)
        {
            await stopButton.ScaleTo(1.05, 100);
            await stopButton.ScaleTo(1, 100);
            isRunning = false;
            f_lap = true;
            elapsedTime = TimeSpan.Zero;
            parcial = TimeSpan.Zero;

            timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");
            LblParcial.Text = parcial.ToString(@"hh\:mm\:ss\.ff");

            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;
            startButton.Text = "Start";
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

        private async void MoverCirculo()
        {
            var altura = abl.Height / 10;
            await grd_base.TranslateTo(0,  -altura*2, 500);
        }

        private async void MoverBotones()
        {
            await frm_botones.TranslateTo(0, 100, 500);
           
            await stk_lap.FadeTo(1, 150);
            
        }
        private async void LapButton_Clicked(object sender, EventArgs e)
        {
            if (f_lap)
            {
                StartLap = DateTime.Now;
                MoverCirculo();
                MoverBotones();

                TiempoCLS t = new TiempoCLS();
                t.Total = elapsedTime;
                t.Vuelta = ListaTiempos.Count + 1;
                t.Parcial = elapsedTime;

                ListaTiempos.Add(t);
                stk_lap.IsVisible = true;
                stk_lap.IsEnabled = true;
                await stk_lap.FadeTo(0, 0);
                BindingContext = new TiemposVM(ListaTiempos);
                f_lap = false;
            }
            else 
            {

                //parcial =  DateTime.Now - StartLap;
                TiempoCLS t = new TiempoCLS();
                t.Total = elapsedTime;
                t.Vuelta = ListaTiempos.Count + 1;
                t.Parcial = parcial;
                StartLap = DateTime.Now;
                ListaTiempos.Add(t);
                stk_lap.IsVisible = true;
                stk_lap.IsEnabled = true;
                BindingContext = new TiemposVM(ListaTiempos);
            }
            



        }
    }
}