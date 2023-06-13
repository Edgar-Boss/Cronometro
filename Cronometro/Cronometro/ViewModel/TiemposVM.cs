using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Cronometro.Model;
using System.Net.Http.Headers;

namespace Cronometro.ViewModel
{
    public class TiemposVM
    {
        public ObservableCollection<TiempoSCLS> tiempos { get; set; }

        public TiemposVM(List<TiempoCLS> _tiempos)
        {
            tiempos = new ObservableCollection<TiempoSCLS>();

            _tiempos.ForEach(i =>
            {
                tiempos.Add(new TiempoSCLS
                {
                    Vuelta = i.Vuelta,
                    Total = i.Total.ToString(@"hh\:mm\:ss\.ff"),
                    Parcial = i.Parcial.ToString(@"hh\:mm\:ss\.ff")
                });
                
            });
            
        }

    }
}
