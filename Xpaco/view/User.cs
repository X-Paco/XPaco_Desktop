using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


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
