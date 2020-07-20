using System;

namespace EsercizioCerchio.Code
{
    internal class Cerchio
    {
        private double raggio;
        public double Diametro { get; private set; }
        public double Area { get; private set; }
        public double Circonferenza { get; private set; }
        
        public Cerchio(double raggio)
        {
            this.raggio = raggio;
            CalcolaValori();
        }

        private void CalcolaValori()
        {
            Diametro = raggio * 2;
            Area = raggio * raggio * Math.PI;
            Circonferenza = 2 * Math.PI * raggio;
        }
    }
}