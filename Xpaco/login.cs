using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnMinimizarPaginaLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;           
        }

        private void btnMaximizarPaginaLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarPaginaLogin.Visible = false;
            btnRestaurarTamanhoPaginaLogin.Visible = true;
        }

        private void btnFecharPaginaLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurarTamanhoPaginaLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizarPaginaLogin.Visible = true;
            btnRestaurarTamanhoPaginaLogin.Visible = false;
        }

        private void btnVoltarPaginaLogin_Click(object sender, EventArgs e)
        {
            homePage telaInicial = new homePage();
            this.Close();
            telaInicial.Show();
        }
    }
}
