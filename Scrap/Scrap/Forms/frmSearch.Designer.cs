namespace Scrap.Forms
{
    partial class frmSearch
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
            this.tbcQuery = new System.Windows.Forms.TabControl();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.twNp = new System.Windows.Forms.TreeView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tbpCapture = new System.Windows.Forms.TabPage();
            this.tbcQuery.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcQuery
            // 
            this.tbcQuery.Controls.Add(this.tbpSearch);
            this.tbcQuery.Controls.Add(this.tbpCapture);
            this.tbcQuery.Location = new System.Drawing.Point(2, 2);
            this.tbcQuery.Name = "tbcQuery";
            this.tbcQuery.SelectedIndex = 0;
            this.tbcQuery.Size = new System.Drawing.Size(945, 565);
            this.tbcQuery.TabIndex = 0;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.twNp);
            this.tbpSearch.Controls.Add(this.txtSearch);
            this.tbpSearch.Controls.Add(this.dgvData);
            this.tbpSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearch.Size = new System.Drawing.Size(937, 539);
            this.tbpSearch.TabIndex = 0;
            this.tbpSearch.Text = "Consulta";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // twNp
            // 
            this.twNp.Location = new System.Drawing.Point(6, 47);
            this.twNp.Name = "twNp";
            this.twNp.Size = new System.Drawing.Size(160, 486);
            this.twNp.TabIndex = 2;
            this.twNp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twNp_AfterSelect);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(172, 19);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(759, 514);
            this.dgvData.TabIndex = 0;
            // 
            // tbpCapture
            // 
            this.tbpCapture.Location = new System.Drawing.Point(4, 22);
            this.tbpCapture.Name = "tbpCapture";
            this.tbpCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCapture.Size = new System.Drawing.Size(937, 539);
            this.tbpCapture.TabIndex = 1;
            this.tbpCapture.Text = "Capturado";
            this.tbpCapture.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 571);
            this.Controls.Add(this.tbcQuery);
            this.Name = "frmSearch";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.tbcQuery.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.tbpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcQuery;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.TreeView twNp;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tbpCapture;
    }
}