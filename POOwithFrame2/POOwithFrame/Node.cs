using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOwithFrame
{
    public class Node
    {
        public List<Consommateur> listconsommateurs;
        public List<ProducteurEnergie> listProducteur;
        public Node()
        {
            this.listconsommateurs = new List<Consommateur>();
            this.listProducteur = new List<ProducteurEnergie>();
        }

        public void AddConsommateur(Consommateur consommateur)
        {
            this.listconsommateurs.Add(consommateur);
        }


        public void AddProducteurEnergie(ProducteurEnergie producteurEnergie)
        {
            this.listProducteur.Add(producteurEnergie);
        }


        public double SommeEnergieConsomme()
        {
            double somme = 0;
            foreach (Consommateur consommateur in this.listconsommateurs)
            {
                somme += consommateur.DiffEnergie();
            }
            return somme;

        }

        public double SommeEnergieConsomateursLignes()
        {
            double somme = 0;
            foreach (Consommateur consommateur in this.listconsommateurs)
            {
                somme += consommateur.SommeEnergieLignnes();
            }
            return somme;
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
        public double GetEnergyMissing()
        {
            double valueTuple = 0;
            if(SommeEnergieConsomme()> SommeEnergiePrduite())
            {
                valueTuple = SommeEnergieConsomme() - SommeEnergiePrduite();
            }
            return valueTuple;
        }
        public double GetEnergyOverproduced()
        {
            double valueTuple = 0;
            if (SommeEnergieConsomme() < SommeEnergiePrduite())
            {
                valueTuple = SommeEnergiePrduite() - SommeEnergieConsomme();
            }
            return valueTuple;

        }
    }
}








