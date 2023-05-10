using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap.Forms
{
    public partial class frmCapturas : Form
    {
        public frmCapturas()
        {
            InitializeComponent();
        }

        private void gdpnlMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmCapturas_Load(object sender, EventArgs e)
        {
            dgvComponentes.DataSource = GetComponentesList();
        }

        private DataTable GetComponentesList()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT ID, COMPONENTE, DESCRIPTION, UM, PL, CURRENT_COST FROM TBLCOMPONENTES 
                           ORDER BY ID ASC";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string componente;
            string descripcion;
            string um;
            int pl;
            string current_cost;
            string standar_cost;

            componente = txtComponente.Text;
            descripcion = txtDescripcion.Text;
            um = txtUM.Text;
            pl = Convert.ToInt32(txtPL.Text);
            current_cost = txtCurrentCost.Text;
            standar_cost = "NULL";

           

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                try 
                { 
                   
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"INSERT INTO TBLCOMPONENTES (COMPONENTE, DESCRIPTION, UM, PL, CURRENT_COST, STANDAR_COST) VALUES (@componente, @descripcion, @um, @pl, @current_cost, @standar_cost)";
                    command.Parameters.AddWithValue("@componente", componente);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@um", um);
                    command.Parameters.AddWithValue("@pl", pl);
                    command.Parameters.AddWithValue("@current_cost", current_cost);
                    command.Parameters.AddWithValue("@standar_cost", standar_cost);
                    MySqlDataReader dr = command.ExecuteReader();


                    connection.Close();
                }
                catch 
                {
                    MessageBox.Show("Error");
                }
                
            }

        }

       
    }
}
