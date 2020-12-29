using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOprojet
{
    class FuelMarket
    {
        private static Random random = new Random();
        private static double carbontPrice = random.Next(15, 30);
        private static double UraniumPrice = 90;
        private static double GasPrice = random.Next(10, 20);
        private static double foreignEnergy = random.Next(200, 250);
        FuelMarket() { }
        public static double GetCarbonPrice()
        {
            return carbontPrice;
        }
        public static double GetUraniumPrice()
        {
            return UraniumPrice;
        }
        public static double GetGasPrice()
        {
            return GasPrice;
        }
        public static double GetForeignEnergy()
        {
            return foreignEnergy;
        }
        public static void RandomPriceOfFuel()
        {
            carbontPrice = random.Next(15, 30);
            GasPrice = random.Next(10, 20);
            foreignEnergy = random.Next(200, 250);
        }
    }
}
