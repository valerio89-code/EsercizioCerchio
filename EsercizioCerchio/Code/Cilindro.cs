using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCerchio.Code
{

    class Cilindro
    {
        private double raggio;
        private double altezza;
        public double AreaLaterale { get; set; }
        public double AreaTotale { get; set; }
        public double Volume { get; set; }
        public Cilindro(double raggio, double altezza)
        {
            this.raggio = raggio;
            this.altezza = altezza;
            CalcolaValori();
        }

        private void CalcolaValori()
        {
            var areaBase = raggio * raggio * Math.PI;
            var circonferenzaBase = 2 * Math.PI * raggio;
            AreaLaterale = circonferenzaBase * altezza;
            AreaTotale = (2 * areaBase) + AreaLaterale;
            Volume = areaBase * altezza;
        }
    }
}
