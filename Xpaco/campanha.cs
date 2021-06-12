using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class campanha : Form
    {
        public campanha()
        {
            InitializeComponent();
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
            panelBottomPaginaCampanha.Visible = true;
        }

        private void btnRestaurarTamanhoPaginaLinks_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizarPaginaLinks.Visible = true;
            btnRestaurarTamanhoPaginaLinks.Visible = false;
            panelBottomPaginaCampanha.Visible = false;
        }

        private void btnFecharPaginaLinks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MidiasPaginaCampanha_Click(object sender, EventArgs e)
        {
            media midias = new media();            
            midias.Show();
        }

        private void btnMateriaisPaginaCampanha_Click(object sender, EventArgs e)
        {
            material pgMaterial = new material();
            pgMaterial.Show();
        }

        private void btnVoltarPaginaCampanha_Click(object sender, EventArgs e)
        {
            profile pgProfile = new profile();
            this.Close();
            pgProfile.Show();
        }

        private void btnGravarPaginaCampanha_Click(object sender, EventArgs e)
        {
            /*
             if()
            {
            }
             */
        }
    }
}
