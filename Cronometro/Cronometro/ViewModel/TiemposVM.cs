using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Cronometro.Model;

namespace Cronometro.ViewModel
{
    public class TiemposVM
    {
        public ObservableCollection<TiempoCLS> tiempos { get; set; }

        public TiemposVM(List<TiempoCLS> _tiempos)
        {
            tiempos = new ObservableCollection<TiempoCLS>();

            _tiempos.ForEach(i =>
            {
                tiempos.Add(i);
            });
            
        }

    }
}
