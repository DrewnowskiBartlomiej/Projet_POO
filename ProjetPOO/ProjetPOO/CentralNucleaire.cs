using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{
    class CentralNucleaire : ProducteurEnergie
    {
        private static Random random = new Random();
        private double coutMantien = random.Next(60, 109);
        private double maxProduction;

        public CentralNucleaire(double maxProduction)
        {
            this.maxProduction = maxProduction;
        }
        public override double Production()
        {
            return maxProduction;
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (Production() / 1000000) * coutMantien;
            return sommecoutProduction;
        }

    }
}
