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
    class componentes
    {
        private string componente;
        private string descripcion;
        private string um;
        private int pl;
        private double current_cost;
        private double standar_cost;

        public string Componente { get => componente; set => componente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Um { get => um; set => um = value; }
        public int Pl { get => pl; set => pl = value; }
        public double Current_cost { get => current_cost; set => current_cost = value; }
        public double Standar_cost { get => standar_cost; set => standar_cost = value; }

        public int InsertComponentes(string componente, string descripcion, string um, string pl, decimal current_cost, decimal standar_cost)
        {
            int id = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"INSERT INTO TBLCOMPONENTES (COMPONENTE, DESCRIPTION, UM, PL, CURRENT_COST, STANDAR_COST) 
                     VALUES (@componente, @descripcion, @um, @pl, @current_cost, @standar_cost)";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@componente", componente);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@um", um);
                        cmd.Parameters.AddWithValue("@pl", pl);
                        cmd.Parameters.AddWithValue("@current_cost", current_cost);
                        cmd.Parameters.AddWithValue("@standar_cost", standar_cost);

                        cmd.Transaction = transaction;
                        cmd.ExecuteNonQuery();

                        id = (int)cmd.LastInsertedId;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción de acuerdo a tus necesidades
                    Console.WriteLine("Error al insertar el componente: " + ex.Message);
                    id = 0;
                }
                finally
                {
                    connection.Close();
                }
            }

            return id;
        }

    }
}
