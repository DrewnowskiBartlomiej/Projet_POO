using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOprojet
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {         
            Node node1 = new Node();

            ProducteurEnergie P1 = new ParcEolien(15000, "ParcEolien1");
            ProducteurEnergie P2 = new CentralGaz(33000, "CentralGaz1");
            ProducteurEnergie P3 = new CentralNucleaire(50000, "CentralNucleaire1");
            ProducteurEnergie P4 = new CentralSolaire(10000, "CentralSolaire");
            //ProducteurEnergie P5 = new CentralNucleaire(10000, "CentralNucleaire2");

            node1.AddProducteurEnergie(P1);
            node1.AddProducteurEnergie(P2);
            node1.AddProducteurEnergie(P3);
            node1.AddProducteurEnergie(P4);
            //node1.AddProducteurEnergie(P5);


            LigneReseaux l1 = new LigneReseaux(10000);
            LigneReseaux l2 = new LigneReseaux(20000);
            LigneReseaux l3 = new LigneReseaux(30000);
            LigneReseaux l4 = new LigneReseaux(2000);

            Consommateur C1 = new Consommateur("Paris", 40000);
            Consommateur C2 = new Consommateur("Bruxelles", 50000);
            Consommateur C3 = new Consommateur("MaisonBart", 2500);
            Consommateur C4 = new Consommateur("MaisonOlivia", 2500);
            Consommateur C5 = new Consommateur("MaisonFelix", 2500);

            C1.Add(l1);
            C1.Add(l3);
            C2.Add(l3);
            C2.Add(l1);
            C2.Add(l4);
            C3.Add(l4);
            C4.Add(l4);
            C4.Add(l4);
            C5.Add(l4);


            node1.AddConsommateur(C1);
            node1.AddConsommateur(C2);
            node1.AddConsommateur(C3);
            node1.AddConsommateur(C4);
            node1.AddConsommateur(C5);

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(node1));
        }
    }
}
