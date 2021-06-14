using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xpaco.model;
using Xpaco.controller;

namespace Xpaco
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
 
        private void btnVoltarPaginaCadastro_Click(object sender, EventArgs e)
        {
            HomePage pgInicial = new HomePage();
            this.Close();
            pgInicial.Show();
        }

        private void btnMaximizarPaginaCadastro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarPaginaCadastro.Visible = false;
            btnRestaurarTamanhoPaginaCadastro.Visible = true;
            panelBottomPaginaCadastro.Visible = true;
        }

        private void btnMinimizarPaginaCadastro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurarTamanhoPaginaCadastro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurarTamanhoPaginaCadastro.Visible = false;
            btnMaximizarPaginaCadastro.Visible = true;
            panelBottomPaginaCadastro.Visible = false;
        }

        private void btnFecharPaginaCadastro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtbTelefonePaginaCadastro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             
        }

        private void btnCadastroUser_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text =="")
            {
                MessageBox.Show("Preencher o nome");
                txtBoxNome.Focus();
                txtBoxNome.Clear();
                return;
            }
        }

        private void btnUpdPerfil_Click(object sender, EventArgs e)
        {
            Profile perfil = new Profile();
            this.Close();
            perfil.Show();
        }
    }
}
