using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;

namespace ODDB.Repository.DBcontext
{
    class DBconnection
    {
        private static string connetionString = @"Server=studmysql01.fhict.local;Uid=dbi435502; password=Falco5; Database=dbi435502;";
        private MySqlConnection con = new MySqlConnection(connetionString);

        public void OpenConnection() 
        {
            con.Open();
        }

        public void CloseConnection() 
        {
            con.Close();
        }

    }
}
