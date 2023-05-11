using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Scrap.Forms
{
    public partial class frmMain : Form
    {
        private int userId;
        public int UserId { get => userId; set => userId = value; }
        Librarys.Estacion est;

        public frmMain()
        {
            InitializeComponent();
            est = new Librarys.Estacion();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            //string area, int estacion, string lado, int maq_id, int user, int neg
            Forms.frmCoax coax = new frmCoax(est.Area, est.Num_Est, est.Lado, est.Maq_id, userId, est.Negocio);
            //coax.IdUser = userId;
            this.Hide();
            coax.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string hostname = Dns.GetHostName();
            hostname = "DL9J6KJ02";
            //this.tbcPlanes.SizeMode = TabSizeMode.FillToRight;
            if (est.Linea(hostname) == true)
            {
                iconMenuItem1.Enabled = true;
            }
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            Forms.frmCapturas cap = new frmCapturas();
            //coax.IdUser = userId;
            this.Hide();
            cap.Show();
        }
    }
}
