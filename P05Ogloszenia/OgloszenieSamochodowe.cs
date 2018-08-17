using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Ogloszenia
{
    class OgloszenieSamochodowe : Ogloszenie
    {
        public OgloszenieSamochodowe(string opis, double cena, string tytul, string daneKontaktowe) : base(opis, cena, tytul, daneKontaktowe)
        {
        }
    }
}
