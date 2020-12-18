using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{  
    class CentralSolaire : ProducteurEnergie
    {
        private double coutMantien = 142;
        private double maxProduction;
        public CentralSolaire(double maxProduction)
        {
            this.maxProduction = maxProduction;
        }
        public override double Production()
        {
            double production = this.maxProduction * (Meteo.GetEnsoleillement()) / 100;
            return production;
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (Production() / 1000000) * coutMantien;
            return sommecoutProduction;
        }
    }
}
