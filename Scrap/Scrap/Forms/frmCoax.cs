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
        private string _search;
        private bool _plado;
        #endregion

        public frmCoax(string area, int estacion, string lado, int maq_id, int user, int neg)
        {
            InitializeComponent();
            _scrap = new Librarys.Scrap();
            _area = area;
            _estacion = estacion;
            _lado = lado;
            _maq_id = maq_id;
            _idUser = user;
            _negocio = neg;
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
            cbxDefecto.Enabled = true;
            _idProceso = int.Parse(cbxProceso.SelectedValue.ToString());
            FillDefectos(_idProceso, _negocio);

            fillDataGrid(_search, Query(), codigo(_idProceso));

            Mensaje(0, "Selecciona el defecto.");
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
        private string Query()
        {
            if (_plado == true)
                return "AND LADO=1";
            else
                return  "";
        }
        private void cbxEstaciones_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                //_idSub = int.Parse(cbxEstaciones.SelectedValue.ToString());
                cbxDefecto.Enabled = true;
            }
            catch
            {
                Mensaje(1, "Selecciona un proceso.");
            }
        }
        private void FillTextBox(int maq_id)
        {
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

           /* foreach (DataRow row in _scrap.SelectLeadsLinea(maq_id).Rows)
            {
                MyCollection.Add(row[0].ToString());
            }*/

            txtLead.AutoCompleteCustomSource = MyCollection;
        }
        private void FillComponentes()
        {
            /*cbxComponentes.DisplayMember = "COMPONENTE";
            cbxComponentes.ValueMember = "ID";
            cbxComponentes.SelectedIndex = -1;
            cbxComponentes.DataSource = _scrap.SelectComponentes();
            cbxComponentes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxComponentes.AutoCompleteSource = AutoCompleteSource.ListItems;*/

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if(ckxAtrazo.Checked == true)
            {
                _shift = cbxTurno.Text;
            }
            else
            {
                _shift = _scrap.Shift();
            }
            //MessageBox.Show(shift);
            if(rdbComponente.Checked == true || rdbSetup.Checked == true)
            {
                _idComponente = int.Parse(cbxComponentes.SelectedValue.ToString());
                InsertaComponente(_idComponente);
            }
            else
            {
                InsertaScrap();
            }*/
        }
        private void InsertaScrap()
        {
            try
            {
                int cantidad = 0;
                if (_scrap.ValidateText(txtCantidad.Text))
                {
                    cantidad = int.Parse(txtCantidad.Text.Trim());
                    Int64 cons = InsertScrap(cantidad);

                    int idComp = 0;
                    float cant = 0;

                    if (cons > 0)
                    {
                        foreach (DataGridViewRow row in dgvComponentes.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[9].Value) == true)
                            {
                                //MessageBox.Show(row.Cells[0].Value.ToString() + " - " + row.Cells[3].Value.ToString());
                                //idComp == 1828 || idComp == 4621 || idComp == 2070 || idComp == 4025 || 
                                idComp = int.Parse(row.Cells[0].Value.ToString());
                                if (idComp == 5037)
                                {
                                    if (float.Parse(row.Cells[4].Value.ToString()) > 1.5)
                                    {
                                        cant = 0;
                                    }
                                }
                                else
                                {
                                    cant = float.Parse(row.Cells[4].Value.ToString());
                                }
                                _scrap.InsertScrapComponentes(cons, idComp, cant);
                            }
                        }
                        txtCantidad.Clear();
                        dgvComponentes.DataSource = null;
                        dgvComponentes.Rows.Clear();
                    }
                    else
                    {
                        Mensaje(0, "Error al insertar los registros.");
                    }
                }
                else
                    Mensaje(1, "Ingrese la cantidad a capturar.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void InsertaComponente(int comp_id)
        {
            float cantidad = 0;
            if (_scrap.ValidateText(txtCantidad.Text))
            {
                cantidad = float.Parse(txtCantidad.Text.Trim());
                Int64 cons = InsertScrap(1);

                if (cons > 0)
                {
                    _scrap.InsertScrapComponentes(cons, comp_id, cantidad);
                    txtCantidad.Clear();
                }
                else
                {
                    Mensaje(0, "Error al insertar los registros.");
                }
            }
            else
                Mensaje(1, "Ingrese la cantidad a capturar.");
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
            /*if(ckxAtrazo.Checked == true)
            {
                _date = dtpFecha.Value.ToString("yyyy-MM-dd"); 
                if(cbxTurno.Text == "A")
                {
                    _date = _date + " 13:00:00";
                }
                else
                {
                    _date = _date + " 20:00:00";
                }
            }
            else
            {
                _date = _scrap.SelectFechaCompleta();
            }
            

            if(rdbComponente.Checked == true)
            {
                idScrap = _scrap.InsertDefecto("COMP", 0, 0, 0, 0, _maq_id, cantidad, _idUser, _shift, "N/A", 0, "N/A", _date);
                Mensaje(0, "Componentes capturados correctamente.");
            }
            else if(rdbSetup.Checked == true)
            {
                idScrap = _scrap.InsertDefecto("setup", 0, 0, 0, 0, _maq_id, cantidad, _idUser, _shift, "N/A", 0, "N/A", _date);
                Mensaje(0, "Componentes capturados correctamente.");
            }
            else
            {
                _defecto = _scrap.GetId(cbxDefecto.Text);
                _config = cbxConfig.Text;
                if (qtyLeads == 1)
                {
                    idScrap = _scrap.InsertDefecto("N/A", _scrap.Num_id, _scrap.Lea_id, _idPro, _idSub, _maq_id, cantidad, _idUser, _shift, _defecto, 
                                                   secuencia, _config, _date);
                    Mensaje(0, "Componentes capturados correctamente.");
                }
                else
                {
                    idScrap = _scrap.InsertDefecto(key, _scrap.Num_id, _scrap.Lea_id, _idPro, _idSub, _maq_id, cantidad, _idUser, _shift, _defecto, 
                                                   secuencia, _config, _date);
                    Mensaje(0, "Componentes capturados correctamente.");
                }
            }*/


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
                    }
                }
                else
                {
                    if (_scrap.BuscaLead(_search, _maq_id))
                    {
                        _plado = true;
                        cbxProceso.Enabled = true;
                        lblLado.Visible = true;
                        cbxLado.Visible = true;
                        Mensaje(0, "Seleccione un Lado y proceso");
                        FillProcesos();
                    }
                    else
                    {
                        MessageBox.Show("El lead no existe o no pertenece a esta linea");
                    }
                }


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
            frmMain main= new frmMain();
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
            txtCantidad.Enabled = true;
        }
    }
}
