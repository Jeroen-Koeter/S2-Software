using System;
using System.Collections.Generic;
using System.Text;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Common.Entities;
using MySql.Data.MySqlClient;
namespace ODDB.Repository.Repositories
{
    class AccountRepository : IAccountRepository
    {
        static DBcontext.DBconnection DBconnect = new DBcontext.DBconnection();
        private static string connectionstring = DBconnect.GetConnectionString();
        MySqlConnection con = new MySqlConnection(connectionstring);

        public User GetUserByEmail(string Email)
        {
            User gebruiker = new User();
            con.Open();
            string sql = "Select Naam, Email, Wachtwoord, UserID from Gebruiker Where gebruiker.Email = @email";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@email", Email);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) 
            {                
                gebruiker.Naam = rdr.GetString(0);
                gebruiker.Email = rdr.GetString(1);
                gebruiker.Wachtwoord = rdr.GetString(2);
                gebruiker.UserID = rdr.GetGuid(3);
            }
            return gebruiker; 
        }

        public void RegisterUser(Guid ID, string Naam, string Email, string hashedWachtwoord)
        {
            con.Open();
            string sql = "INSERT INTO `gebruiker`(`UserID`, `Naam`, `Wachtwoord`, `Email`) VALUES (@ID, @naam, @wachtwoord, @email)";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@naam", Naam);
            cmd.Parameters.AddWithValue("@wachtwoord", hashedWachtwoord);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
