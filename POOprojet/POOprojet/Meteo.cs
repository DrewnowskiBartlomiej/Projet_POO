﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POOprojet
{
    class Meteo
    {
        private static Random random = new Random();
        private static double forceDuVent = random.Next(0, 100);
        private static double ensoleillement = random.Next(0, 100);
        private static double temperature = random.Next(-40, 50);
        Meteo() { }
        public static double GetEnsoleillement()
        {
            return ensoleillement;
        }
        public static double GetForceDuVent()
        {
            return forceDuVent;
        }
        public static double GetTemperature()
        {
            return temperature;
        }
        public static void RandomMeteo()
        {
            forceDuVent = random.Next(0, 100);
            ensoleillement = random.Next(0, 100);
            temperature = random.Next(-40, 50);
        }


    }
}
