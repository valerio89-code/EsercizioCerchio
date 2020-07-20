using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCerchio.Code
{
    class Sfera
    {
        private double raggio;
        public double Volume { get; set; }
        public double Superficie { get; set; }

        public Sfera(double raggio)
        {
            this.raggio = raggio;
            CalcolaValori();
        }

        private void CalcolaValori()
        {
            Volume = (double)4 / 3 * Math.PI * Math.Pow(raggio, 3);
            Superficie = 4 * Math.PI * Math.Pow(raggio, 2);
        }
    }
}
