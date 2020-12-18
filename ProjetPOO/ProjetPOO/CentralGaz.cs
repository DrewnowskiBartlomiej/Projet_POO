using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{
    class CentralGaz : ProducteurEnergie
    {
        private static Random random = new Random();
        public double coutGAZ = random.Next(70, 100);
        private double maxProduction;
        public CentralGaz(double maxProduction)
        {
            this.maxProduction = maxProduction;
        }
        public override double Production()
        {
            if (Meteo.GetEnsoleillement() > 40 & Meteo.GetEnsoleillement() > 60)
            {
                return maxProduction / 2;
            }
            else { return maxProduction; }
        }
        public override double Emission()
        {
            double sommeEmission = Production()*0.04;
            return sommeEmission;
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (Production() / 1000000)*coutGAZ;
            return sommecoutProduction;
        }
    }
}
