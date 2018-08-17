using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P04Figury
{
    class Kwadrat : IFigura
    {   
        public double poleKwadratu;
        public double prostokatA;
        public double prostokatB;

        public Kwadrat(double prostokatA, double prostokatB)
        {         
            this.prostokatA = prostokatA;
            this.prostokatB = prostokatB;
        }

        public double ObliczPole()
        {
            poleKwadratu = prostokatA * prostokatB;
            return poleKwadratu;
        }
    }
}
