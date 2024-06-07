using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Xpaco.models;
using Xpaco.controllers;
using Newtonsoft.Json;


namespace Xpaco
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();

            txtBoxSenha.Text = "";
            txtBoxSenha.PasswordChar = '*';
            txtBoxSenha.MaxLength = 14;
            txtBoxRepitaSenha.Text = "";
            txtBoxRepitaSenha.PasswordChar = '*';
            txtBoxRepitaSenha.MaxLength = 14;
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
            if (txtBoxNome.Text == "")
            {
                MessageBox.Show("Preencher o nome");
                txtBoxNome.Focus();
                txtBoxNome.Clear();
                return;
            }
            else if (txtBoxApelido.Text == "")
            {
                MessageBox.Show("Preencher o apelido");
                txtBoxNome.Focus();
                txtBoxNome.Clear();
                return;
            }
            else if (txtBoxEmail.Text == "")
            {
                MessageBox.Show("Preencher o email");
                txtBoxNome.Focus();
                txtBoxNome.Clear();
                return;
            }

            InseriRegistro(txtBoxNome.Text, txtBoxApelido.Text, txtBoxSenha.Text, txtBoxRepitaSenha.Text, txtBoxTelefone.Text);

        }

        

        private void InseriRegistro(string Name, string Nickname, string Password, string PasswordConfirm, string mobile)
        {
            // Construir o objeto pelo model
            User serializa = new User();

            serializa.Name = Name;
            serializa.PersonaId = 2;
            serializa.Nickname = Nickname;
            serializa.Password = Password;
            serializa.PasswordConfirm = PasswordConfirm;
            serializa.Mobile = mobile;

            try
            {
                // TODO - O Json da ROTA deve ser do mesmo tipo da lista a ser criada
                String rota = "http://localhost:3001/user/";
                String json = JsonConvert.SerializeObject(serializa);
                Object objStreamURI = WebRequestAPI.Post(rota, json);
            }
            catch (System.ServiceModel.FaultException)
            {
                
                MessageBox.Show("não encontrado");
                txtBoxEmail.Focus();
                return;
            }

        }
    }
}
