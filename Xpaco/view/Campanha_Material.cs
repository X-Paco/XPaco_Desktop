using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void btnFecharPaginaCadastro_Click(object sender, EventArgs e)
        {
            Campanha pgCampanha = new Campanha();
            this.Hide();
            pgCampanha.Show();
        }

        private void btnMinimizarPaginaCadastro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurarTamanhoPaginaCadastro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizarPaginaCadastro.Visible = true;
            btnRestaurarTamanhoPaginaCadastro.Visible = false;
            panelBottomPaginaMaterial.Visible = false;
        }

        private void btnMaximizarPaginaCadastro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarPaginaCadastro.Visible = false;
            btnRestaurarTamanhoPaginaCadastro.Visible = true;
            panelBottomPaginaMaterial.Visible = true;
        }

        private void btnVoltarPaginaMaterial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarPaginaMaterial_Click(object sender, EventArgs e)
        {
            //Validação vinda do back.
            this.Close();
        }

        
    }
}
