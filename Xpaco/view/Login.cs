using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Xpaco.models;
using Xpaco.controllers;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtSenhaPaginaLogin.Text = "";
            txtSenhaPaginaLogin.PasswordChar = '*';
            txtSenhaPaginaLogin.MaxLength = 14;
        }
 

        private void btnVoltarPaginaLogin_Click(object sender, EventArgs e)
        {
            HomePage telaInicial = new HomePage();
            this.Close();
            telaInicial.Show();
        }

        private void btnLogarPaginaLogin_Click(object sender, EventArgs e)
        {
           
            if (txtEmailPaginaLogin.Text == "")
            {
                MessageBox.Show("Preencher o email");
                txtEmailPaginaLogin.Focus();
                txtEmailPaginaLogin.Clear();
                return;
            }
            else if (txtSenhaPaginaLogin.Text == "")
            {
                MessageBox.Show("Preencher a senha");
                txtSenhaPaginaLogin.Focus();
                txtSenhaPaginaLogin.Clear();
                return;
            }

            CarregarTabela();
           

        }

        public void CarregarTabela()
        {

            // Declarar Objeto do tipo lista<> (Dinâmica)
            // TODO - O Json da ROTA deve ser do mesmo tipo da lista a ser criada
            List<User> descerializa;

            String rota = "http://localhost:3001/user/";

            Object objStreamURI = WebRequestAPI.GetLista(rota);

            descerializa = JsonConvert.DeserializeObject<List<User>>(objStreamURI.ToString());

            // ---------------------------------------------------------------

            

            foreach (User i in descerializa)
            {
                
                if(txtEmailPaginaLogin.Equals(i.Email) && txtSenhaPaginaLogin.Equals(i.Password) )
                {
                    Profile profile = new Profile();
                    profile.Show();
                }
                else
                {
                    MessageBox.Show("Não entrou no primeiro If");
                }
            }
        
        }
    }
}
