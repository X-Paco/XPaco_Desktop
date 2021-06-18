using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xpaco.models;
using Xpaco.controllers;
using Newtonsoft.Json;

namespace Xpaco
{
    public partial class Links : Form
    {
        public Links()
        {
            InitializeComponent();
        }


        private void btnVoltarPaginaLinks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarPaginaLinks_Click(object sender, EventArgs e)
        {
            InseriRegistro(txtDescricaoPaginaLinks.Text, txtIconePaginaLinks.Text, txtUrlPaginaLinks.Text);
            this.Close();
        }

        private void InseriRegistro(string descricao, string icone, string url)
        {
            // Construir o objeto pelo model
            Link serializa = new Link();

            serializa.description = descricao;
            serializa.icons = icone;
            serializa.url = url;
            try
            {
                // TODO - O Json da ROTA deve ser do mesmo tipo da lista a ser criada
                String rota = "http://localhost:3001/link/";
                String json = JsonConvert.SerializeObject(serializa);
                Object objStreamURI = WebRequestAPI.Post(rota, json);
                MessageBox.Show("Midias armazenada com sucesso!!");
            }
            catch (System.ServiceModel.FaultException)
            {
                MessageBox.Show("não encontrado");
                
                return;
            }
            
        }
    }
}
