using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{
    class ParcEolien : ProducteurEnergie
    {
        private static Random random = new Random();
        private double coutMantien = random.Next(90, 200);
        private double maxProduction;
        public ParcEolien(double maxProduction)
        {
            this.maxProduction = maxProduction;
        }
        public override double Production()
        {
            double production = this.maxProduction * (Meteo.GetForceDuVent()) / 100;
            return production;
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (Production() / 1000000) * coutMantien;
            return sommecoutProduction;
        }

    }
}
