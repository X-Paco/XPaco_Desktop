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
        }
 

        private void btnVoltarPaginaLogin_Click(object sender, EventArgs e)
        {
            HomePage telaInicial = new HomePage();
            this.Close();
            telaInicial.Show();
        }

        private void btnLogarPaginaLogin_Click(object sender, EventArgs e)
        {
            Profile pgProfile = new Profile();
            this.Hide();
            pgProfile.Show();
        }
    }
}
