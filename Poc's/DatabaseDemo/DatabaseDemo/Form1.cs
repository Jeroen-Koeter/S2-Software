using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo
{
    public partial class Form1 : Form
    {
        private static string connetionString = @"Server=studmysql01.fhict.local;Uid=dbi435502; password=Falco5; Database=dbi435502;";
        private MySqlConnection con = new MySqlConnection(connetionString);
        public Form1()
        {
            InitializeComponent();

        }

        private void SQLButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = QueryTextBox.Text;
            var cmd = new MySqlCommand(sql, con);

            if (sql.StartsWith("SELECT", StringComparison.CurrentCultureIgnoreCase))
            {

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ResultTextBox.Text += rdr.GetInt32(0) + " " + rdr.GetString(1) + " " + rdr.GetString(2) + " " + rdr.GetString(3)  + "\r\n";
                }
                QueryTextBox.Text = "";
            }
            if (sql.StartsWith("INSERT", StringComparison.CurrentCultureIgnoreCase))
            {

                cmd.ExecuteNonQuery();
                ResultTextBox.Text += "Row inserted \r\n";
                QueryTextBox.Text = "";
            }
            if (sql.StartsWith("DELETE", StringComparison.CurrentCultureIgnoreCase))
            {

                cmd.ExecuteNonQuery();
                ResultTextBox.Text += "Row deleted \r\n";
                QueryTextBox.Text = "";
            }
            if (sql.StartsWith("UPDATE", StringComparison.CurrentCultureIgnoreCase))
            {

                cmd.ExecuteNonQuery();
                ResultTextBox.Text += "Row updated \r\n";
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
