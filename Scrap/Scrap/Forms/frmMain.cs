﻿using System;
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
        private string[] proceso = { "CORTE", "PRENSADO", "ENSAMBLE" };
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
            Forms.frmCapturas coax = new frmCapturas();
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
    }
}
