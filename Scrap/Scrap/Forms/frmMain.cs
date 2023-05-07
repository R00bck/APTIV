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
    public partial class frmMain : Form
    {
        private int userId;
        public int UserId { get => userId; set => userId = value; }
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmSearch search = new frmSearch();
            search.Show();
            search.MdiParent = this;
        }
        */
        /*
        private void detalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmDetalle detalle = new frmDetalle();
            detalle.Show();
            detalle.MdiParent = this;
        }
        */

        private void TSMICapturar_Click(object sender, EventArgs e)
        {
            Forms.frmCoax coax = new frmCoax();
            coax.IdUser = userId;
            coax.Show();
           // coax.MdiParent = this;
           // this.WindowState = FormWindowState.Normal;
        }

       
    }
}
