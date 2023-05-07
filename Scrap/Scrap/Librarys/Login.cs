using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Scrap.Librarys
{
    class Login
    {
        private int idUser;
        private string usuario;
        public int IdUser { get => idUser; set => idUser = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public bool HaveAcces(string user, string password)
        {
            bool have = false;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT USU_ID, USU_NOMBRE FROM usuariossistema
                           WHERE USU_PLACAS=?user AND USU_PASSWORD=?password
                           AND ESTADO='SCRAP'";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("password", password);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    have = true;
                    while (dr.Read())
                    {
                        idUser = int.Parse(dr[0].ToString());
                        usuario = dr[0].ToString();
                    }

                }

                connection.Close();
            }

            return have;
        }
    }
}
