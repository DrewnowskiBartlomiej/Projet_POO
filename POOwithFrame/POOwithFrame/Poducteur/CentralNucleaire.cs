using System;
using System.Collections.Generic;
using System.Text;

namespace POOwithFrame
{
    class CentralNucleaire : ProducteurEnergie
    {
        private double i = 1;
        public CentralNucleaire(double maxProduction,string name)
        {
            base.maxProduction = maxProduction;
            base.name = name;
        }
        public override double Production()
        {
            if (starter)
            {
                if (i < 1) { i += 0.2; }
                return maxProduction*i;
            }
            else{
                i = 0;
                return 0;
            }
            
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (Production() / 1000000) * FuelMarket.GetUraniumPrice();
            return sommecoutProduction;
        }
    }
}
