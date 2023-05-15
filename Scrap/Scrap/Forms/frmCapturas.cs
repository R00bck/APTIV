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
        private decimal current_cost;
        private decimal standar_cost;

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
                current_cost = decimal.Parse(txtCurrentCost.Text);
                standar_cost = decimal.Parse(txtCurrentCost.Text);

                if (comp.InsertComponentes(componente, descripcion, um, pl, current_cost, standar_cost) > 0)
                    lblMensaje.Text = "Registro Almacenado!";
            }
            else
            {
                MessageBox.Show("Llena los campos correspondientes");
            }
        }

        private bool ValidaCampos()
        {
            bool camposValidos = true;

            List<Control> allControls = GetAllControls(this);

            foreach (Control control in allControls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Name == "txtBuscar")
                    {
                        continue; // Omitir este control y pasar al siguiente
                    }

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
        private List<Control> GetAllControls(Control container)
        {
            List<Control> controls = new List<Control>();

            foreach (Control control in container.Controls)
            {
                controls.Add(control);
                controls.AddRange(GetAllControls(control));
            }

            return controls;
        }
    }
}
