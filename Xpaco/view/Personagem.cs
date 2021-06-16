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
using System.IO; // Fornece classes para tratar arquivos e demais fluxo de bytes
using System.Net; // Fornece classes para diversos protocolos de rede
using Newtonsoft.Json; // Permite serializar e desserializar objeto JSON no .net

namespace Xpaco.view
{
    public partial class Personagem : Form
    {
        public Personagem()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string rota = "http://localhost:3001/persona/"+txtId;

            // Classe WebRequest: Faz uma solicitação para um URL
            var requisicaoWeb = WebRequest.CreateHttp(rota.ToLower());
            requisicaoWeb.Method = "GET";

            // GetResponse: obtem um objeto com a resposta do servidor
            using (var resposta = requisicaoWeb.GetResponse())
            {
                /** Para que a resposta seja compatível para ser desserializada devemos:
                 * 1 - Obter um stream (fluxo de bytes) a partir dos dados de resposta enviados
                 * pelo servidor: método GetResponseStream()
                 * 2 - Armazenar esta stream como um simples objeto: Classe StreamReader
                 * 3 - Ler a informação deste objeto com método ReadToEnd().
                ***/
                var streamDados = resposta.GetResponseStream();
                StreamReader ler = new StreamReader(streamDados);
                /// ler o Objeto até o final e atribui a o novo objeto
                object objResponse = ler.ReadToEnd();

                List<Persona> persona = JsonConvert.DeserializeObject<List<Persona>>(objResponse.ToString());

                for (int i = 0; i < persona.Count; i++)
                {
                    txtDescricao.Text = Convert.ToString(persona[i].description);
                }
                streamDados.Close();
                resposta.Close();
            }

        }
    }
}
