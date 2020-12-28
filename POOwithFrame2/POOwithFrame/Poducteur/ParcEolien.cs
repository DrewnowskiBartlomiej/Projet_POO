using System;
using System.Collections.Generic;
using System.Text;

namespace POOwithFrame
    
{
    class ParcEolien : ProducteurEnergie
    {
        private static Random random = new Random();
        private double coutMantien = random.Next(90, 200);
        public ParcEolien(double maxProduction,string name)
        {
            base.maxProduction = maxProduction;
            base.name = name;
        }
        public override double Production()
        {
            if (starter)
            {
                double production = this.maxProduction * (Meteo.GetForceDuVent()) / 100;
                return production;
            }
            else { return 0; }
            
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (maxProduction / 1000000) * coutMantien;
            return sommecoutProduction;
        }

    }
}
