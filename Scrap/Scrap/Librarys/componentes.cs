using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
        private string searchcomp;

        public string Componente { get => componente; set => componente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Um { get => um; set => um = value; }
        public int Pl { get => pl; set => pl = value; }
        public double Current_cost { get => current_cost; set => current_cost = value; }
        public double Standar_cost { get => standar_cost; set => standar_cost = value; }
        public string SearchComp { get => searchcomp; set => searchcomp = value; }


        // Metodo Insertar Componentes
        public int InsertComponentes(string componente, string descripcion, string um, int pl, decimal current_cost, decimal standar_cost)
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
                    MessageBox.Show("Error al insertar el componente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id = 0;
                }
                finally
                {
                    connection.Close();
                }
            }

            return id;
        }

        // Metodo Actualizar Componentes
        public int UpdateComponentes(string componente, string descripcion, string um, int pl, decimal current_cost, decimal standar_cost)
        {
            int id = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"UPDATE TBLCOMPONENTES SET COMPONENTE=?componente, DESCRIPTION=?descripcion, UM=?um, PL=?pl, CURRENT_COST=?current_cost, STANDAR_COST=?standar_cost
                             WHERE componente=?componente";

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
                        MessageBox.Show("Componente actualizado correctamente");

                        id = (int)cmd.LastInsertedId;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción de acuerdo a tus necesidades
                    MessageBox.Show("Error al insertar el componente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id = 0;
                }
                finally
                {          
                    connection.Close();
                }
            }

            return id;
        }

        // Metodo Eliminar Componentes
        public int DeleteComponentes(string componente)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"DELETE FROM TBLCOMPONENTES WHERE COMPONENTE = @componente";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@componente", componente);

                        cmd.Transaction = transaction;
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción de acuerdo a tus necesidades
                    MessageBox.Show("Error" + ex.Message, "Error al eliminar el componente: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                finally
                {
                    connection.Close();
                }
                return 0;
            }
        }

        // Metodo Buscar Componentes
        public int SearchComponentes(string searchcomp)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT ID, COMPONENTE, DESCRIPTION, UM, PL, CURRENT_COST FROM TBLCOMPONENTES 
                             WHERE COMPONENTE LIKE '%@searchcomp%'";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);

                        connection.Close();

                        return dt;
                        /* 
                         MySqlCommand cmd = new MySqlCommand(query, connection);
                         cmd.Parameters.AddWithValue("@searchcomp", searchcomp);

                         cmd.Transaction = transaction;
                         cmd.ExecuteNonQuery();

                         transaction.Commit();
                        */
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción de acuerdo a tus necesidades
                    MessageBox.Show("Error al Buscar el componente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
                return 0;
            }
        }



    }
}
