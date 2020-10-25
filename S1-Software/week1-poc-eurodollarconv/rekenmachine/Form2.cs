using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Minus();
        }

        private void Minus()
        {
            if (Input1.Text == "" && Input2.Text == "")
                return;

            float een = float.Parse(Input1.Text);
                float twee = float.Parse(Input2.Text);
                var min = een - twee;
                if (min < 0)
                { Output.ForeColor = Color.Red; }
                Output.Text = "uitkomst: " + min;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            plus();
        }

        private void plus()
        {
            if (Input1.Text == "" && Input2.Text == "")
                return;
            float een = float.Parse(Input1.Text);
            float twee = float.Parse(Input2.Text);
            var som = een + twee;
            Output.Text = "uitkomst: " + som;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            times();
        }

        private void times()
        {
            if (Input1.Text == "" && Input2.Text == "")
                return;
            float een = float.Parse(Input1.Text);
            float twee = float.Parse(Input2.Text);
            var keer = een * twee;
            Output.Text = "uitkomst: " + keer;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            devide();

        }

        private void devide()
        {
            if (Input1.Text == "" && Input2.Text == "")
                return;
            float een = float.Parse(Input1.Text);
            float twee = float.Parse(Input2.Text);
            var tweeval = float.Parse(Input2.Text);
            if ( tweeval == 0)
            {
                Output.Text = "delen door nul is flauwekul!";
                return;
            }
            var deel = een / twee;
            Output.Text = "uitkomst: " + deel;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            wortel();
        }
        private void wortel()
        {
            if (Input1.Text == "")
                return;
            if (Input2.Text != "")
                return; 
            float een = float.Parse(Input1.Text);
            var wortel = Math.Sqrt(een);
            Output.Text = "uitkomst: " + wortel;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            macht();
        }
        private void macht()
        {
            if (Input1.Text == "")
                return;
            if (Input2.Text != "")
                return;
            float een = float.Parse(Input1.Text);
            var macht = een * een;
            Output.Text = "uitkomst: " + macht;
        }
      
    }
}
