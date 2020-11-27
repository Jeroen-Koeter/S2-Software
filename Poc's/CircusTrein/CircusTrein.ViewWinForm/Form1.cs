using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircusTrein.Application;

namespace CircusTrein.ViewWinForm
{
    public partial class Form1 : Form
    {
       private List<Dier> dieren = new List<Dier>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAnimalButton_Click(object sender, EventArgs e)
        {
            string naam = NameTextBox.Text;   
            string dieet = DietTextBox.Text;
            string grote = SizeTextBox.Text;
            dieren.Add(Algoritme.AddAnimal(naam, dieet, grote));
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            List<Wagon> wagonLijstCompleet = Algoritme.RunAlgoritme(dieren);
            foreach (Wagon wagon in wagonLijstCompleet)
            {
                SortTextBox.Text += (wagon.Naam + " - Gewicht: " + wagon.HuidigeGrote + "\r\n");
                foreach (Dier dier in wagon.Dieren)
                {
                    SortTextBox.Text += ("    " + dier.naam + " " + dier.size + " " + dier.diet + "\r\n");
                }
                SortTextBox.Text += (""+"\r\n");
            }
        }
    }
}
