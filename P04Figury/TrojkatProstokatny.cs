using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Figury
{
    class TrojkatProstokatny : IFigura
    {
        public double prostokatA;
        public double prostokatB;
        public double poleProstokata;

        public TrojkatProstokatny(double prostokatA, double prostokatB)
        {
            this.prostokatA = prostokatA;
            this.prostokatB = prostokatB;
        }

        public double ObliczPole()
        {
            poleProstokata = (prostokatA * prostokatB) / 2;
            return poleProstokata;
        }
    }
}
