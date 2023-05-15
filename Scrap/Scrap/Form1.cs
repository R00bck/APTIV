using Scrap.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap
{
    public partial class frmLoguin : Form
    {
        Librarys.Login login;
        DateTime lastKeyPress = DateTime.Now;
        private int operadorMaquina;
        public frmLoguin()
        {
            InitializeComponent();
            login = new Librarys.Login();
        }

        /*private void btnOk_Click(object sender, EventArgs e)
        {
            if(validate(txtuser.Text.Trim(), txtPassword.Text.Trim()))
            {
                if(login.HaveAcces(txtuser.Text.Trim(), txtPassword.Text.Trim()))
                {
                    Forms.frmMain inicio = new Forms.frmMain();
                    inicio.UserId = login.IdUser;
                    this.Hide();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o password incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos faltantes.");
            }
        }*/

        private bool validate(string user, string password)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
                return false;
            else
                return true;
        }

        /*private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TimeSpan)(DateTime.Now - lastKeyPress)).TotalMilliseconds > 200)
            {
                txtuser.Clear();
                txtuser.Focus();
                //modificarMensaje(2, "Error introduce un numero de empleado valido inicio");
            }
            else
            {
                if (e.KeyChar == ((char)Keys.Enter))
                {
                    string operador = txtuser.Text;
                    try
                    {
                        if (operador.Length >= 7)
                        {
                            if (operador != "")
                            {
                                if ((operador.Substring(6, 1)).ToUpper() == "A" || (operador.Substring(6, 1)).ToUpper() == "B")
                                {
                                    //operadorMaquina = operador.Substring(5, 4);
                                    operadorMaquina = int.Parse(operador.Substring(1, 5));
                                    // operadormaquina
                                    frmMain main = new Forms.frmMain(operadorMaquina);
                                    this.Hide();
                                    main.Show();
                                }
                                else
                                {
                                    lblTitle.Text = "Error introduce un numero de empleado valido";
                                    txtuser.Clear();
                                    txtuser.Focus();
                                }
                            }
                        }
                        else
                        {
                            lblTitle.Text = "Error introduce un numero de empleado valido";
                            txtuser.Clear();
                            txtuser.Focus();
                        }
                    }
                    catch
                    {
                        lblTitle.Text = "Error introduce un numero de empleado valido";
                    }
                }
            }
            lastKeyPress = DateTime.Now;
        }
    }
}
