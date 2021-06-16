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

        }
    }
}
