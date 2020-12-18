using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPOO
{
    
    class ConsommateurEnergie
    {
        private List<Consommateur> listconsommateurs;
        public ConsommateurEnergie()
        {
            this.listconsommateurs = new List<Consommateur>();
        }
        
        public void Add(Consommateur consommateur)
        {
            this.listconsommateurs.Add(consommateur);
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
    }
    

}
