using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using ODDB.BusinessLogic;

namespace ODDB.Repository.DBcontext
{
    public  class DBconnection
    {

        private static string connectionString = "Server = studmysql01.fhict.local; Uid=dbi435502;Database=dbi435502;Pwd=Falco5;";

        public string GetConnectionString() 
        {
            return connectionString;
        }

    }
}
