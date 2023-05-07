using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap.Forms
{
    public partial class frmQuery : Form
    {
        private readonly frmDetalle detail;
        Librarys.Scrap _scrap;
        private int _areId;
        private bool[] componente;
        private string[] valores;
        public frmQuery(frmDetalle form)
        {
            InitializeComponent();
            detail = form;
            _scrap = new Librarys.Scrap();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CreateFilters();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillAreas()
        {
            cbxArea.DataSource = _scrap.SelectAreas();
            cbxArea.DisplayMember = "AREA";
            cbxArea.ValueMember = "ID";
            cbxArea.SelectedIndex = -1;
        }
        private void FillLineas(int are_id, string sub)
        {
            cbxLineas.DataSource = _scrap.SelectLineas(are_id, sub);
            cbxLineas.DisplayMember = "LINEA";
            cbxLineas.ValueMember = "ID";
            cbxLineas.SelectedIndex = -1;
        }
        private void frmQuery_Load(object sender, EventArgs e)
        {
            FillAreas();
        }
        private void cbxArea_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string subquery = "";
                _areId = int.Parse(cbxArea.SelectedValue.ToString());

                if (_areId == 16)
                {
                    subquery = " OR MAQ_ID = 321";
                }

                FillLineas(_areId, subquery);
                cbxLineas.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Selecciona una Area.");
            }
        }
        private void CreateFilters()
        {
            componente = new bool[6];
            valores = new string[6];
            var txt = this.gbxBusqueda.Controls.OfType<TextBox>().ToArray();
            var cbx = this.gbxBusqueda.Controls.OfType<ComboBox>().ToArray();

            if(String.IsNullOrEmpty(cbxArea.Text) == false)
            {
                componente[0] = true;
                valores[0] = cbxArea.SelectedValue.ToString();
            }
            if(String.IsNullOrEmpty(cbxLineas.Text) == false)
            {
                componente[1] = true;
                valores[1] = cbxLineas.SelectedValue.ToString();
            }
            if (String.IsNullOrEmpty(txtOperador.Text) == false)
            {
                componente[2] = true;
                valores[2] = txtOperador.Text.Trim();
            }
            if (dtpDesde.Checked == true)
            {
                componente[3] = true;
                valores[3] = dtpDesde.Value.ToString("yyyy-MM-dd");
            }
            if (dtpHasta.Checked == true)
            {
                componente[4] = true;
                valores[4] = dtpHasta.Value.ToString("yyyy-MM-dd");
            }
            if(String.IsNullOrEmpty(cbxTurno.Text) == false)
            {
                componente[5] = true;
                valores[5] = cbxTurno.Text;
            }
            if(valores.All(item => item == null))
            {
                
            }
            else
            {
                //crear filtro
                detail.FillDatagridFilter(componente, valores);
            }
        }
    }
}
