using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Ogloszenia
{
    class Ogloszenie
    {
        public string Opis { get; set; }
        public double Cena { get; set; }
        public string Tytul { get; set; }
        public string DaneKontaktowe { get; set; }

        public Ogloszenie(string opis, double cena, string tytul, string daneKontaktowe)
        {
            Opis = opis;
            Cena = cena;
            Tytul = tytul;
            DaneKontaktowe = daneKontaktowe;
        }
    }
}
