using Cronometro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Cronometro.ViewModel
{
    public  class RegistrosVM
    {
        public ObservableCollection<RegistrosCLS> Registros_ { get; set; }

        public RegistrosVM(List<RegistrosCLS> Registros)
        {
            Registros_ = new ObservableCollection<RegistrosCLS>();

            Registros.ForEach(i =>
            {
                Registros_.Add(i);
            });
        }

    }
}
