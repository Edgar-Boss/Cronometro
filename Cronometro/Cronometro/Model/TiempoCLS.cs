using System;
using System.Collections.Generic;
using System.Text;

namespace Cronometro.Model
{
    public  class TiempoCLS
    {
        public int Vuelta { set; get; }
        public TimeSpan Parcial { set; get; }
        
        public TimeSpan Total { set; get; } 

    }
}
