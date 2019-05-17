using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Firma
    {      
        public int LP { get; set; }
        public string Nazwa_firmy { get; set; }
        public int REGON { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string Miasto { get; set; }
        public string Ulica_nr { get; set; }
        public string Powiat { get; set; }
        public string Telefon { get; set; }
        public string Polisa1 { get; set; }
        public DateTime Data1 { get; set; }
        public string Polisa2 { get; set; }
        public DateTime Data2 { get; set; }
        public string Rating { get; set; }
        public int Przychody { get; set; }
        public int EBIDTA { get; set; }
        public double NDE_EBIDTA { get; set; }
        public double DSCR { get; set; }
        public string Produkt1 { get; set; }
        public int Marża1 { get; set; }
        public int Prowizja1 { get; set; }
        public string Produkt2 { get; set; }
        public int Marża2 { get; set; }
        public int Prowizja2 { get; set; }

        internal static Firma ParsujCSV(string linia)
        {
            var kolumny = linia.Split(';');
            
             kolumny[10] = kolumny[10].Replace(" 01","");  //usuwanie zbędnych znaków
              kolumny[12] = kolumny[12].Replace(" 01", "");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    kolumny[10] = kolumny[10].Replace(" " + i.ToString() + j.ToString(), "");
                    kolumny[12] = kolumny[12].Replace(" " + i.ToString() + j.ToString(), "");
                }
            }
            kolumny[10] = kolumny[10].Replace(".", "/");
            kolumny[12] = kolumny[12].Replace(".", "/");
            kolumny[10] = kolumny[10].Replace(" ", "");
            kolumny[12] = kolumny[12].Replace(" ", "");
            string a = kolumny[10];
            string b = kolumny[12];


            return new Firma
            {                
                LP = int.Parse(kolumny[0]),
                Nazwa_firmy = kolumny[1],
                REGON = int.Parse(kolumny[2]),
                Nazwisko = kolumny[3],
                Imie =  kolumny[4],
                Miasto = kolumny[5],
                Ulica_nr = kolumny[6],
                Powiat = kolumny[7],
                Telefon = kolumny[8],
                Polisa1 = kolumny[9],
                Data1 = DateTime.ParseExact(a,"d/m/yyyy", CultureInfo.InvariantCulture),
                Polisa2 = kolumny[11],
                Data2 = DateTime.ParseExact(b,"d/m/yyyy", CultureInfo.InvariantCulture),
                Rating =  kolumny[13],
                Przychody = int.Parse(kolumny[14]),
                EBIDTA = int.Parse(kolumny[15]),
                NDE_EBIDTA = double.Parse(kolumny[16]),
                DSCR = double.Parse(kolumny[17]),
                Produkt1 = kolumny[18],
                Marża1 = int.Parse(kolumny[19]),
                Prowizja1 = int.Parse(kolumny[20]),
                Produkt2 = kolumny[21],
                Marża2 = int.Parse(kolumny[22]),
                Prowizja2 = int.Parse(kolumny[23]),             
             };
        }        
    }
}

