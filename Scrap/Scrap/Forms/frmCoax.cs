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
        Librarys.clsResize _form_resize;
        Librarys.Scrap _scrap;
        List<string>[] listLeads;
        #region private variables
        private int _areId;
        private int _maq_id;
        private int _count;
        private int _idPro;
        private int _idSub;
        private string key;
        private int qtyLeads;
        private int secuencia;
        private string _defecto;
        private int _idComponente;
        private string _shift;
        private int _idUser;
        private bool enable;
        private string _config;
        private string _date;
        private int _num_id;
        #endregion
        public int IdUser { get => _idUser; set => _idUser = value; }
        public frmCoax()
        {
            InitializeComponent();
            _scrap = new Librarys.Scrap();
            //_form_resize = new Librarys.clsResize(this);
           // this.Load += _Load;
            //this.Resize += _Resize;
        }
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }
        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        #region DropDownList
        private void FillAreas()
        {
           /* cbxArea.DataSource = _scrap.SelectAreas();
            cbxArea.DisplayMember = "AREA";
            cbxArea.ValueMember = "ID";
            cbxArea.SelectedIndex = -1;*/
        }
        private void FillLineas(int are_id, string sub)
        {
           /* cbxLinea.DataSource = _scrap.SelectLineas(are_id, sub);
            cbxLinea.DisplayMember = "LINEA";
            cbxLinea.ValueMember = "ID";
            cbxLinea.SelectedIndex = -1;*/
        }
        private void FillProcesos(int maquina)
        {

            cbxProceso.DataSource = _scrap.SelectProcesos();
            
            cbxProceso.DisplayMember = "PROCESO";
            cbxProceso.ValueMember = "ID";
            cbxProceso.SelectedIndex = -1;
        }
        private void FillSubProcesos(int id, string lea_id)
        {
            /*cbxEstaciones.DataSource = _scrap.SelectSubprocesos(id, lea_id);
            cbxEstaciones.DisplayMember = "SUBPROCESO";
            cbxEstaciones.ValueMember = "ID";
            cbxEstaciones.SelectedIndex = -1;*/

            cbxDefecto.DataSource = null;
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
            FillAreas();
        }
        private void cbxArea_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string subquery = "";
                //_areId = int.Parse(cbxArea.SelectedValue.ToString());

                if(_areId == 16)
                {
                    subquery = " OR MAQ_ID = 321";
                }

                FillLineas(_areId, subquery);
                //cbxLinea.Enabled = true;
            }
            catch
            {
                Mensaje(1, "Selecciona una Area.");
            }
            
        }
        private void cbxLinea_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
               // _maq_id = int.Parse(cbxLinea.SelectedValue.ToString());
                //FillProcesos(_maq_id);
                FillTextBox(_maq_id);
            }
            catch
            {
                MessageBox.Show("Selecciona una estacion");
            }
        }
        private void Mensaje(int tipo, string mensaje)
        {
            if(tipo == 0)
            {
                lblMensajes.BackColor = Color.Blue;
                lblMensajes.ForeColor = Color.White;
            }
            else if(tipo == 1)
            {
                lblMensajes.BackColor = Color.Red;
                lblMensajes.ForeColor = Color.White;
            }
            lblMensajes.Text = mensaje;
        }
        private void rdbLead_CheckedChanged(object sender, EventArgs e)
        {
            //txtLead.Enabled = true;
            /*if(rdbLead.Checked == true)
            {
                txtLead.Enabled = true;
                txtLead.Focus();
                //cbxProceso.Enabled = true;
                lblComponente.Visible = false;
                cbxComponentes.Visible = false;
            }*/
            
        }
        private void cbxNp_DropDownClosed(object sender, EventArgs e)
        {
            Mensaje(0, "Seleccione la estacion.");
            string search = txtLead.Text.Trim();

            if (_scrap.BuscaLeads(_maq_id, search) > 0)
            {
                //cargar procesos
                //List<string>[] listLeads = new List<string>[2];
                listLeads = _scrap.NumLeads(_scrap.Num_id);

                qtyLeads = listLeads[0].Count();
                //cbxEstaciones.Enabled = true;
                cbxProceso.Enabled = true;
                if (qtyLeads == 1)
                {
                    key = _scrap.Lea_id.ToString();
                    FillProcesos(_maq_id);

                    //FillSubProcesos(_idPro, _scrap.Lea_id.ToString());
                }
                else
                {
                    if (_idPro == 1 || _idPro == 2 || _idPro == 3 || _idPro == 9 || _idPro == 10 || _idPro == 23
                        || _idPro == 24 || _idPro == 25 || _idPro == 26)
                    {
                        key = _scrap.Lea_id.ToString();
                        FillProcesos(_maq_id);
                        //FillSubProcesos(_idPro, key);
                    }
                    else
                    {
                        //listLeads = new List<string>[2];
                        listLeads = _scrap.NumLeads(_scrap.Num_id);

                        key = _scrap.RegresaLlave(listLeads, qtyLeads);
                        FillProcesos(_maq_id);
                        //FillSubProcesos(_idPro, key);
                    }
                }
            }
        }
        private void cbxProceso_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                _idPro = int.Parse(cbxProceso.SelectedValue.ToString());
                txtLead.Enabled = true;
                if (_idPro == 4 || _idPro == 5 || _idPro == 3)
                {
                    key = _scrap.Lea_id.ToString();
                    FillSubProcesos(_idPro, key);
                }
                else
                {
                    key = _scrap.RegresaLlave(listLeads, qtyLeads);
                    FillSubProcesos(_idPro, key);
                }
                //cbxEstaciones.Enabled = true;
            }
            catch
            {
                Mensaje(0, "Seleccione un proceso");
            }
        }
        private void cbxEstaciones_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                //_idSub = int.Parse(cbxEstaciones.SelectedValue.ToString());
                cbxDefecto.Enabled = true;
                Mensaje(0, "Seleccione el defecto.");
                FillDefectos(_idPro, 1);
                fillDataGrid(_idSub);
            }
            catch
            {
                Mensaje(1, "Selecciona un proceso.");
            }
        }
        private void fillDataGrid(int idSub)
        {
            //int secuenc
            dgvComponentes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if(qtyLeads == 1)
            {
                secuencia = _scrap.Secuencia(_scrap.Lea_id.ToString(), idSub);
                dgvComponentes.DataSource = _scrap.SelectComponentes(idSub, _scrap.Lea_id.ToString(), secuencia);
                this.dgvComponentes.Columns[0].Visible = false;
            }
            else
            {
                if(_idPro >= 7 && _idPro < 22)
                {
                    secuencia = _scrap.Secuencia(key, idSub);
                    string qry = " AND CE.ORDEN > 0 AND CE.ORDEN <=" + secuencia;
                    dgvComponentes.DataSource = _scrap.SelectComponentesNp(_num_id, qry);
                    //dgvComponentes.DataSource = _scrap.SelectComponentesNp(idSub, key, secuencia);
                }
                else if((_idPro > 7) || (_idPro >= 22 && _idPro <= 24))
                {
                    secuencia = _scrap.Secuencia(key, idSub);
                    string qry = " AND CE.ORDEN > 0 AND CE.ORDEN <=" + secuencia;
                    dgvComponentes.DataSource = _scrap.SelectComponentesNp(_num_id, qry);
                    //dgvComponentes.DataSource = _scrap.SelectComponentesNp(idSub, key, secuencia);
                }
                else
                {
                    secuencia = _scrap.Secuencia(_scrap.Lea_id.ToString(), idSub);
                    dgvComponentes.DataSource = _scrap.SelectComponentes(idSub, _scrap.Lea_id.ToString(), secuencia);
                }
                this.dgvComponentes.Columns[0].Visible = false;
            }
        }
        private void FillTextBox(int maq_id)
        {
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

            foreach (DataRow row in _scrap.SelectLeadsLinea(maq_id).Rows)
            {
                MyCollection.Add(row[0].ToString());
            }

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
                /*string search = "";
                search = txtLead.Text.Trim();

                if (rdbLead.Checked == true)
                {
                    //txtLead.Enabled = true;
                    List<string>[] list = new List<string>[2];
                    list = _scrap.LeadsNp(search, _maq_id);
                    _count = list[0].Count();

                    if (_count > 0)
                    {

                        if (_count > 1)
                        {
                            lblNp.Visible = true;
                            cbxNp.Visible = true;

                            if(rdbLead.Checked == true && _areId == 16)
                            {
                                cbxConfig.Visible = true;
                                lblConfig.Visible = true;
                            }

                            //cbxNp.Items.Add(list[1]);
                            for (int i = 0; i < _count; i++)
                            {
                                cbxNp.Items.Add(list[1][i]);
                            }
                            //cbxNp.DisplayMember = list[1].ToString();
                            //cbxNp.ValueMember = list[0].ToString();

                            cbxNp.SelectedIndex = -1;

                            Mensaje(1, "Selecciona el numero de parte que se esta trabajando");

                        }
                        else
                        {
                            
                            if (_scrap.BuscaLeads(_maq_id, search) > 0)
                            {
                                _num_id = _scrap.Num_id;
                                listLeads = new List<string>[2];
                                listLeads = _scrap.NumLeads(_scrap.Num_id);

                                qtyLeads = listLeads[0].Count();
                                //cbxEstaciones.Enabled = true;
                                cbxProceso.Enabled = true;

                                if (rdbLead.Checked == true && _areId == 16)
                                {
                                    cbxConfig.Visible = true;
                                    lblConfig.Visible = true;
                                }


                                if (qtyLeads == 1)
                                {
                                    //FillSubProcesos(_idPro, _scrap.Lea_id.ToString());
                                    key = _scrap.Lea_id.ToString();
                                    FillProcesos(_maq_id);
                                }
                                else
                                {
                                    FillProcesos(_maq_id);
                                    if(_idPro == 1 || _idPro == 2 || _idPro == 3 || _idPro == 9 || _idPro == 10 || _idPro == 23 
                                        || _idPro == 24 || _idPro == 25 || _idPro == 26)
                                    {
                                        key = _scrap.Lea_id.ToString();
                                        //FillSubProcesos(_idPro, key);
                                    }
                                    else
                                    {
                                        key = _scrap.RegresaLlave(listLeads, qtyLeads);
                                        //FillSubProcesos(_idPro, key);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Mensaje(1, "Este lead no es valido");
                    }
                }
                else
                {

                }
            }*/
        }
        /*private void rdbComponente_CheckedChanged(object sender, EventArgs e)
        {
           if(rdbComponente.Checked == true)
            {
                lblComponente.Visible = true;
                cbxComponentes.Visible = true;
                cbxProceso.Enabled = false;
                FillComponentes();
                enable = true;
                Clear("componente", enable);
                lblConfig.Visible = false;
                cbxConfig.Visible = true;
                cbxConfig.SelectedIndex = -1;
            }
        }*/
       /* private void cbxComponentes_DropDownClosed(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
        }
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
        private void rdbAtrazo_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ckxAtrazo_CheckedChanged(object sender, EventArgs e)
        {
            /*if (ckxAtrazo.Checked == true)
            {
                cbxTurno.Enabled = true;
                dtpFecha.Enabled = true;
            }
            else
            {
                cbxTurno.Enabled = false;
                dtpFecha.Enabled = true;
            }*/
        }

        private void rdbSetup_CheckedChanged(object sender, EventArgs e)
        {
            /*if (rdbSetup.Checked == true)
            {
                lblComponente.Visible = true;
                cbxComponentes.Visible = true;
                cbxProceso.Enabled = false;
                FillComponentes();
                enable = true;
                Clear("componente", enable);
                lblConfig.Visible = false;
                cbxConfig.Visible = true;
                cbxConfig.SelectedIndex = -1;
            }*/
        }
    }
}
