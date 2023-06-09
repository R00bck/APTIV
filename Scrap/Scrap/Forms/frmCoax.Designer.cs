﻿namespace Scrap.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblLado = new System.Windows.Forms.Label();
            this.cbxLado = new System.Windows.Forms.ComboBox();
            this.lblNumparte = new System.Windows.Forms.Label();
            this.lblNp = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gradientLayouPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.tblCaptura.SuspendLayout();
            this.tblButtons.SuspendLayout();
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
            this.gradientLayouPanel1.Name = "gradientLayouPanel1";
            this.gradientLayouPanel1.RowCount = 3;
            this.gradientLayouPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.gradientLayouPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.gradientLayouPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gradientLayouPanel1.Size = new System.Drawing.Size(1034, 637);
            this.gradientLayouPanel1.TabIndex = 25;
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComponentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComponentes.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComponentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComponentes.Location = new System.Drawing.Point(3, 194);
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.RowHeadersVisible = false;
            this.dgvComponentes.RowHeadersWidth = 51;
            this.dgvComponentes.Size = new System.Drawing.Size(1028, 408);
            this.dgvComponentes.TabIndex = 4;
            // 
            // lblMensajes
            // 
            this.lblMensajes.BackColor = System.Drawing.Color.Silver;
            this.lblMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes.Location = new System.Drawing.Point(3, 605);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(1028, 32);
            this.lblMensajes.TabIndex = 3;
            this.lblMensajes.Text = "MENSAJES";
            this.lblMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCaptura
            // 
            this.tblCaptura.BackColor = System.Drawing.Color.Transparent;
            this.tblCaptura.ColumnCount = 4;
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
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
            this.tblCaptura.Controls.Add(this.lblLado, 2, 2);
            this.tblCaptura.Controls.Add(this.cbxLado, 3, 2);
            this.tblCaptura.Controls.Add(this.lblNumparte, 2, 3);
            this.tblCaptura.Controls.Add(this.lblNp, 3, 3);
            this.tblCaptura.Controls.Add(this.tblButtons, 3, 4);
            this.tblCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCaptura.Location = new System.Drawing.Point(3, 3);
            this.tblCaptura.Name = "tblCaptura";
            this.tblCaptura.RowCount = 6;
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCaptura.Size = new System.Drawing.Size(1028, 185);
            this.tblCaptura.TabIndex = 24;
            // 
            // lblAreas
            // 
            this.lblAreas.BackColor = System.Drawing.Color.Transparent;
            this.lblAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreas.ForeColor = System.Drawing.Color.White;
            this.lblAreas.Location = new System.Drawing.Point(3, 0);
            this.lblAreas.Name = "lblAreas";
            this.lblAreas.Size = new System.Drawing.Size(117, 30);
            this.lblAreas.TabIndex = 0;
            this.lblAreas.Text = "Area:";
            this.lblAreas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLinea
            // 
            this.lblLinea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.ForeColor = System.Drawing.Color.White;
            this.lblLinea.Location = new System.Drawing.Point(3, 30);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(117, 30);
            this.lblLinea.TabIndex = 1;
            this.lblLinea.Text = "Linea:";
            this.lblLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(3, 60);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(117, 30);
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
            this.cbxProceso.Location = new System.Drawing.Point(126, 93);
            this.cbxProceso.Name = "cbxProceso";
            this.cbxProceso.Size = new System.Drawing.Size(384, 26);
            this.cbxProceso.TabIndex = 6;
            this.cbxProceso.SelectedIndexChanged += new System.EventHandler(this.cbxProceso_SelectedIndexChanged);
            this.cbxProceso.DropDownClosed += new System.EventHandler(this.cbxProceso_DropDownClosed);
            // 
            // txtLead
            // 
            this.txtLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLead.Location = new System.Drawing.Point(126, 63);
            this.txtLead.Name = "txtLead";
            this.txtLead.Size = new System.Drawing.Size(158, 24);
            this.txtLead.TabIndex = 8;
            this.txtLead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLead_KeyDown);
            // 
            // lblProceso
            // 
            this.lblProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProceso.ForeColor = System.Drawing.Color.White;
            this.lblProceso.Location = new System.Drawing.Point(3, 90);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(117, 30);
            this.lblProceso.TabIndex = 2;
            this.lblProceso.Text = "Proceso:";
            this.lblProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefecto
            // 
            this.lblDefecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefecto.ForeColor = System.Drawing.Color.White;
            this.lblDefecto.Location = new System.Drawing.Point(3, 120);
            this.lblDefecto.Name = "lblDefecto";
            this.lblDefecto.Size = new System.Drawing.Size(117, 30);
            this.lblDefecto.TabIndex = 3;
            this.lblDefecto.Text = " Defecto:";
            this.lblDefecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxDefecto
            // 
            this.cbxDefecto.Enabled = false;
            this.cbxDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDefecto.FormattingEnabled = true;
            this.cbxDefecto.Location = new System.Drawing.Point(126, 123);
            this.cbxDefecto.Name = "cbxDefecto";
            this.cbxDefecto.Size = new System.Drawing.Size(234, 26);
            this.cbxDefecto.TabIndex = 25;
            this.cbxDefecto.SelectedIndexChanged += new System.EventHandler(this.cbxDefecto_SelectedIndexChanged);
            this.cbxDefecto.DropDownClosed += new System.EventHandler(this.cbxDefecto_DropDownClosed_1);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(3, 150);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(117, 35);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(126, 153);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(119, 24);
            this.txtCantidad.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Turno:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperador
            // 
            this.lblOperador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.White;
            this.lblOperador.Location = new System.Drawing.Point(516, 30);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(117, 30);
            this.lblOperador.TabIndex = 24;
            this.lblOperador.Text = "Operador:";
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(639, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "10478";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShift
            // 
            this.lblShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.ForeColor = System.Drawing.Color.White;
            this.lblShift.Location = new System.Drawing.Point(639, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(386, 30);
            this.lblShift.TabIndex = 27;
            this.lblShift.Text = "A";
            this.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(126, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(384, 23);
            this.lblArea.TabIndex = 28;
            this.lblArea.Text = "COAXIALES 5";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLine
            // 
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(126, 30);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(384, 30);
            this.lblLine.TabIndex = 29;
            this.lblLine.Text = "CL-70";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.ForeColor = System.Drawing.Color.White;
            this.lblLado.Location = new System.Drawing.Point(515, 60);
            this.lblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(119, 30);
            this.lblLado.TabIndex = 32;
            this.lblLado.Text = "Lado:";
            this.lblLado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLado.Visible = false;
            // 
            // cbxLado
            // 
            this.cbxLado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLado.FormattingEnabled = true;
            this.cbxLado.Items.AddRange(new object[] {
            "LADO 1",
            "LADO 2",
            "LADO 3"});
            this.cbxLado.Location = new System.Drawing.Point(638, 62);
            this.cbxLado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxLado.Name = "cbxLado";
            this.cbxLado.Size = new System.Drawing.Size(164, 25);
            this.cbxLado.TabIndex = 33;
            this.cbxLado.Visible = false;
            this.cbxLado.SelectedIndexChanged += new System.EventHandler(this.cbxLado_SelectedIndexChanged);
            // 
            // lblNumparte
            // 
            this.lblNumparte.AutoSize = true;
            this.lblNumparte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumparte.ForeColor = System.Drawing.Color.White;
            this.lblNumparte.Location = new System.Drawing.Point(515, 90);
            this.lblNumparte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumparte.Name = "lblNumparte";
            this.lblNumparte.Size = new System.Drawing.Size(92, 20);
            this.lblNumparte.TabIndex = 30;
            this.lblNumparte.Text = "Numparte:";
            this.lblNumparte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNp
            // 
            this.lblNp.AutoSize = true;
            this.lblNp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNp.ForeColor = System.Drawing.Color.White;
            this.lblNp.Location = new System.Drawing.Point(638, 90);
            this.lblNp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNp.Name = "lblNp";
            this.lblNp.Size = new System.Drawing.Size(49, 20);
            this.lblNp.TabIndex = 31;
            this.lblNp.Text = "0000";
            this.lblNp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnEliminar, 0, 0);
            this.tblButtons.Controls.Add(this.btnActualizar, 0, 0);
            this.tblButtons.Controls.Add(this.btnAgregar, 0, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(638, 122);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblCaptura.SetRowSpan(this.tblButtons, 2);
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblButtons.Size = new System.Drawing.Size(388, 61);
            this.tblButtons.TabIndex = 34;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEliminar.IconSize = 35;
            this.btnEliminar.Location = new System.Drawing.Point(261, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 55);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnActualizar.IconColor = System.Drawing.Color.Goldenrod;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnActualizar.IconSize = 35;
            this.btnActualizar.Location = new System.Drawing.Point(132, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(123, 55);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 55);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCoax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1034, 637);
            this.Controls.Add(this.gradientLayouPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCoax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPTURA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCoax_FormClosing);
            this.Load += new System.EventHandler(this.frmCoax_Load);
            this.gradientLayouPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.tblCaptura.ResumeLayout(false);
            this.tblCaptura.PerformLayout();
            this.tblButtons.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNumparte;
        private System.Windows.Forms.Label lblNp;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.ComboBox cbxLado;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}