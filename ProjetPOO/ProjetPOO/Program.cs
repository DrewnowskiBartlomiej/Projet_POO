using System;

namespace ProjetPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double prixElecEtrangere = random.Next(150, 200);
            //////////////////Noeud de Consommateur////////////////////////
            ConsommateurEnergie consommateurEnergie = new ConsommateurEnergie();
            SourceEnergie sourceEnergie = new SourceEnergie();

            LigneReseaux l1 = new LigneReseaux(2500);
            LigneReseaux l2 = new LigneReseaux(2500);
            LigneReseaux l3 = new LigneReseaux(1000);

            Consommateur C1 = new Consommateur("Paris", 1500);
            Consommateur C2 = new Consommateur("Bruxelles", 500);
            Consommateur C3 = new Consommateur("MaisonBart", 2500);
            Consommateur C4 = new Consommateur("MaisonOlivia", 2500);
            Consommateur C5 = new Consommateur("MaisonFelix", 2500);

            C1.Add(l1);
            C1.Add(l2);
            C1.Add(l3);
            C2.Add(l3);
            C3.Add(l2);
            C4.Add(l2);
            C5.Add(l3);


            consommateurEnergie.Add(C1);
            consommateurEnergie.Add(C2);
            consommateurEnergie.Add(C3);
            consommateurEnergie.Add(C4);
            consommateurEnergie.Add(C5);

            Console.WriteLine(consommateurEnergie.SommeEnergieConsomateursLignes());
            Console.WriteLine(consommateurEnergie.SommeEnergieConsomme());
           
           // Console.WriteLine(C1.DiffEnergie());


            ///////////////////Meteo////////////////////////////

            Console.WriteLine(Meteo.GetEnsoleillement());
            Console.WriteLine(Meteo.GetForceDuVent());
            Console.WriteLine(Meteo.GetTemperature());

            //////////////////////Noeud de Producteur/////////////////////
            //ParcEolien producteurParcEolien = new ParcEolien(10000);
/*
            ProducteurEnergie P1 = new ParcEolien(1000000);
            ProducteurEnergie P2 = new CentralGaz(330000);
            ProducteurEnergie P3 = new CentralNucleaire(500000);
            ProducteurEnergie P4 = new CentralSolaire(10000);
            
            sourceEnergie.Add(P1);
            sourceEnergie.Add(P2);
            sourceEnergie.Add(P3);
            sourceEnergie.Add(P4);

            Console.WriteLine(P1.Production());
            Console.WriteLine(P1.CoutProduction());
            Console.WriteLine(P2.Production());
            Console.WriteLine(P2.CoutProduction());
            Console.WriteLine(P2.Emission());
            Console.WriteLine(P3.Production());
            Console.WriteLine(P3.CoutProduction());
            Console.WriteLine(P4.Production());
            Console.WriteLine(P4.CoutProduction());

            Console.WriteLine(sourceEnergie.SommeEnergiePrduite());
*/
        }
    }
}
