using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnMinimizarPaginaPerfil_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarPaginaPerfil_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarPaginaPerfil.Visible = false;
            btnRestaurarTamanhoPaginaPerfil.Visible = true;
            panelBottomPaginaPerfil.Visible = true;
        }

        private void btnRestaurarTamanhoPaginaPerfil_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizarPaginaPerfil.Visible = true;
            btnRestaurarTamanhoPaginaPerfil.Visible = false;
            panelBottomPaginaPerfil.Visible = false;
        }

        private void btnFecharPaginaPerfil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltarPaginaPerfil_Click(object sender, EventArgs e)
        {
            User cadastro = new User();
            this.Hide();
            cadastro.Show();
        }

        private void btnSalvarPaginaPerfil_Click(object sender, EventArgs e)
        {
            Campanha novaCampanha = new Campanha();
            this.Hide();
            novaCampanha.Show();
        }

        private void btnLinkPaginaPerfil_Click(object sender, EventArgs e)
        {
            Links pgLinks = new Links();
            pgLinks.Show();
        }
    }
}
