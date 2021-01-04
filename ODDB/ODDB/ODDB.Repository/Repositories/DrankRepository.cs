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
                drank.Omschrijving = rdr.GetString(3);
                drank.AlcoholPecentage = rdr.GetDouble(4);
                DrankList.Add(drank);
            }
            con.Close();
            return DrankList;
        }

        public Drank GetDrankByID(int Id)
        {
            throw new NotImplementedException();
        }

        void IDrankRepository.CreateDrank(Drank drank)
        {
            con.Open();
            string sql = $"INSERT INTO `drank`(`Naam`, `Type`, `Omschrijving`, `AlcoholPercentage`) VALUES (@naam,@type,@omschrijving,@alcoholpercentage)";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@naam", drank.Naam);
            cmd.Parameters.AddWithValue("@type", drank.Type);
            cmd.Parameters.AddWithValue("@omschrijving", drank.Omschrijving);
            cmd.Parameters.AddWithValue("@alcoholpercentage", drank.AlcoholPecentage);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
