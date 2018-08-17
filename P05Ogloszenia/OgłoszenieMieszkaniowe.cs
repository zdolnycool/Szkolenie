using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Ogloszenia
{
    class OgłoszenieMieszkaniowe : Ogloszenie
    {
        public int LiczbaPokoi { get; set; }
        public string Miejscowosc { get; set; }
        public double Metraz { get; set; }

        public OgłoszenieMieszkaniowe(string opis, double cena, string tytul, string daneKontaktowe, int liczbaPokoi, string miejscowosc, double metraz) 
            : base(opis, cena, tytul, daneKontaktowe)
        {
            LiczbaPokoi = liczbaPokoi;
            Miejscowosc = miejscowosc;
            Metraz = metraz;
        }




    }
}
