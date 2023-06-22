using Microcharts.Forms;
using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cronometro.General
{
    public class Comun
    {

        //private void Mostrar_grafica(int ind)
        //{

        //    List<TimeSpan> tiempos = ObetenerTiempos();
        //    List<DateTime> fechas = ObtenerFecha();
        //    List<string> tiempos_string = tiempos.Select(dt => dt.ToString()).ToList();
        //    List<string> fechas_string = fechas.Select(dt => dt.ToString()).ToList();
        //    /////////////////////////////////////////////////////////////////////////////////


        //    var entries = new List<ChartEntry>();
        //    string col = "#19AEF9";//

            

        //    for (int i = 0; i < tiempos.Count; i++)
        //    {

        //        if (i == ind)
        //            col = "#FF93D773";
        //        else
        //            col = "#19AEF9";

        //        var entry = new ChartEntry((float)tiempos[i].TotalSeconds)
        //        {
        //            Color = SKColor.Parse(col),
        //            Label = tiempos.ElementAt(i).ToString(@"hh\:mm\:ss\.ff"),
        //            ValueLabel = i.ToString()
        //        };
        //        entries.Add(entry);
        //    }

        //    // Convierte la lista de ChartEntry en un array
        //    var entriesArray = entries.ToArray();

        //    // Crea el objeto LineChart y configúralo
        //    var chart = new LineChart()
        //    {
        //        LabelTextSize = 25,
        //        Entries = entriesArray,
        //        LineMode = LineMode.Spline,
        //        LineSize = 8,
        //        PointMode = PointMode.Circle,
        //        PointSize = 18,
        //    };

        //    var chartview = new ChartView { Chart = chart };

        //    grafica.Chart = chartview.Chart;


        //}
    }
}
