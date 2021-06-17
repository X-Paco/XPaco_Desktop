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



        public void InseriRegistro(string texto)
        {
            // Construir o objeto pelo model
            Persona serializa = new Persona();

            serializa.description = txtDescricao.Text;

            try
            {
                // TODO - O Json da ROTA deve ser do mesmo tipo da lista a ser criada
                String rota = "http://localhost:3001/persona/";
                String json = JsonConvert.SerializeObject(serializa);
                Object objStreamURI = WebRequestAPI.post(rota, json);
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
        ///  Método de consumo de tabela
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
            // TODO - Rota sem parâmetro
            listViewXpaco.Items.Clear();

            //foreach (Persona i in persona)
            //{
            //    ListViewItem item = listViewPersona.Items.Add(Convert.ToString(i.id));
            //    item.SubItems.Add(i.id);
            //    item.SubItems.Add(i.description);
            //}
            for (int i = 0; i < descerializa.Count; i++)
            {
                ListViewItem item = listViewXpaco.Items.Add(descerializa[i].id);
                item.SubItems.Add(descerializa[i].id);
                item.SubItems.Add(descerializa[i].description);
            }


        }

    }
}
