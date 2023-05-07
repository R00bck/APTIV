namespace Scrap.Forms
{
    partial class frmCoax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoax));
            this.gradientLayouPanel1 = new Scrap.Librarys.GradientLayouPanel();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.tblCaptura = new System.Windows.Forms.TableLayoutPanel();
            this.lblAreas = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cbxProceso = new System.Windows.Forms.ComboBox();
            this.txtLead = new System.Windows.Forms.TextBox();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblDefecto = new System.Windows.Forms.Label();
            this.cbxDefecto = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientLayouPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.tblCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientLayouPanel1
            // 
            this.gradientLayouPanel1.ColorBottom = System.Drawing.Color.Black;
            this.gradientLayouPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(107)))), ((int)(((byte)(6)))));
            this.gradientLayouPanel1.ColumnCount = 1;
            this.gradientLayouPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gradientLayouPanel1.Controls.Add(this.dgvComponentes, 0, 1);
            this.gradientLayouPanel1.Controls.Add(this.lblMensajes, 0, 2);
            this.gradientLayouPanel1.Controls.Add(this.tblCaptura, 0, 0);
            this.gradientLayouPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLayouPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLayouPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientLayouPanel1.Name = "gradientLayouPanel1";
            this.gradientLayouPanel1.RowCount = 3;
            this.gradientLayouPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.gradientLayouPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.gradientLayouPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gradientLayouPanel1.Size = new System.Drawing.Size(1379, 784);
            this.gradientLayouPanel1.TabIndex = 25;
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComponentes.Location = new System.Drawing.Point(4, 239);
            this.dgvComponentes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.RowHeadersWidth = 51;
            this.dgvComponentes.Size = new System.Drawing.Size(1371, 501);
            this.dgvComponentes.TabIndex = 4;
            // 
            // lblMensajes
            // 
            this.lblMensajes.BackColor = System.Drawing.Color.Silver;
            this.lblMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes.Location = new System.Drawing.Point(4, 744);
            this.lblMensajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(1371, 40);
            this.lblMensajes.TabIndex = 3;
            this.lblMensajes.Text = "MENSAJES";
            this.lblMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCaptura
            // 
            this.tblCaptura.BackColor = System.Drawing.Color.Transparent;
            this.tblCaptura.ColumnCount = 4;
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblCaptura.Controls.Add(this.lblAreas, 0, 0);
            this.tblCaptura.Controls.Add(this.lblLinea, 0, 1);
            this.tblCaptura.Controls.Add(this.lblBusqueda, 0, 2);
            this.tblCaptura.Controls.Add(this.cbxProceso, 1, 3);
            this.tblCaptura.Controls.Add(this.txtLead, 1, 2);
            this.tblCaptura.Controls.Add(this.lblProceso, 0, 3);
            this.tblCaptura.Controls.Add(this.lblDefecto, 0, 4);
            this.tblCaptura.Controls.Add(this.cbxDefecto, 1, 4);
            this.tblCaptura.Controls.Add(this.lblCantidad, 0, 5);
            this.tblCaptura.Controls.Add(this.txtCantidad, 1, 5);
            this.tblCaptura.Controls.Add(this.label2, 2, 0);
            this.tblCaptura.Controls.Add(this.lblOperador, 2, 1);
            this.tblCaptura.Controls.Add(this.label1, 3, 1);
            this.tblCaptura.Controls.Add(this.lblShift, 3, 0);
            this.tblCaptura.Controls.Add(this.lblArea, 1, 0);
            this.tblCaptura.Controls.Add(this.lblLine, 1, 1);
            this.tblCaptura.Controls.Add(this.pictureBox1, 2, 3);
            this.tblCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCaptura.Location = new System.Drawing.Point(4, 4);
            this.tblCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.tblCaptura.Name = "tblCaptura";
            this.tblCaptura.RowCount = 6;
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.Size = new System.Drawing.Size(1371, 227);
            this.tblCaptura.TabIndex = 24;
            // 
            // lblAreas
            // 
            this.lblAreas.BackColor = System.Drawing.Color.Transparent;
            this.lblAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreas.ForeColor = System.Drawing.Color.White;
            this.lblAreas.Location = new System.Drawing.Point(4, 0);
            this.lblAreas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreas.Name = "lblAreas";
            this.lblAreas.Size = new System.Drawing.Size(129, 37);
            this.lblAreas.TabIndex = 0;
            this.lblAreas.Text = "Area:";
            this.lblAreas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLinea
            // 
            this.lblLinea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.ForeColor = System.Drawing.Color.White;
            this.lblLinea.Location = new System.Drawing.Point(4, 37);
            this.lblLinea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(129, 37);
            this.lblLinea.TabIndex = 1;
            this.lblLinea.Text = "Linea:";
            this.lblLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(4, 74);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(129, 37);
            this.lblBusqueda.TabIndex = 4;
            this.lblBusqueda.Text = "Buscar:";
            this.lblBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxProceso
            // 
            this.cbxProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProceso.Enabled = false;
            this.cbxProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProceso.FormattingEnabled = true;
            this.cbxProceso.Location = new System.Drawing.Point(141, 115);
            this.cbxProceso.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProceso.Name = "cbxProceso";
            this.cbxProceso.Size = new System.Drawing.Size(540, 32);
            this.cbxProceso.TabIndex = 6;
            this.cbxProceso.DropDownClosed += new System.EventHandler(this.cbxProceso_DropDownClosed);
            // 
            // txtLead
            // 
            this.txtLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLead.Enabled = false;
            this.txtLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLead.Location = new System.Drawing.Point(141, 78);
            this.txtLead.Margin = new System.Windows.Forms.Padding(4);
            this.txtLead.Name = "txtLead";
            this.txtLead.Size = new System.Drawing.Size(209, 29);
            this.txtLead.TabIndex = 8;
            this.txtLead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLead_KeyDown);
            // 
            // lblProceso
            // 
            this.lblProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProceso.ForeColor = System.Drawing.Color.White;
            this.lblProceso.Location = new System.Drawing.Point(4, 111);
            this.lblProceso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(129, 37);
            this.lblProceso.TabIndex = 2;
            this.lblProceso.Text = "Proceso:";
            this.lblProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefecto
            // 
            this.lblDefecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefecto.ForeColor = System.Drawing.Color.White;
            this.lblDefecto.Location = new System.Drawing.Point(4, 148);
            this.lblDefecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefecto.Name = "lblDefecto";
            this.lblDefecto.Size = new System.Drawing.Size(129, 37);
            this.lblDefecto.TabIndex = 3;
            this.lblDefecto.Text = " Defecto:";
            this.lblDefecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxDefecto
            // 
            this.cbxDefecto.Enabled = false;
            this.cbxDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDefecto.FormattingEnabled = true;
            this.cbxDefecto.Location = new System.Drawing.Point(141, 152);
            this.cbxDefecto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDefecto.Name = "cbxDefecto";
            this.cbxDefecto.Size = new System.Drawing.Size(311, 32);
            this.cbxDefecto.TabIndex = 25;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(4, 185);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(129, 42);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(141, 189);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(157, 29);
            this.txtCantidad.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(689, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Turno:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperador
            // 
            this.lblOperador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.White;
            this.lblOperador.Location = new System.Drawing.Point(689, 37);
            this.lblOperador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(129, 37);
            this.lblOperador.TabIndex = 24;
            this.lblOperador.Text = "Operador:";
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(826, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "10478";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShift
            // 
            this.lblShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.ForeColor = System.Drawing.Color.White;
            this.lblShift.Location = new System.Drawing.Point(826, 0);
            this.lblShift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(541, 37);
            this.lblShift.TabIndex = 27;
            this.lblShift.Text = "A";
            this.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(141, 0);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(540, 28);
            this.lblArea.TabIndex = 28;
            this.lblArea.Text = "COAXIALES 5";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLine
            // 
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(141, 37);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(540, 37);
            this.lblLine.TabIndex = 29;
            this.lblLine.Text = "CL-70";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(689, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.tblCaptura.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(128, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmCoax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1379, 784);
            this.Controls.Add(this.gradientLayouPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCoax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPTURA";
            this.Load += new System.EventHandler(this.frmCoax_Load);
            this.gradientLayouPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.tblCaptura.ResumeLayout(false);
            this.tblCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblCaptura;
        private System.Windows.Forms.Label lblAreas;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cbxProceso;
        private System.Windows.Forms.TextBox txtLead;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblDefecto;
        private System.Windows.Forms.ComboBox cbxDefecto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblLine;
        private Librarys.GradientLayouPanel gradientLayouPanel1;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}