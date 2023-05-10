namespace Scrap.Forms
{
    partial class frmCapturas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtComponente = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.txtPL = new System.Windows.Forms.TextBox();
            this.txtCurrentCost = new System.Windows.Forms.TextBox();
            this.gdpnlMain = new Scrap.Librarys.GradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gdpnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(26, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 366);
            this.panel2.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(26, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 43);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dgvComponentes);
            this.panel1.Location = new System.Drawing.Point(26, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 355);
            this.panel1.TabIndex = 16;
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponentes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Location = new System.Drawing.Point(17, 15);
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.RowHeadersVisible = false;
            this.dgvComponentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComponentes.ShowEditingIcon = false;
            this.dgvComponentes.Size = new System.Drawing.Size(878, 327);
            this.dgvComponentes.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(728, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(894, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtComponente
            // 
            this.txtComponente.Location = new System.Drawing.Point(386, 38);
            this.txtComponente.Name = "txtComponente";
            this.txtComponente.Size = new System.Drawing.Size(100, 20);
            this.txtComponente.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(386, 74);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 20;
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(386, 100);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(100, 20);
            this.txtUM.TabIndex = 21;
            // 
            // txtPL
            // 
            this.txtPL.Location = new System.Drawing.Point(386, 141);
            this.txtPL.Name = "txtPL";
            this.txtPL.Size = new System.Drawing.Size(100, 20);
            this.txtPL.TabIndex = 22;
            // 
            // txtCurrentCost
            // 
            this.txtCurrentCost.Location = new System.Drawing.Point(386, 181);
            this.txtCurrentCost.Name = "txtCurrentCost";
            this.txtCurrentCost.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentCost.TabIndex = 23;
            // 
            // gdpnlMain
            // 
            this.gdpnlMain.ColorBottom = System.Drawing.Color.Red;
            this.gdpnlMain.ColorTop = System.Drawing.Color.Black;
            this.gdpnlMain.Controls.Add(this.txtCurrentCost);
            this.gdpnlMain.Controls.Add(this.txtPL);
            this.gdpnlMain.Controls.Add(this.txtUM);
            this.gdpnlMain.Controls.Add(this.txtDescripcion);
            this.gdpnlMain.Controls.Add(this.txtComponente);
            this.gdpnlMain.Controls.Add(this.pictureBox1);
            this.gdpnlMain.Controls.Add(this.textBox1);
            this.gdpnlMain.Controls.Add(this.panel1);
            this.gdpnlMain.Controls.Add(this.btnAgregar);
            this.gdpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdpnlMain.Location = new System.Drawing.Point(0, 0);
            this.gdpnlMain.Name = "gdpnlMain";
            this.gdpnlMain.Size = new System.Drawing.Size(970, 591);
            this.gdpnlMain.TabIndex = 18;
            this.gdpnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.gdpnlMain_Paint);
            // 
            // frmCapturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 591);
            this.Controls.Add(this.gdpnlMain);
            this.Controls.Add(this.panel2);
            this.Name = "frmCapturas";
            this.Text = "frmCapturas";
            this.Load += new System.EventHandler(this.frmCapturas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gdpnlMain.ResumeLayout(false);
            this.gdpnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtComponente;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.TextBox txtPL;
        private System.Windows.Forms.TextBox txtCurrentCost;
        private Librarys.GradientPanel gdpnlMain;
    }
}