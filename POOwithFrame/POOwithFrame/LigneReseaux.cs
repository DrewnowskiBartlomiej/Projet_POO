﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POOwithFrame
{
    public class LigneReseaux
    {
        private double resistanceLigne;
        public LigneReseaux(double resistanceLigne)
        {
            this.resistanceLigne = resistanceLigne;
        }
        public double GetResistanceLigne() { return this.resistanceLigne; }
    }
}