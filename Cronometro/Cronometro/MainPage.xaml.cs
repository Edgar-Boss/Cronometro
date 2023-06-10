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

namespace Cronometro
{
    public partial class MainPage : ContentPage
    {
        private bool isRunning = false;
        private TimeSpan elapsedTime = TimeSpan.Zero;
        private DateTime startTime;
        bool giro = false;
        public MainPage()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += TapGestureRecognizer_Tapped;
            frm_tap.GestureRecognizers.Add(tap);

        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            await frm_circulo.ScaleTo(1.1,170,null);
            await frm_circulo.ScaleTo(1, 170, null);
        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            await startButton.ScaleTo(1.05, 100);
            await startButton.ScaleTo(1, 100);
            stopButton.IsEnabled = true;
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

        private async void StopButton_Clicked(object sender, EventArgs e)
        {
            await stopButton.ScaleTo(1.05, 100);
            await stopButton.ScaleTo(1, 100);
            isRunning = false;
            elapsedTime = TimeSpan.Zero;

            timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");

            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;
            startButton.Text = "Start";
        }

        private void iniciar_tiempo()
        {
            Girar();
            startTime = DateTime.Now - elapsedTime;
            Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            {
                if (!isRunning)
                    return false;
               
                elapsedTime = DateTime.Now - startTime ;
                timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");
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

        private void LapButton_Clicked(object sender, EventArgs e)
        {
            MoverCirculo();
            MoverBotones();
        }


        private async void MoverCirculo()
        {
            var altura = abl.Height / 10;
            await grd_base.TranslateTo(0,  -altura*2, 500);
        }

        private async void MoverBotones()
        {
            await frm_botones.TranslateTo(0, 100, 500);
        }
    }
}