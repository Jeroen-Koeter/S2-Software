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
            try { 
            con.Open();
            string sql = "select drank.drankID, drank.Naam, drank.Type, drank.Omschrijving, drank.AlcoholPercentage from drank order by AlcoholPercentage";
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
         
            return DrankList;
        }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;

            }
            finally
            {
                con.Close();
            }
        }


        public List<Drank> GetDrankByAttribute(string Attribute, string data)
        {
            try { 
            con.Open();
            string sql = "";
            if (Attribute == "Type")
            {
                sql = "select drank.drankID, drank.Naam, drank.Type, drank.Omschrijving, drank.AlcoholPercentage from drank Where Type like @data";
            }
            if (Attribute == "Naam")
            {
                sql = "select drank.drankID, drank.Naam, drank.Type, drank.Omschrijving, drank.AlcoholPercentage from drank Where Naam like @data";
            }
            if (Attribute == "AlcoholPercentage")
            {
                sql = "select drank.drankID, drank.Naam, drank.Type, drank.Omschrijving, drank.AlcoholPercentage from drank Where AlcoholPercentage like @data";
            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@data", $"%{data}%");
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
            return DrankList;
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;

            }
            finally
            {
                con.Close();
            }
        }

       

        void IDrankRepository.CreateDrank(Drank drank)
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO `drank`(`Naam`, `Type`, `Omschrijving`, `AlcoholPercentage`) VALUES (@naam,@type,@omschrijving,@alcoholpercentage)";
                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@naam", drank.Naam);
                cmd.Parameters.AddWithValue("@type", drank.Type);
                cmd.Parameters.AddWithValue("@omschrijving", drank.Omschrijving);
                cmd.Parameters.AddWithValue("@alcoholpercentage", drank.AlcoholPecentage);
                cmd.ExecuteNonQuery();
            }
              

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
        void IDrankRepository.DeleteDrank(int DrankID) 
        {
            try { 
            con.Open();
            string sql = "DELETE FROM drank WHERE DrankID = @ID";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", DrankID);
            cmd.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
        public Drank GetDrankByID(int DrankID)
        {
            try { 
            con.Open();
            string sql = "SELECT drank.drankID, drank.Naam, drank.Type, drank.Omschrijving, drank.AlcoholPercentage FROM drank WHERE DrankID = @ID";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", DrankID);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Drank drank = new Drank();
            while (rdr.Read())
            {                
                drank.DrankID = rdr.GetInt16(0);
                drank.Naam = rdr.GetString(1);
                drank.Type = rdr.GetString(2);
                drank.Omschrijving = rdr.GetString(3);
                drank.AlcoholPecentage = rdr.GetDouble(4);
            }
            return drank;
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateDrank(Drank drank)
        {
            //"UPDATE `drank` SET `Naam`=[value-2],`Type`=[value-3],`Omschrijving`=[value-4],`AlcoholPercentage`=[value-5] WHERE DrankID = @drankID"
            throw new NotImplementedException();
        }
    }
}
