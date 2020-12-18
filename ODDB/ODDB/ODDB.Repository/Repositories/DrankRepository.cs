using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Common.Entities;
using MySql.Data.MySqlClient;

namespace ODDB.Repository.Repositories
{
    public class DrankRepository : IDrankRepository
    {
        static DBcontext.DBconnection DBconnect = new DBcontext.DBconnection();
        private static string connectionstring = DBconnect.GetConnectionString();
        MySqlConnection con = new MySqlConnection(connectionstring);

        public List<Drank> GetAll()
        {
            con.Open();
            string sql = "select * from drank";
            var cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Drank> DrankList = new List<Drank>();
            while (rdr.Read())
            {
                Drank drank = new Drank();
                drank.DrankID = rdr.GetInt16(0);
                drank.Naam = rdr.GetString(1);
                drank.Type = rdr.GetString(2);
                drank.omschrijving = rdr.GetString(3);
                drank.AlcoholPecentage = rdr.GetDouble(4);
                DrankList.Add(drank);
            }
            return DrankList;
        }

        public Drank GetDrankByID(int Id)
        {
            throw new NotImplementedException();
        }

        void IDrankRepository.CreateDrank(Drank drank)
        {
            throw new NotImplementedException();
        }
    }
}
