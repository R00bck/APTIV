
namespace Scrap.Forms
{
    partial class frmQuery
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
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblLinea = new System.Windows.Forms.Label();
            this.cbxLineas = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.gbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.label1);
            this.gbxBusqueda.Controls.Add(this.cbxTurno);
            this.gbxBusqueda.Controls.Add(this.lblHasta);
            this.gbxBusqueda.Controls.Add(this.dtpHasta);
            this.gbxBusqueda.Controls.Add(this.lblDesde);
            this.gbxBusqueda.Controls.Add(this.dtpDesde);
            this.gbxBusqueda.Controls.Add(this.txtOperador);
            this.gbxBusqueda.Controls.Add(this.lblOperador);
            this.gbxBusqueda.Controls.Add(this.lblLinea);
            this.gbxBusqueda.Controls.Add(this.cbxLineas);
            this.gbxBusqueda.Controls.Add(this.lblArea);
            this.gbxBusqueda.Controls.Add(this.cbxArea);
            this.gbxBusqueda.Location = new System.Drawing.Point(12, 12);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(322, 230);
            this.gbxBusqueda.TabIndex = 0;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Buscar";
            // 
            // lblLinea
            // 
            this.lblLinea.Location = new System.Drawing.Point(15, 52);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(75, 13);
            this.lblLinea.TabIndex = 7;
            this.lblLinea.Text = "Linea:";
            this.lblLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxLineas
            // 
            this.cbxLineas.FormattingEnabled = true;
            this.cbxLineas.Location = new System.Drawing.Point(98, 49);
            this.cbxLineas.Name = "cbxLineas";
            this.cbxLineas.Size = new System.Drawing.Size(200, 21);
            this.cbxLineas.TabIndex = 6;
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(15, 22);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(75, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area:";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxArea
            // 
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(98, 19);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(200, 21);
            this.cbxArea.TabIndex = 4;
            this.cbxArea.DropDownClosed += new System.EventHandler(this.cbxArea_DropDownClosed);
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(15, 87);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(75, 13);
            this.lblOperador.TabIndex = 8;
            this.lblOperador.Text = "Operador:";
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOperador
            // 
            this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador.Location = new System.Drawing.Point(98, 82);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(200, 21);
            this.txtOperador.TabIndex = 9;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Checked = false;
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(98, 117);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.ShowCheckBox = true;
            this.dtpDesde.Size = new System.Drawing.Size(200, 21);
            this.dtpDesde.TabIndex = 10;
            // 
            // lblDesde
            // 
            this.lblDesde.Location = new System.Drawing.Point(15, 120);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(75, 13);
            this.lblDesde.TabIndex = 11;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHasta
            // 
            this.lblHasta.Location = new System.Drawing.Point(15, 156);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(75, 13);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Checked = false;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(98, 153);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.ShowCheckBox = true;
            this.dtpHasta.Size = new System.Drawing.Size(200, 21);
            this.dtpHasta.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(353, 29);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(353, 64);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Shift.:";
            // 
            // cbxTurno
            // 
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbxTurno.Location = new System.Drawing.Point(98, 186);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(68, 21);
            this.cbxTurno.TabIndex = 14;
            // 
            // frmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 254);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxBusqueda);
            this.MaximizeBox = false;
            this.Name = "frmQuery";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.frmQuery_Load);
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.ComboBox cbxLineas;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTurno;
    }
}