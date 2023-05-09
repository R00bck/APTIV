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
    class Estacion
    {
        private int num_est;
        private string lado;
        private int maq_id;
        private int are_id;
        private int idAsigna;
        private string area;
        private int negocio;
        public int Num_Est { get => num_est; set => num_est = value; }
        public string Lado { get => lado; set => lado = value; }
        public int Maq_id { get => maq_id; set => maq_id = value; }
        public int Are_id { get => are_id; set => are_id = value; }
        public int IdAsigna { get => idAsigna; set => idAsigna = value; }
        public string Area { get => area; set => area = value; }
        public int Negocio { get => negocio; set => negocio = value; }

        public bool Linea(string hdd)
        {
            bool regresa = false;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT M.MAQ_ID AS ID, M.MAQ_NUMERO AS NUMERO, M.MAQ_LADO AS LADO, M.ARE_ID, A.ARE_AREA, M.NEG_ID
                             FROM MAQUINARIA M
                             INNER JOIN AREAS A ON A.ARE_ID = M.ARE_ID
                             INNER JOIN COMPUESTACIONES CE ON CE.MAQ_ID = M.MAQ_ID
                             WHERE CE.HDD_ID=?hdd";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("hdd", hdd);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    regresa = true;
                    while (dr.Read())
                    {
                        maq_id = int.Parse(dr[0].ToString());
                        num_est = int.Parse(dr[1].ToString());
                        lado = dr[2].ToString();
                        are_id = int.Parse(dr[3].ToString());
                        area = dr[4].ToString();
                        negocio = int.Parse(dr[5].ToString());
                    }

                }
                dr.Close();
                connection.Close();

                return regresa;
            }
        }
    }
}
