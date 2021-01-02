using System;
using System.Collections.Generic;
using System.Text;

namespace POOprojet
{
    class CentralGaz : ProducteurEnergie
    {
        public CentralGaz(double maxProduction,string name)
        {
            base.maxProduction = maxProduction;
            base.name = name;
        }
        public override double Production()
        {
            if (starter)
            {
                if (Meteo.GetTemperature() > 40 && Meteo.GetEnsoleillement() > 60)
                {
                    return maxProduction / 2;
                }
                else { return maxProduction; }
            }
            else { return 0; }
            
        }
        public override double Emission()
        {
            double sommeEmission = Production()*0.04;
            return sommeEmission;
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (Production() / 1000000)*FuelMarket.GetGasPrice();
            return sommecoutProduction;
        }
    }
}
