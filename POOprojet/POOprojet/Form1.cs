using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace POOprojet
{
    public partial class Form1 : Form
    {
        private bool refresh = true;
        private Node node2;
        public Form1(Node node1)
        {
            InitializeComponent();
            node2 = node1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            refresh = !refresh;

            // Call the method that runs asynchronously.
            await WaitAsynchronouslyAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> producteurData = new List<string>();
            foreach (ProducteurEnergie producteur in node2.listProducteur)
            {
                producteurData.Add(producteur.GetName() + " peut poduie jusqu'à " + producteur.GetMaxProduction() + " Watt et sa emission est de " + producteur.Emission());
            }

            Form2 form2 = new Form2(producteurData);
            form2.Owner = this;
            this.Hide();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (ProducteurEnergie producteurEnergie in node2.listProducteur)
            {
                comboBox1.Items.Add(producteurEnergie.GetName());
            }
            comboBox1.SelectedIndex = 0;
            
            //Show the graph of the production cost 
            foreach (ProducteurEnergie producteurEnergie in node2.listProducteur)
            {
                chart2.Series["Production"].Points.AddXY(producteurEnergie.GetName(), producteurEnergie.CoutProduction());
            }
            //Show the graph of the Market 
            chart1.Series["Uranium"].Points.AddXY("", FuelMarket.GetUraniumPrice());
            chart1.Series["Gas"].Points.AddXY("", FuelMarket.GetGasPrice());
            chart1.Series["Carbon"].Points.AddXY("", FuelMarket.GetCarbonPrice());
            chart1.Series["Foreign Energy"].Points.AddXY("", FuelMarket.GetForeignEnergy());
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

        public async Task WaitAsynchronouslyAsync()
        {
            while (true) {
                chart2.Series["Production"].Points.Clear();
                chart3.Series["Energy"].Points.Clear();

                Meteo.RandomMeteo();
                FuelMarket.RandomPriceOfFuel();

                //Show the graph of the production cost 
                foreach (ProducteurEnergie producteurEnergie in node2.listProducteur)
                {
                    chart2.Series["Production"].Points.AddXY(producteurEnergie.GetName(), producteurEnergie.Production());
                }
                //Show the graph of the Market 
                chart1.Series["Uranium"].Points.AddXY("", FuelMarket.GetUraniumPrice());
                chart1.Series["Gas"].Points.AddXY("", FuelMarket.GetGasPrice());
                chart1.Series["Carbon"].Points.AddXY("", FuelMarket.GetCarbonPrice());
                chart1.Series["Foreign Energy"].Points.AddXY("", FuelMarket.GetForeignEnergy());
                //Show the graph of Energy management 
                chart3.Series["Energy"].Points.AddXY("Consumption", node2.SommeEnergieConsomme());
                chart3.Series["Energy"].Points.AddXY("Production", node2.SommeEnergiePrduite());
                chart3.Series["Energy"].Points.AddXY("Purchased energy", node2.GetEnergyMissing());
                chart3.Series["Energy"].Points.AddXY("Energy sold", node2.GetEnergyOverproduced());
                //Refresh of weather
                labelEnsoleillement.Text = string.Format("Ensoleillement : {0} %", Meteo.GetEnsoleillement());
                labelVent.Text = string.Format("Force du vent : {0} km/h", Meteo.GetForceDuVent());
                labelTemperature.Text = string.Format("Température : {0} °C", Meteo.GetTemperature());
                //delay 1000ms
                await Task.Delay(1000);
                //Stop the loop
                if (refresh) { break; }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            node2.listProducteur[comboBox1.SelectedIndex].SetON();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            node2.listProducteur[comboBox1.SelectedIndex].SetOFF();
        }
    }
}
