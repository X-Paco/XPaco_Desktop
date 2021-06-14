using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }
        private void btnVoltarPaginaMidia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarPaginaMidia_Click(object sender, EventArgs e)
        {
            this.Close();
            //Exibir se foi salvo com sucesso ou se algum requisito ficou faltando.
        }

        private void btnMaximizarPaginaMidia_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarPaginaMidia.Visible = false;
            btnRestaurarTamanhoPaginaMidia.Visible = true;
            panelBottomPaginaMidia.Visible = true;
            
        }

        private void btnMinimizarPaginaMidia_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurarTamanhoPaginaMidia_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizarPaginaMidia.Visible = true;
            btnRestaurarTamanhoPaginaMidia.Visible = false;
            panelBottomPaginaMidia.Visible = false;
        }

        private void btnFecharPaginaMidia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
