﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POOprojet
{
    public class ProducteurEnergie
    {
        protected double maxProduction;
        protected string name;
        protected bool starter = true;

        public ProducteurEnergie()
        {

        }
        public string GetName()
        {
            return name;
        }
        public double GetMaxProduction()
        {
            return maxProduction;
        }
        public virtual double Production()
        {
            return 0; 
        }
        public virtual double Emission()
        {
            return 0;
        }
        public virtual double CoutProduction()
        {
            return 0;
        }
        public virtual void SetOFF() { starter = false; }
        public virtual void SetON() { starter = true; }

    }
}
