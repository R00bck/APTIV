using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Scrap.Forms
{
    public partial class frmCoax : Form
    {
 
        Librarys.Scrap _scrap;

        #region private variables
 
        private int _maq_id;
        private int _idUser;
        private string _area;
        private int _estacion;
        private string _lado;
        private int _negocio;
        private int _idProceso;
        private string _defecto;
        private string _search;
        private bool _plado;
        private string _ladoLead;
        private int _areId;
        private string _shift;
        private decimal _costo;
        private int _cantidad;
        #endregion

        public frmCoax(string area, int estacion, string lado, int maq_id, int user, int neg, int are_id)
        {
            InitializeComponent();
            _scrap = new Librarys.Scrap();
            _area = area;
            _estacion = estacion;
            _lado = lado;
            _maq_id = maq_id;
            _idUser = user;
            _negocio = neg;
            _areId = are_id;
        }

        #region DropDownList

        private void FillProcesos()
        {
            string query = "";

            if (_plado == true)
                query = " (PROC_ID = 3 OR PROC_ID = 4)";
            else
                query = " PROC_ID = 12";

            cbxProceso.DataSource = _scrap.SelectProcesos(query);
            
            cbxProceso.DisplayMember = "PROCESO";
            cbxProceso.ValueMember = "ID";
            cbxProceso.SelectedIndex = -1;
        }
        private void FillDefectos(int idPro, int negocio)
        {
            cbxDefecto.DataSource = _scrap.SelectDefectos(idPro, negocio);
            cbxDefecto.DisplayMember = "DEFECTO";
            cbxDefecto.ValueMember = "ID";
            cbxDefecto.SelectedIndex = -1;
        }
        #endregion
        private void frmCoax_Load(object sender, EventArgs e)
        {
            FillLabels();
        }
        private void FillLabels()
        {
            lblArea.Text = _area;
            lblLine.Text = _lado + "-" + _estacion;
        }

        private void Mensaje(int tipo, string mensaje)
        {
            if(tipo == 0)
            {
                lblMensajes.BackColor = Color.GreenYellow;
                lblMensajes.ForeColor = Color.Black;
            }
            else if(tipo == 1)
            {
                lblMensajes.BackColor = Color.Red;
                lblMensajes.ForeColor = Color.White;
            }
            lblMensajes.Text = mensaje;
        }
        private void cbxNp_DropDownClosed(object sender, EventArgs e)
        {
            Mensaje(0, "Seleccione la estacion.");

        }
        private void cbxProceso_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                cbxDefecto.Enabled = true;
                _idProceso = int.Parse(cbxProceso.SelectedValue.ToString());
                FillDefectos(_idProceso, _negocio);
                if (_idProceso == 4)
                {
                    lblLado.Visible = true;
                    cbxLado.Visible = true;
                    Mensaje(0, "Seleccione Lado");
                }
                else
                {
                    lblLado.Visible = false;
                    cbxLado.Visible = false;
                    fillDataGrid(_search, Query(""), codigo(_idProceso));

                    Mensaje(0, "Selecciona el defecto.");
                }

            }
            catch
            {
                Mensaje(1, "Selecciona un proceso.");
            }
        }
        private string codigo(int idpro)
        {
            string cod = "";
            switch (idpro)
            {
                case 3:
                    cod = "C";
                    break;
                case 4:
                    cod = "P";
                    break;
                case 12:
                    cod = "T";
                    break;
            }

            return cod;
        }
        private string Query(string lado)
        {
            if (_plado == true && _idProceso == 4)
                return "AND LADO=" + lado.Substring(4).Trim();
            else
                return  "";
        }
        private void InsertaComponentes(long idDefectos, int numDef)
        {
            try
            {
                int idComp = 0;
                decimal cant = 0m;
                long id;
                bool res = false;
                foreach (DataGridViewRow row in dgvComponentes.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {

                        idComp = int.Parse(row.Cells[1].Value.ToString());
                        cant = decimal.Parse(ConvierteFormato(row.Cells[6].Value.ToString())) * numDef;

                        res = _scrap.InsertComponentes(idDefectos, idComp, cant, out id);

                    }

                }

                if(res == true)
                {
                    txtCantidad.Clear();
                    dgvComponentes.DataSource = null;
                    dgvComponentes.Rows.Clear();
                    Mensaje(0, "Registrons insertados correctamente");
                }

                else
                {
                    Mensaje(1, "Error al insertar los registros");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cbxDefecto_DropDownClosed(object sender, EventArgs e)
        {
            Mensaje(0, "Digite la cantidad.");
            txtCantidad.Enabled = true;
            txtCantidad.Focus();
        }
        private Int64 InsertScrap(int cantidad)
        {
            Int64 idScrap = 0;
            _shift = "A";
            _costo = Sumatoria(cantidad);

            if(_plado == true)
            {
                idScrap = _scrap.InsertDefecto(_search, _idProceso, _defecto, _lado, codigo(_idProceso), cantidad, _maq_id, _areId, _idUser, _shift, _negocio,_costo);
                if(idScrap > 0)
                {
                    InsertaComponentes(idScrap, cantidad);
                }
                else
                {
                    Mensaje(0, "Error al insertar los registros.");
                }
                //Mensaje(0, "Componentes capturados correctamente.");
            }
            else
            {
                idScrap = _scrap.InsertDefecto(_search, _idProceso, _defecto, "N/A", codigo(_idProceso), cantidad, _maq_id, _areId, _idUser, _shift, _negocio, _costo);
                if (idScrap > 0)
                {
                    InsertaComponentes(idScrap, cantidad);
                }
                else
                {
                    Mensaje(0, "Error al insertar los registros.");
                }
            }

            return idScrap;
        }
        private void txtLead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                _search = txtLead.Text.Trim();
                if (_scrap.EmpiezaConNumeros(_search))
                {
                    if (_scrap.BuscaNumparte(_search))
                    {
                        cbxProceso.Enabled = true;
                        lblNp.Text = _search;
                        Mensaje(0, "Seleccione un proceso");
                        FillProcesos();
                        _plado = false;
                        lblLado.Visible = false;
                        cbxLado.Visible = false;
                        ClearDefectos();
                    }
                }
                else
                {
                    if (_scrap.BuscaLead(_search, _maq_id))
                    {
                        _plado = true;
                        cbxProceso.Enabled = true;
                        FillProcesos();
                        ClearDefectos();
                        Mensaje(0, "Seleccione un proceso");
                    }
                    else
                    {
                        MessageBox.Show("El lead no existe o no pertenece a esta linea");
                    }
                }


            }
        }
        private void ClearDefectos()
        {
            int count = cbxDefecto.Items.Count;
            if (count > 0)
            {
                cbxDefecto.DataSource = null;
                cbxDefecto.Items.Clear();
            }

        }
       /*
        private void Clear(string tipo, bool enab)
        {
            if(tipo == "componente")
            {
                cbxProceso.SelectedIndex = -1;
                txtLead.Clear();
                txtLead.Enabled = false;
                cbxEstaciones.SelectedIndex = -1;
                cbxEstaciones.Enabled = false;
                cbxDefecto.SelectedIndex = -1;
                cbxDefecto.Enabled = false;
                txtCantidad.Clear();
                cbxNp.SelectedIndex = -1;
                cbxNp.Visible = false;
                lblNp.Visible = false;
                dgvComponentes.DataSource = null;
                dgvComponentes.Rows.Clear();
            }
            else if(tipo == "lead" && enab == true)
            {
                txtLead.Enabled = true;
                txtCantidad.Clear();
                txtCantidad.Enabled = false;
            }
            else if(tipo == "proceso")
            {

            }
        }
        }*/

        private void frmCoax_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain main= new frmMain(_idUser);
            main.Show();
        }
        private void fillDataGrid(string key, string lado, string codpro)
        {
            //int secuenc
            dgvComponentes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCheckBoxColumn columnaCheckBox = new DataGridViewCheckBoxColumn();
            columnaCheckBox.HeaderText = "CHECK";
            columnaCheckBox.Name = "chkColumna";

            // Agregar la columna CheckBox al DataGridView
            if (!dgvComponentes.Columns.Contains("chkColumna"))
                dgvComponentes.Columns.Add(columnaCheckBox);


            dgvComponentes.DataSource = _scrap.SearchListComponents(key, lado, codpro);
            if(dgvComponentes.Rows.Count > 0)
            {
                int checkBoxColumnIndex = dgvComponentes.Columns["chkColumna"].Index;

                foreach (DataGridViewRow row in dgvComponentes.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells[checkBoxColumnIndex] as DataGridViewCheckBoxCell;
                    checkBoxCell.Value = true;
                    // Ajustar el tamaño de la celda que contiene el CheckBox
                    //dgvComponentes.Columns[checkBoxColumnIndex].DefaultCellStyle.Padding = new Padding(10); // Ajustar el padding para aumentar el tamaño
                    //dgvComponentes.Columns[checkBoxColumnIndex].MinimumWidth = 50;
                }
                foreach (DataGridViewColumn column in dgvComponentes.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            this.dgvComponentes.Columns[1].Visible = false;

        }

        private void cbxDefecto_DropDownClosed_1(object sender, EventArgs e)
        {
            try
            {
                ComboBox cbxDefecto = (ComboBox)sender;
                _defecto = _scrap.GetId(cbxDefecto.GetItemText(cbxDefecto.SelectedItem));
                txtCantidad.Enabled = true;
            }
            catch
            {
                Mensaje(1, "Seleccione un defecto.");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (_scrap.ValidateText(txtCantidad.Text))
            {
                Mensaje(1, "Ingresa la cantidad de piezas.");
            }
            else
            {
                _cantidad = int.Parse(txtCantidad.Text);
                InsertScrap(_cantidad);
            }

        }

        private decimal Sumatoria(int captura)
        {
            decimal cantidad = 0;
            decimal total = 0m;
            if(dgvComponentes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvComponentes.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        cantidad = decimal.Parse(ConvierteFormato(row.Cells[9].Value.ToString()));
                        total = total + (cantidad * captura);
                    }
                }
            }

            return total;
        }

        private string ConvierteFormato(string valor) 
        {
            decimal valorDecimal;

            if (decimal.TryParse(valor, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out valorDecimal))
                // El valor tiene un formato científico
                return valorDecimal.ToString();
            else
                return valor;
        }

        private void CheckValues()
        {
            if (dgvComponentes.Rows.Count > 0)
            {
                int checkBoxColumnIndex = dgvComponentes.Columns["chkColumna"].Index;

                foreach (DataGridViewRow row in dgvComponentes.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells[checkBoxColumnIndex] as DataGridViewCheckBoxCell;
                    checkBoxCell.Value = true;
                }
            }
        }

        private void cbxDefecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void cbxLado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _ladoLead = cbxLado.Text;
                fillDataGrid(_search, Query(_ladoLead), codigo(_idProceso));

            }
            catch
            {
                Mensaje(0, "Seleccione un defecto.");
            }
        }

        private void cbxProceso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
