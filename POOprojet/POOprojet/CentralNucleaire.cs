using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace POOprojet
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
                return maxProduction * i;  
        }
        public override double CoutProduction()
        {
            double sommecoutProduction = (Production() / 1000000) * FuelMarket.GetUraniumPrice();
            return sommecoutProduction;
        }
        public override async void SetOFF() {
            await ClosingAsync();
            starter = false;
        }
        public override async void SetON() {
            await OpeningAsync();
            starter = true;
        }
        private async Task OpeningAsync()
        {
            while(i <= 0.8)
            {
                i = i + 0.2;
                await Task.Delay(1000);
            } 
        }
        private async Task ClosingAsync()
        {
            while (i >= 0.2)
            {
                i = i - 0.2;
                await Task.Delay(1000);
            }
        }
    }
}
