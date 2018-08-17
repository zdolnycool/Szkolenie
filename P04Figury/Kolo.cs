using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Figury
{
    class Kolo : IFigura
    {
        public double poleKola;
        public double promien;

        public Kolo(double promien)
        {
            this.promien = promien;
        }

        public double ObliczPole()
        {
            poleKola = Math.PI * Math.Pow(promien, 2);
            return Math.Round(poleKola, 2);
        }
    }
}
