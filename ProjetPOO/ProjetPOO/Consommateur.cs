using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{
    class Consommateur
    {
        protected string nom;
        protected double consomEnergie;
        protected List<LigneReseaux> listReseaux;
        protected double prix;
        private double sommediff;


        public Consommateur(string nom,double consomEnergie)
        {
            this.consomEnergie = consomEnergie;
            this.nom = nom;
            this.listReseaux = new List<LigneReseaux>();
        }
        public double GetconsomEnergie() { return this.consomEnergie; }
        public void SetconsomEnergie(double newconsomEnergie){this.consomEnergie = newconsomEnergie;}
        public string Getnom() { return this.nom; }
        public void Add(LigneReseaux newreseau)
        {
            this.listReseaux.Add(newreseau);
        }
        public double SommeEnergieLignnes()
        {
            ////////////////calcule la somme de Puissance max des toutes les lignes///////////////////////// 
            double  somme = 0;
            foreach(LigneReseaux ligneReseaux in this.listReseaux)
            {
                somme += ligneReseaux.GetResistanceLigne();
            }
            return somme;  
        }
        public double DiffEnergie()
        {
            double sommeEnergieLignnes = SommeEnergieLignnes();
            sommediff = sommeEnergieLignnes - this.consomEnergie;
            if(sommediff >= 0)
            {
                return this.consomEnergie;
            }
            else
            {
                string alerte = "";
                alerte += string.Format("Alerte, les lignes du consommateur {0} ne peuvent pas supporter encore {1} Watts", this.nom, Math.Abs(sommediff));
                Console.WriteLine(alerte);
                double someneg = this.consomEnergie - Math.Abs(sommediff);
                return sommeEnergieLignnes;
                
            }
        }
    }
}
