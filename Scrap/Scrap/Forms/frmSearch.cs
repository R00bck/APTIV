using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap.Forms
{
    public partial class frmSearch : Form
    {
        Librarys.Scrap _scrap;
        Librarys.clsResize _form_resize;

        private string key;
        private string lead;
        private int tipo;
        public frmSearch()
        {
            InitializeComponent();
            _scrap = new Librarys.Scrap();
            _form_resize = new Librarys.clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }
        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        private void SearchLead(string lead)
        {
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvData.ReadOnly = true;
            if (tipo == 1)
            {
                dgvData.DataSource = _scrap.SearchListComponentsView(lead);
            }
            else
            {
                dgvData.DataSource = _scrap.SelectComponentesNp(lead);
            }
            this.dgvData.Columns[0].Visible = false;
        }
        private void frmSearch_Load(object sender, EventArgs e)
        {
            PopulateTreeViewAreas(0, null);
        }
        private void PopulateTreeViewAreas(int parentId, TreeNode parentNode)
        {
            DataTable da = new DataTable();
            da = _scrap.SelectAreas();
            foreach (DataRow dr in da.Rows)
            {
                parentNode = twNp.Nodes.Add(dr["AREA"].ToString());
                PopulateTreeViewLineas(Convert.ToInt32(dr["ID"].ToString()), parentNode);
            }
        }
        private void PopulateTreeViewLineas(int parentId, TreeNode parentNode)
        {
            DataTable da = new DataTable();
            da = _scrap.SelectLineassearch(parentId);
            TreeNode childNode;
            childNode = new TreeNode();

            foreach (DataRow dr in da.Rows)
            {
                /*childNode.Text = dr["LEAD"].ToString();*/
                if (parentNode == null)
                {
                    childNode = twNp.Nodes.Add(dr["MAQUINA"].ToString());
                    //childNode.Name = dr["ID"].ToString() + "-L";
                }
                else
                {
                    childNode = parentNode.Nodes.Add(dr["MAQUINA"].ToString());
                    //childNode.Name = dr["ID"].ToString() + "-L";
                }
                PopulateTreeView(Convert.ToInt32(dr["ID"].ToString()), childNode);
            }
        }
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            DataTable da = new DataTable();
            da = _scrap.SelectNumparte(parentId);
            TreeNode childNode;
            childNode = new TreeNode();

            foreach (DataRow dr in da.Rows)
            {
                if (parentNode == null)
                {
                    childNode = twNp.Nodes.Add(dr["NP"].ToString());
                    //childNode.Name = dr["ID"].ToString() + "-L";
                }
                else
                {
                    childNode = parentNode.Nodes.Add(dr["NP"].ToString());
                    //childNode.Name = dr["ID"].ToString() + "-L";
                }
                //childNode = twNp.Nodes.Add(dr["NP"].ToString());
                PopulateTreeViewChild(Convert.ToInt32(dr["ID"].ToString()), parentNode);
            }
        }
        private void PopulateTreeViewChild(int parentId, TreeNode parentNode)
        {
            DataTable da = new DataTable();
            da = _scrap.SelectNumparteLeads(parentId);
            TreeNode childNode;
            childNode = new TreeNode();

            foreach (DataRow dr in da.Rows)
            {

                if (parentNode == null)
                {
                    childNode = twNp.Nodes.Add(dr["LEAD"].ToString());
                    childNode.Name = dr["ID"].ToString() + "-L";
                }
                else
                {
                    childNode = parentNode.Nodes.Add(dr["LEAD"].ToString());
                    childNode.Name = dr["ID"].ToString() + "-L";
                }
                //PopulateTreeViewChild(Convert.ToInt32(dr["ID"].ToString()), childNode);
            }
        }
        private void twNp_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            //MessageBox.Show(node.Name + "\n" + node.Text);
            try
            {
                if (String.IsNullOrEmpty(node.Name))
                {
                    if (node.Text.Contains("COAXIALES") || node.Text.Contains("CL"))
                    {
                        key = "";
                    }
                    else
                    {
                        tipo = 0;
                        key = node.Text;
                        SearchLead(key);
                    }
                }
                else
                {
                    string[] busqueda = node.Name.Split('-');
                    if (busqueda[1] == "L")
                    {
                        key = busqueda[0];
                        lead = node.Text;
                        tipo = 1;
                        SearchLead(key);
                    }
                    else
                    {

                    }
                }

            }
            catch
            {

            }
        }
        private bool SearchRecursive(IEnumerable nodes, string searchFo)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text.ToUpper().Contains(searchFo.ToUpper()))
                {
                    twNp.SelectedNode = node;
                    node.BackColor = Color.Yellow;
                }
                if (SearchRecursive(node.Nodes, searchFo))
                    return true;
            }
            return false;
        }
        private bool Empty()
        {
            if (String.IsNullOrEmpty(txtSearch.Text.Trim()))
                return false;
            else
                return true;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string search = txtSearch.Text.Trim();
                if (Empty())
                {
                    SearchRecursive(twNp.Nodes, search);
                }
                else
                {
                    MessageBox.Show("Ingrese un registro");
                }
            }
        }
    }
}
