﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class profile : Form
    {
        public profile()
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
            user cadastro = new user();
            this.Hide();
            cadastro.Show();
        }

        private void btnSalvarPaginaPerfil_Click(object sender, EventArgs e)
        {
            campanha novaCampanha = new campanha();
            this.Hide();
            novaCampanha.Show();
        }

        private void btnLinkPaginaPerfil_Click(object sender, EventArgs e)
        {
            links pgLinks = new links();
            pgLinks.Show();
        }
    }
}