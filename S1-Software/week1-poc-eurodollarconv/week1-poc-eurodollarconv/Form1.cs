using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week1_poc_eurodollarconv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (koers.Text == "")
            {
                koers.Value = 0;
                koers.Text = "0";
                return;
            }
            if (textBox1.Text == "") //als textbox leeg is niks doen 
                   return;
            float eurowaarde = float.Parse(textBox1.Text);
            var euroindollarwaarde = eurowaarde * (float)koers.Value;
            textBox2.Text = euroindollarwaarde.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            // probeert er een , getal van te maken indien niet mogelijk word het null
            if (!double.TryParse(textBox1.Text, out parsedValue))
            {
                textBox1.Text = "";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (koers.Text == "")
            {
                koers.Value = 0;
                koers.Text = "0";
                return;
            }
            if (textBox2.Text == "") //als texbox leeg is niks doen
                return;
            float dollarwaarde = float.Parse(textBox2.Text);
            var koersVal = (float)koers.Value;

            if (koersVal == 0)
                return;
            var dollarineurowaarde = dollarwaarde/koersVal;
            textBox1.Text = dollarineurowaarde.ToString();

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            // probeert er een , getal van te maken indien niet mogelijk word het null
            if (!double.TryParse(textBox2.Text, out parsedValue))
            {
                textBox2.Text = "";
            }
        }

        private void Koers_ValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
