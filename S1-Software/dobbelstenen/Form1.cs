using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobbelstenen
{
    public partial class Form1 : Form
    {

        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int looptimes = loopTimes.Value;
            for (int i = 0; i < looptimes; i++)
            {
                GenerateRandomNumber();
            }

            button1.Enabled = false;
        }
        private void GenerateRandomNumber()
        {
            if (textBox1.Text == "")
                return;

            int max = int.Parse(textBox1.Text);

            int randomNr = random.Next(0, max);

            lbOutput.Items.Add(randomNr.ToString());
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
            button1.Enabled = true;
            lbOutput.Items.Clear();
            telUitkomst.Text = "";
            textBox1.Text = "";
            telNummer.Text = "";
            average.Text = "gemiddelde:";
            Minlable.Text = "Minimum:";
            lblMax.Text = "Maximum:";
            loopTimes.Value = 0;
            label3.Text = "0"; 

        }


        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = loopTimes.Value.ToString();
        }
       

        private void Tellen_Click(object sender, EventArgs e)
        {
            if (telNummer.Text == "")
                return;
            int cijfer = int.Parse(telNummer.Text);
            int counter = 0;
            foreach (var item in lbOutput.Items)
            {
                int compare = int.Parse(item.ToString());
                if (compare == cijfer)
                {
                    counter++;
                }
            }
            telUitkomst.Text = counter.ToString();
        }

        private void TelNummer_TextChanged(object sender, EventArgs e)
        {

            double parsedValue;
            // probeert er een , getal van te maken indien niet mogelijk word het null
            if (!double.TryParse(telNummer.Text, out parsedValue))
            {
                telNummer.Text = "";
            }

        }

        private void GemiddeldeBerekenen_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lbOutput.Items)
            {
                int hoeveelheid = int.Parse(item.ToString());
                sum += hoeveelheid;
            }
            int gemiddeld = sum / loopTimes.Value;
            average.Text += gemiddeld.ToString();
        }

        private void MaxMin_Click(object sender, EventArgs e)
        {
            int highest = 0;
            int lowest = int.Parse(textBox1.Text);
            foreach (var item in lbOutput.Items)
            {
                int hoogste = int.Parse(item.ToString());
                if ( highest < hoogste)
                {
                    highest = hoogste; 
                }
                int laagste = int.Parse(item.ToString());
                if (lowest > laagste)
                {
                    lowest = laagste;
                }
            }
            lblMax.Text += highest.ToString();
            Minlable.Text += lowest.ToString();
        }

    }
}