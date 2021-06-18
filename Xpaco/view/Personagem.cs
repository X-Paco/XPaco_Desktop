using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xpaco.models;
using Xpaco.controllers;
using System.IO; // Fornece classes para tratar arquivos e demais fluxo de bytes
using System.Net; // Fornece classes para diversos protocolos de rede
using Newtonsoft.Json; // Permite serializar e desserializar objeto JSON no .net

namespace Xpaco.view
{
    public partial class Personagem : Form
    {
        public Personagem()
        {
            /// Aqui vou inserir o construtor Logado logado = new Logado();
            // estudar o fato
            InitializeComponent();
            /// Carga inicial da Classe CarregarTabela Declarada a baixo
        }

        // TODO - Método para ser carregado ao iniciar

        private void btIncluir_Click(object sender, EventArgs e)
        {
            InseriRegistro(txtDescricao.Text);
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            CarregarTabela();
        }
        private void btlAtualiza_Click(object sender, EventArgs e)
        {
            AtualizaRegistro(txtOldDesc.Text, txtDescricao.Text);
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {

            removeRegistro(txtDescricao.Text);
        }


 
        ///===========================================================
        /// ====================M É T O D O S=========================
        
        /// <summary>
        ///  MÉTODO POST / SERIALIZAÇÃO  / ENVIO DE ROTA
        /// </summary>
        /// <param name="texto"></param>
        private void InseriRegistro(string texto)
        {
            // Construir o objeto pelo model
            Persona serializa = new Persona();

            serializa.description = texto;
            try
            {
                // TODO - O Json da ROTA deve ser do mesmo tipo da lista a ser criada
                String rota = "http://localhost:3001/persona/";
                String json = JsonConvert.SerializeObject(serializa);
                Object objStreamURI = WebRequestAPI.Post(rota, json);
            }
            catch (System.ServiceModel.FaultException)
            {
                MessageBox.Show("não encontrado");
                txtDescricao.Focus();
                return;
            }
            finally
            {
                CarregarTabela();
            }
        }

        /// <summary>
        /// MÉTODO PUT / SERIALIZAÇÃO  / ENVIO DE ROTA
        /// </summary>
        /// <param name ="descricaoAntiga"></param>
        /// <param name ="novaDescricao"></param>
        private void AtualizaRegistro(string descricaoAntiga, string novaDescricao)
        {
            // Construir o objeto pelo model
            Persona serializa = new Persona();

            serializa.description = novaDescricao;
            serializa.oldDescription = descricaoAntiga;

            try
            {
                // TODO - O Json da ROTA deve ser do mesmo tipo da lista a ser criada
                String rota = "http://localhost:3001/persona/";
                String json = JsonConvert.SerializeObject(serializa);
                Object objStreamURI = WebRequestAPI.Put(rota, json);
            }
            catch (System.ServiceModel.FaultException)
            {
                MessageBox.Show("não encontrado");
                txtDescricao.Focus();
                return;
            }
               // CarregarTabela();
        }

        /// <summary>
        /// MÉTODO DELETE / SERIALIZAÇÃO  / ENVIO DE ROTA
        /// </summary>
        /// <param name ="Descricao"></param>
        private void removeRegistro(string Descricao)
        {
            Persona serializa = new Persona();

            serializa.description = Descricao;
            try
            {
                String rota = "http://localhost:3001/persona";
                String json = JsonConvert.SerializeObject(serializa);
                Object objResponse = WebRequestAPI.Delete(rota, json);

            }
            catch (System.ServiceModel.FaultException)
            {
                MessageBox.Show("não encontrado");
                txtDescricao.Focus();
                return;
            }
        }

        /// <summary>
        ///  MÉTODO GET / DESCERIALIZAÇÃO  / ENVIO DE ROTA
        /// </summary>
        public void CarregarTabela()
        {

            // Declarar Objeto do tipo lista<> (Dinâmica)
            // TODO - O Json da ROTA deve ser do mesmo tipo da lista a ser criada
            List<Persona> descerializa;

            String rota = "http://localhost:3001/persona/";

            Object objStreamURI = WebRequestAPI.GetLista(rota);

            descerializa = JsonConvert.DeserializeObject<List<Persona>>(objStreamURI.ToString());

            // ---------------------------------------------------------------

            listViewXpaco.Items.Clear();

            foreach (Persona i in descerializa)
            {
                ListViewItem item = listViewXpaco.Items.Add(Convert.ToString(i.id));
                item.SubItems.Add(i.description);
            }
        }

    }
}
