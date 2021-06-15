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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            var assistente = new AssistenteJson();
            assistente.Campo1 = textCampo1.Text;
            assistente.Campo2 = textCampo2.Text;
            assistente.Campo3 = textCampo3.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter(@"\files\arquivo.json"))
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
                MessageBox.Show("Arquivo Salvo");
            }
        }
    }
}
