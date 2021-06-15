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
        

        private void btnVoltarPaginaPerfil_Click(object sender, EventArgs e)
        {
            Login cadastro = new Login();
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
