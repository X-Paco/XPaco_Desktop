using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
        
        private void btnCadastrarPaginaCadastro_Click(object sender, EventArgs e)
        {
            /*if ()
            {

            }*/
            
            profile perfil = new profile();
            this.Close();
            perfil.Show();
      
        }

        private void btnVoltarPaginaCadastro_Click(object sender, EventArgs e)
        {
            homePage pgInicial = new homePage();
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
    }
}
