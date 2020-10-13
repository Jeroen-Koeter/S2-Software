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
        private List<Product> ProductenLijst = new List<Product>();
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
                    Product product = new Product(double.Parse(prijsTextBox.Text), productTextBox.Text);
                    ProductenLijst.Add(product);
                    bonTextBox.Text += productTextBox.Text + " €" + prijsTextBox.Text +  "\r\n";

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
            Product productTemp;
            Product[] productenArray = ProductenLijst.ToArray();
            foreach (var item in ProductenLijst)
            {
                for (int i = 0; i <= productenArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < productenArray.Length; j++)
                    {
                        if (productenArray[i].prijs < productenArray[j].prijs)
                        {
                            productTemp = productenArray[i];
                            productenArray[i] = productenArray[j];
                            productenArray[j] = productTemp;
                        }
                    }
                }
            }
            maxLabel.Text = "De hoogste prijs is €" + productenArray[0].prijs;
        }
        private void SortProductsByPrice()
        {
            bonTextBox.Text = "";
            Product productTemp;
            Product[] productenArray = ProductenLijst.ToArray();
            foreach (var item in ProductenLijst)
            {
                for (int i = 0; i <= productenArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < productenArray.Length; j++)
                    {
                        if (productenArray[i].prijs > productenArray[j].prijs)
                        {
                            productTemp = productenArray[i];
                            productenArray[i] = productenArray[j];
                            productenArray[j] = productTemp;
                        }
                    }
                }
            }
            for (int i = 0; i <= productenArray.Length - 1; i++)
            {
                Product productString = productenArray[i];
                bonTextBox.Text += productString.naam + " €" + productString.prijs + "\r\n";
            }
        }
        private void GiveAvaragePrice()
        {
            double totalePrijs = 0;
            double gemiddeldePrijs;
            for (int i = 0; i < ProductenLijst.Count; i++)
            {
                double prijs1 = ProductenLijst[i].prijs;
                totalePrijs += prijs1;
            }
            gemiddeldePrijs = totalePrijs / ProductenLijst.Count;
            averageLabel.Text = "Gemiddelde prijs per product: €" + gemiddeldePrijs;
        }
        private void GetAllProducts()
        {
            bonTextBox.Text = "";
            string prijs = getAllTextBox.Text;
            double prijsDouble = double.Parse(prijs);
            Product[] productenArray = ProductenLijst.ToArray();
            for (int i = 0; i <= productenArray.Length - 1; i++)
            {
                if (productenArray[i].prijs == prijsDouble)
                {
                    Product productString = productenArray[i];
                    bonTextBox.Text += productString.naam + " €" + productString.prijs + "\r\n";
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
    }
}