using System;
using System.Collections.Generic;
using System.Text;

namespace POOwithFrame
{  
    class CentralSolaire : ProducteurEnergie
    {
        private double coutMantien = 142;
        public CentralSolaire(double maxProduction, string name)
        {
            base.maxProduction = maxProduction;
            base.name = name;
        }
        public override double Production()
        {
            if (starter)
            {
                double production = base.maxProduction * (Meteo.GetEnsoleillement()) / 100;
                return production;
            }
            else { return 0; }
            
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (this.maxProduction / 1000000) * coutMantien;
            return sommecoutProduction;
        }
    }
}
