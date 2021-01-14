using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ODDB.BusinessLogic.Interfaces;
using MySql.Data.MySqlClient;
using ODDB.Common.Entities;

namespace ODDB.Repository.Repositories
{
    public class BucketListRepository : IBucketListRepository
    {
        static DBcontext.DBconnection DBconnect = new DBcontext.DBconnection();
        private static string connectionstring = DBconnect.GetConnectionString();
        MySqlConnection con = new MySqlConnection(connectionstring);
        public void CreateBucketList(string Naam, string UserID)
        {
            con.Open();
            string sql = "INSERT INTO `bucketlist`( `Eigenaar`, `Naam`) VALUES(@eigenaar, @naam)";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@eigenaar", UserID);
            cmd.Parameters.AddWithValue("@naam", Naam);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AddDrank(int BucketlistID, int DrankID)
        {
            con.Open();
            string sql = "INSERT INTO `buckelistentry`(`BucketListID`, `DrankID`) VALUES (@bucketlistID,@drankID)";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bucketlistID", BucketlistID);
            cmd.Parameters.AddWithValue("@drankID", DrankID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Task DeleteDrank(Drank drank)
        {
            throw new NotImplementedException();
        }

        public List<Bucketlist> GetBucketlistsByUser(string UserID)
        {
            con.Open();
            string sql = "SELECT Naam, BucketListID, Eigenaar FROM `bucketlist` WHERE Eigenaar = @eigenaar ";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@eigenaar", UserID);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Bucketlist> Bucketlists = new List<Bucketlist>();
            while (rdr.Read())
            {
                Bucketlist bucketlist = new Bucketlist();
                bucketlist.Naam = rdr.GetString(0);
                bucketlist.BucketListId = rdr.GetInt16(1);
                bucketlist.Eignenaar = rdr.GetGuid(2);
                Bucketlists.Add(bucketlist);
            }
            con.Close();
            return Bucketlists;
        }
        public List<Drank> GetDrankFromBucketlist(int BucketlistID) 
        {
            con.Open();
            string sql = "SELECT drank.Naam , drank.Type, drank.Omschrijving, drank.AlcoholPercentage FROM Drank, buckelistentry WHERE buckelistentry.DrankID = drank.DrankID and buckelistentry.BucketListID = @bucketlistID";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bucketlistID", BucketlistID);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Drank> DrankList = new List<Drank>();
            while (rdr.Read())
            {
                Drank drank = new Drank();
                drank.Naam = rdr.GetString(0);
                drank.Type = rdr.GetString(1);
                drank.Omschrijving = rdr.GetString(2);
                drank.AlcoholPecentage = rdr.GetDouble(3);
                DrankList.Add(drank);
            }
            con.Close();
            return DrankList;
        }
        public List<Drank> GetNotInBucketlist(int BucketListID) 
        {
            con.Open();
            string sql = "SELECT drank.Naam , drank.Type, drank.Omschrijving, drank.AlcoholPercentage FROM Drank where drank.DrankID not in (select drank.DrankID FROM drank, buckelistentry WHERE buckelistentry.DrankID = drank.DrankID and buckelistentry.BucketListID = @bucketlistID) ";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bucketlistID", BucketListID);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Drank> DrankList = new List<Drank>();
            while (rdr.Read())
            {
                Drank drank = new Drank();
                drank.Naam = rdr.GetString(0);
                drank.Type = rdr.GetString(1);
                drank.Omschrijving = rdr.GetString(2);
                drank.AlcoholPecentage = rdr.GetDouble(3);
                DrankList.Add(drank);
            }
            con.Close();
            return DrankList;
        }
    }
}
