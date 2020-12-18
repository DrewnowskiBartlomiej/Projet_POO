using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{
    class SourceEnergie
    {
        private List<ProducteurEnergie> listProducteur;
        public SourceEnergie()
        {
            this.listProducteur = new List<ProducteurEnergie>();
        }

        public void Add(ProducteurEnergie producteurEnergie)
        {
            this.listProducteur.Add(producteurEnergie);
        }
        public double SommeEnergiePrduite()
        {
            double somme = 0;
            foreach (ProducteurEnergie producteurEnergie in this.listProducteur)
            {
                somme += producteurEnergie.Production();
            }
            return somme;

        }
        
        
    }
}
