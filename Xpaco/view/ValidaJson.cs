using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // StreamWriter
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xpaco.middlewares; // Permite acesso as Classes de namespace diferente

namespace Xpaco.view
{
    public partial class ValidaJson : Form
    {
        public ValidaJson()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {

         /// Gravar arquivo Json 
            var assistente = new AssistenteJson();
            assistente.Campo1 = textCampo1.Text;
            assistente.Campo2 = textCampo2.Text;
            assistente.Campo3 = textCampo3.Text;

            MessageBox.Show(assistente.JsonSerializar(assistente));
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\projetos\repository\Meutix-oficial\XPaco_Desktop\Xpaco\files\arquivo.json"))
                {
                    sw.WriteLine(assistente.JsonSerializar(assistente));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("fim try");
            }
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            try
            {
                var strJson = "";

                using (StreamReader sr = new StreamReader(@"D:\projetos\repository\Meutix-oficial\XPaco_Desktop\Xpaco\files\arquivo.json"))
                {
                    strJson = sr.ReadToEnd();
                }
                var assistente = AssistenteJson.JsonDesserializar(strJson);
                textCampo1.Text = assistente.Campo1;
                textCampo2.Text = assistente.Campo2;
                textCampo3.Text = assistente.Campo3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("fim try");
            }
        }
    }
}

