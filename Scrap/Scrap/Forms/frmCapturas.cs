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
        private string searchcomp;

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
            dgvComponentes.ClearSelection();
        }

        private DataTable GetComponentesList()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT ID, COMPONENTE, DESCRIPTION, UM, PL, CURRENT_COST FROM TBLCOMPONENTES 
                           ORDER BY ID DESC";

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

        // *-*-*-*-*-*- BOTON AGREGAR *-*-*-*-*-*-
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertComponentes();

        }
        private void InsertComponentes()
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
                {
                    lblMensaje.Text = "";
                    lblMensaje.Text = "Registro Almacenado!";
                    lblMensaje.BackColor = Color.Green;
                    dgvComponentes.DataSource = GetComponentesList();
                    MessageBox.Show("Componente Insertado Correctamente", "OK!", MessageBoxButtons.OK);
                    Cleartxt();
                }
            }
            else
            {
                lblMensaje.BackColor = Color.Red;
                lblMensaje.Text = "Error!";
                MessageBox.Show("Llenar los campos correspondientes");
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
                    // *-*-*-*-*-*-*-*-*-*-*- P E N D I E N T E   JC *-*-*-*-*-*-*-*-*-*-*-*-

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


        // *-*-*-*-*-*- BOTON ACTUALIZAR *-*-*-*-*-*-
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateComponentes();
        }

        private void UpdateComponentes()
        {
            if (ValidaCampos())
            {
                componente = txtComponente.Text;
                descripcion = txtDescripcion.Text;
                um = txtUM.Text;
                pl = Convert.ToInt32(txtPL.Text);
                current_cost = decimal.Parse(txtCurrentCost.Text);
                standar_cost = decimal.Parse(txtCurrentCost.Text);

                if (comp.UpdateComponentes(componente, descripcion, um, pl, current_cost, standar_cost) > 0)

                lblMensaje.Text = "";
                lblMensaje.Text = "Registro Actualizado!";
                lblMensaje.BackColor = Color.Green;
                Cleartxt();
                // Refresh a DataGried para mostrar componente actualizado
                dgvComponentes.DataSource = GetComponentesList();

            }
            else
            {
                lblMensaje.BackColor = Color.Red;
                lblMensaje.Text = "Error";
                MessageBox.Show("Selecciona un Componente");
            }
        }

        // *-*-*-*-*-*- BOTON ELIMINAR *-*-*-*-*-*-
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeleteComponentes();
        }

        private void DeleteComponentes()
        {
            if (ValidaCampos()) 
            {
                DialogResult dialogResult = MessageBox.Show("Eliminar Registro", "Deseas eliminar el Componente?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    componente = txtComponente.Text;
                    if (comp.DeleteComponentes(componente) > 0)

                    lblMensaje.Text = "";
                    lblMensaje.Text = "Registro Eliminado!";
                    lblMensaje.BackColor = Color.Green;
                    Cleartxt();

                    // Refresh a DataGried para mostrar componente actualizado
                    dgvComponentes.DataSource = GetComponentesList();

                }
            }
            else
            {
                lblMensaje.BackColor = Color.Red;
                lblMensaje.Text = "Error";
                MessageBox.Show("Selecciona un Componente");
            }
        }

        // Carga de datos a Textboxs Datagried
        private void dgvComponentes_MouseClick(object sender, MouseEventArgs e)
        {
            txtComponente.Text= dgvComponentes.SelectedRows[0].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvComponentes.SelectedRows[0].Cells[2].Value.ToString();
            txtUM.Text = dgvComponentes.SelectedRows[0].Cells[3].Value.ToString();
            txtPL.Text = dgvComponentes.SelectedRows[0].Cells[4].Value.ToString();
            txtCurrentCost.Text = dgvComponentes.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void Cleartxt()
        {
            // Limpieza de Textbox vacios
            txtComponente.Text = "";
            txtDescripcion.Text = "";
            txtUM.Text = "";
            txtPL.Text = "";
            txtCurrentCost.Text = "";
            dgvComponentes.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchComponentes();
        }

        private void SearchComponentes()
        {
            if (ValidaCampos())
            {
                searchcomp = txtBuscar.Text;
                if (comp.SearchComponentes(searchcomp) > 0)
                // Refresh a DataGried para mostrar componente actualizado
                dgvComponentes.DataSource = GetComponentesList();
            }
            else
            {
                lblMensaje.BackColor = Color.Red;
                lblMensaje.Text = "Error";
                MessageBox.Show("Selecciona un Componente");
            }
        }

    }
}
