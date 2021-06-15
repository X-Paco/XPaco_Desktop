using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }
        private void btnVoltarPaginaMidia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarPaginaMidia_Click(object sender, EventArgs e)
        {
            this.Close();
            //Exibir se foi salvo com sucesso ou se algum requisito ficou faltando.
        }

        private void lblPaginaMidia_Click(object sender, EventArgs e)
        {

        }
    }
}
