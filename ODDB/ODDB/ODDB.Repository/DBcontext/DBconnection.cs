using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using ODDB.BusinessLogic;
using System.Configuration;

namespace ODDB.Repository.DBcontext
{
    public  class DBconnection
    {
       // string connectionString2 = ConfigurationManager.ConnectionStrings["dbi435502"].ToString();
        private static string connectionString = "Server = studmysql01.fhict.local; Uid=dbi435502;Database=dbi435502;Pwd=Falco5;";

        public string GetConnectionString() 
        {
            return connectionString;
        }

    }
}
