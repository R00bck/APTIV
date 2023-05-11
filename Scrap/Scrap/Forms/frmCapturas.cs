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
        Librarys.componentes comp;
        private string componente;
        private string descripcion;
        private string um;
        private int pl;
        private double current_cost;
        private double standar_cost;

        public frmCapturas()
        {
            InitializeComponent();
            comp = new Librarys.componentes();
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
            InsertComponente();

        }
        private void InsertComponente()
        {
            if (ValidaCampos())
            {
                componente = txtComponente.Text;
                descripcion = txtDescripcion.Text;
                um = txtUM.Text;
                pl = Convert.ToInt32(txtPL.Text);
                current_cost = double.Parse(txtCurrentCost.Text);
                standar_cost = double.Parse(txtCurrentCost.Text);
            }
            else
            {
                MessageBox.Show("Llena los campos correspondientes");
            }
        }

        private bool ValidaCampos()
        {
            bool camposValidos = true;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        camposValidos = false;
                        // Realiza alguna acción, como mostrar un mensaje de error específico para cada campo
                    }
                }
                // Agrega más condiciones según los controles relevantes en tu caso, como ComboBox, etc.
            }

            return camposValidos;
        }
    }
}
