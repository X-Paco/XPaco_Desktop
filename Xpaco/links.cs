using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class links : Form
    {
        public links()
        {
            InitializeComponent();
        }

        private void btnFecharPaginaLinks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurarTamanhoPaginaLinks_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizarPaginaLinks.Visible = true;
            btnRestaurarTamanhoPaginaLinks.Visible = false;
        }

        private void btnMinimizarPaginaLinks_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarPaginaLinks_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarPaginaLinks.Visible = false;
            btnRestaurarTamanhoPaginaLinks.Visible = true;
        }

        private void btnVoltarPaginaLinks_Click(object sender, EventArgs e)
        {
            homePage pgInicial = new homePage();
            this.Close();
            pgInicial.Show();
        }
    }
}
