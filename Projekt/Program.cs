using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           // var firmy = WczytywaniePliku("ProjektB.csv");
          
           
        }

     /*   private static List<Firma> WczytywaniePliku(string sciezka)
        {
          return  File.ReadAllLines(sciezka)
                .Skip(1)
                .Where(linia => linia.Length > 1)
                .Select(Firma.ParsujCSV).ToList();
        }*/
    }
}
