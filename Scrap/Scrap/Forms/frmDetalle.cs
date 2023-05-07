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
    public partial class frmDetalle : Form
    {
        private int key;
        Librarys.Scrap _scrap;
        public frmDetalle()
        {
            InitializeComponent();
            _scrap = new Librarys.Scrap();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            frmQuery qry = new frmQuery(this);
            qry.ShowDialog();
        }
        public void FillDatagridFilter(bool[] comp, string[] values)
        {
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvData.DataSource = _scrap.ValuesFilter(comp, values);

        }

        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            key = int.Parse(dgvData.SelectedRows[0].Cells[0].Value.ToString());
            FillCompScrsap(key);

        }
        private void FillCompScrsap(int id)
        {
            frmDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            frmDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            frmDetails.DataSource = _scrap.SelectComponentes(id);
        }
    }
}
