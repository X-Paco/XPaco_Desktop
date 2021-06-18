using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtSenhaPaginaLogin.Text = "";
            txtSenhaPaginaLogin.PasswordChar = '*';
            txtSenhaPaginaLogin.MaxLength = 14;
        }
 

        private void btnVoltarPaginaLogin_Click(object sender, EventArgs e)
        {
            HomePage telaInicial = new HomePage();
            this.Close();
            telaInicial.Show();
        }

        private void btnLogarPaginaLogin_Click(object sender, EventArgs e)
        {
           
            if (txtEmailPaginaLogin.Text == "")
            {
                MessageBox.Show("Preencher o email");
                txtEmailPaginaLogin.Focus();
                txtEmailPaginaLogin.Clear();
                return;
            }
            else if (txtSenhaPaginaLogin.Text == "")
            {
                MessageBox.Show("Preencher a senha");
                txtSenhaPaginaLogin.Focus();
                txtSenhaPaginaLogin.Clear();
                return;
            }

            Profile pgProfile = new Profile();
            this.Hide();
            pgProfile.Show();

        }

        private void txtEmailPaginaLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
