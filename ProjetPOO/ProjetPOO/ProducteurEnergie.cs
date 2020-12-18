using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{
    class ProducteurEnergie
    {
        protected double energieProduit;
        protected double co2Produit;
        protected double coutProduction;
        protected double prixConbustible;
        public ProducteurEnergie()
        {

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
    }
}
