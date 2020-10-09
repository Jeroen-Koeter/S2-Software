using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAlgoritm
{
    public partial class Form1 : Form
    {
        private List<double> prijsLijst = new List<double>();
        private List<string> productenLijst = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(productTextBox.Text)))
            {
                if (!(string.IsNullOrEmpty(prijsTextBox.Text)))
                {
                    bonTextBox.Text += productTextBox.Text + " €" + prijsTextBox.Text + "\r\n";
                    prijsLijst = MakePrijsList(double.Parse(prijsTextBox.Text));
                    productenLijst = MakeProductenList(productTextBox.Text);
                }
            }
        }

        private void prijsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void getAllTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void GiveMaximumPrice()
        {
            double prijsTemp;
            double[] prijsArray = prijsLijst.ToArray();
            foreach (var item in prijsLijst)
            {
                for (int i = 0; i <= prijsArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < prijsArray.Length; j++)
                    {
                        if (prijsArray[i] < prijsArray[j])
                        {
                            prijsTemp = prijsArray[i];
                            prijsArray[i] = prijsArray[j];
                            prijsArray[j] = prijsTemp;
                        }
                    }
                }
            }
            string prijsString = prijsArray[0].ToString("0.00");
            maxLabel.Text ="De hoogste prijs is €" + prijsString;
        }
        private void SortProductsByPrice()
        {
            bonTextBox.Text = "";
            double prijsTemp;
            string productTemp;
            double[] prijsArray = prijsLijst.ToArray();
            string[] productenArray = productenLijst.ToArray();
            foreach (var item in prijsLijst)
            {
                for (int i = 0; i <= prijsArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < prijsArray.Length; j++)
                    {
                        if (prijsArray[i] > prijsArray[j])
                        {
                            prijsTemp = prijsArray[i];
                            prijsArray[i] = prijsArray[j];
                            prijsArray[j] = prijsTemp;
                            productTemp = productenArray[i];
                            productenArray[i] = productenArray[j];
                            productenArray[j] = productTemp;
                        }
                    }
                }
            }
            for (int i = 0; i <= prijsArray.Length - 1; i++)
            {
                string prijsString = prijsArray[i].ToString("0.00");
                string productString = productenArray[i].ToString();
                bonTextBox.Text += productString + " €" + prijsString + "\r\n";
            }
        }
        private void GiveAvaragePrice()
        {
            double totalePrijs = 0;
            double gemiddeldePrijs;
            for (int i = 0; i < prijsLijst.Count; i++)
            {
                double prijs1 = prijsLijst[i];
                totalePrijs += prijs1;
            }
            gemiddeldePrijs = totalePrijs / prijsLijst.Count;
            averageLabel.Text = "Gemiddelde prijs per product: €" + gemiddeldePrijs;
        }
        private void GetAllProducts()
        {           
                bonTextBox.Text = "";
                string prijs = getAllTextBox.Text;
                double prijsDouble = double.Parse(prijs);
                double[] prijsArray = prijsLijst.ToArray();
                string[] productenArray = productenLijst.ToArray();
                for (int i = 0; i <= prijsArray.Length - 1; i++)
                {
                    if (prijsArray[i] == prijsDouble)
                    {
                        string prijsString = prijsArray[i].ToString("0.00");
                        string productString = productenArray[i].ToString();
                        bonTextBox.Text += productString + " €" + prijsString + "\r\n";
                    }
                }
        }


        private void maxButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(bonTextBox.Text)))
            {
                GiveMaximumPrice();
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(bonTextBox.Text)))
            {
                SortProductsByPrice();
            }
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(bonTextBox.Text)))
            {
                GiveAvaragePrice();
            }
        }

        private void getAllButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(getAllTextBox.Text)))
            {
                GetAllProducts();
            }
        }

        private List<double> MakePrijsList(double price)
        {
            prijsLijst.Add(price);
            return prijsLijst;
        }
        private List<string> MakeProductenList(string product)
        {
            productenLijst.Add(product);
            return productenLijst;
        }
    }
}