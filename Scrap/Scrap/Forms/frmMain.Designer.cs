namespace Scrap.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.TSMICapturar = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.cargarComponentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gdpnlMain = new Scrap.Librarys.GradientPanel();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Silver;
            this.msMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2,
            this.iconMenuItem3});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(156, 875);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMICapturar});
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(143, 72);
            this.iconMenuItem1.Text = "Manufactura";
            this.iconMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TSMICapturar
            // 
            this.TSMICapturar.Name = "TSMICapturar";
            this.TSMICapturar.Size = new System.Drawing.Size(224, 26);
            this.TSMICapturar.Text = "Capturar";
            this.TSMICapturar.Click += new System.EventHandler(this.TSMICapturar_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(143, 72);
            this.iconMenuItem2.Text = "Ingenieria";
            this.iconMenuItem2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarComponentesToolStripMenuItem});
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(143, 72);
            this.iconMenuItem3.Text = "Planeacion";
            this.iconMenuItem3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cargarComponentesToolStripMenuItem
            // 
            this.cargarComponentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.actualizacionToolStripMenuItem});
            this.cargarComponentesToolStripMenuItem.Name = "cargarComponentesToolStripMenuItem";
            this.cargarComponentesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.cargarComponentesToolStripMenuItem.Text = "Componentes";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            // 
            // gdpnlMain
            // 
            this.gdpnlMain.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(107)))), ((int)(((byte)(6)))));
            this.gdpnlMain.ColorTop = System.Drawing.Color.Black;
            this.gdpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdpnlMain.Location = new System.Drawing.Point(156, 0);
            this.gdpnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.gdpnlMain.Name = "gdpnlMain";
            this.gdpnlMain.Size = new System.Drawing.Size(1369, 875);
            this.gdpnlMain.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 875);
            this.Controls.Add(this.gdpnlMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TSMICapturar;
        private System.Windows.Forms.ToolStripMenuItem cargarComponentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private Librarys.GradientPanel gdpnlMain;
    }
}