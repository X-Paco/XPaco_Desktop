using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    public partial class Campanha : Form
    {
        public Campanha()
        {
            InitializeComponent();
        }        

        private void MidiasPaginaCampanha_Click(object sender, EventArgs e)
        {
            Media midias = new Media();            
            midias.Show();
        }

        private void btnMateriaisPaginaCampanha_Click(object sender, EventArgs e)
        {
            Material pgMaterial = new Material();
            pgMaterial.Show();
        }

        private void btnVoltarPaginaCampanha_Click(object sender, EventArgs e)
        {
            Profile pgProfile = new Profile();
            this.Close();
            pgProfile.Show();
        }

        private void btnGravarPaginaCampanha_Click(object sender, EventArgs e)
        {
            Profile pgProfile = new Profile();
            this.Close();
            pgProfile.Show();
        }
    }
}
