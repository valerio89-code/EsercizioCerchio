using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCerchio.Code
{
    class Cono
    {
        private double raggio;
        private double altezza;
        public double Volume { get; set; }
        public Cono(double raggio, double altezza)
        {
            this.raggio = raggio;
            this.altezza = altezza;
            CalcolaValori();
        }

        private void CalcolaValori()
        {
            Volume = (Math.PI * Math.Pow(raggio, 2) * altezza) / 3;
        }
    }
}
