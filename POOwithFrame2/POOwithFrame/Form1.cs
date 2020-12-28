using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOwithFrame
{
    public partial class Form1 : Form
    {
        private Node node2;
        //private Network network;

        public Form1(Node node1)
        {
            InitializeComponent();
            node2 = node1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (ProducteurEnergie producteurEnergie in node2.listProducteur)
            {
                chartPRICE.Series["test"].Points.AddXY(producteurEnergie.GetName(), producteurEnergie.CoutProduction());
            }
            //Show the graph of the Market 
            chart2.Series["Uranium"].Points.AddXY("", FuelMarket.GetUraniumPrice());
            chart2.Series["Gas"].Points.AddXY("", FuelMarket.GetGasPrice());
            chart2.Series["Carbon"].Points.AddXY("", FuelMarket.GetCarbonPrice());
            chart2.Series["Foreign Energy"].Points.AddXY("", FuelMarket.GetForeignEnergy());

            labelEnsoleillement.Text = string.Format("Ensoleillement : {0} %", Meteo.GetEnsoleillement());
            labelVent.Text = string.Format("Force du vent : {0} km/h", Meteo.GetForceDuVent());
            labelTemperature.Text = string.Format("Température : {0} °C", Meteo.GetTemperature());
            //chartPRICE.AxisX.ScaleView.Zoom(firstDataPoint, lastDataPointInView);
            //chartPRICE.AxisViewChanging();

        }

        private void buttonPRODUC_Click(object sender, EventArgs e)
        {
            List<string> producteurData = new List<string>();
            foreach (ProducteurEnergie producteur in node2.listProducteur)
            {
                producteurData.Add(producteur.GetName()+ " peut poduie jusqu'à " + producteur.GetMaxProduction()+" Watt et sa emission est de " + producteur.Emission());
            }

            Form2 form2 = new Form2(producteurData);
            form2.Owner = this;
            this.Hide();
            form2.Show();
        }

        private void chartPRICE_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRAF_Click(object sender, EventArgs e)
        {
            chartPRICE.Series["test"].Points.Clear();
            chart3.Series["Energy"].Points.Clear();

            Meteo.RandomMeteo();
            FuelMarket.RandomPriceOfFuel();

            //Show the graph of the production cost 
            foreach (ProducteurEnergie producteurEnergie in node2.listProducteur)
            {
                chartPRICE.Series["test"].Points.AddXY(producteurEnergie.GetName(), producteurEnergie.CoutProduction());
            }
            //Show the graph of the Market 
            chart2.Series["Uranium"].Points.AddXY("", FuelMarket.GetUraniumPrice());
            chart2.Series["Gas"].Points.AddXY("", FuelMarket.GetGasPrice());
            chart2.Series["Carbon"].Points.AddXY("", FuelMarket.GetCarbonPrice());
            chart2.Series["Foreign Energy"].Points.AddXY("", FuelMarket.GetForeignEnergy());
            //Show the graph of Energy management 
            chart3.Series["Energy"].Points.AddXY("Consumption", node2.SommeEnergieConsomme());
            chart3.Series["Energy"].Points.AddXY("Production", node2.SommeEnergiePrduite());
            chart3.Series["Energy"].Points.AddXY("Purchased energy", node2.GetEnergyMissing());
            chart3.Series["Energy"].Points.AddXY("Energy sold", node2.GetEnergyOverproduced());
            //Refresh of weather
            labelEnsoleillement.Text = string.Format("Ensoleillement : {0} %", Meteo.GetEnsoleillement());
            labelVent.Text = string.Format("Force du vent : {0} km/h", Meteo.GetForceDuVent());
            labelTemperature.Text = string.Format("Température : {0} °C", Meteo.GetTemperature());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCONSOM_Click(object sender, EventArgs e)
        {
            List<string> alertMessage = new List<string>();
            foreach (Consommateur consommateur in node2.listconsommateurs)
            {
                if (consommateur.Alert() != "")
                {
                    alertMessage.Add(consommateur.Alert());
                }
            }
            List<string> consumerData = new List<string>();
            foreach (Consommateur consommateur in node2.listconsommateurs)
            {
                consumerData.Add(consommateur.Getnom() + " a besoin de " + consommateur.GetconsomEnergie() + " Watt");
            }

            Form3 form3 = new Form3(alertMessage, consumerData);
            form3.Owner = this;
            this.Hide();
            form3.Show();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
