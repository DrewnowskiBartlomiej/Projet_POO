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
    public partial class Form2 : Form
    {
        public Form2(List<string> productorData)
        {
            InitializeComponent();
            foreach (string data in productorData)
            { 
                textBox1.AppendText(data);
                textBox1.AppendText(Environment.NewLine);
            }
        }
        

        private void Retour_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
