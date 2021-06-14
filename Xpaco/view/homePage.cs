using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurarTamanhoHomePage.Visible = true;
        }

        private void btnRestaurarTamanhoHomePage_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurarTamanhoHomePage.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*private void AbrirForms(object telinha)
        {
            if (this.panelCentralHomePage.Controls.Count > 0)
                this.panelCentralHomePage.Controls.RemoveAt(0);
            Form fh = telinha as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCentralHomePage.Controls.Add(fh);
            this.panelCentralHomePage.Tag = fh;
            fh.Show();
        }*/

        private void btnCadastroHomePage_Click(object sender, EventArgs e)
        {
            User pgUser = new User();
            this.Hide();
            pgUser.Show();
        }

        private void btnMeuAcessoHomePage_Click(object sender, EventArgs e)
        {
            Login pgLogin = new Login();
            this.Hide();
            pgLogin.Show();
            
            
        }
    }
}
