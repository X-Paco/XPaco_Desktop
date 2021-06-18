using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xpaco
{
    using BuscaCEP;

    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private enderecoERP AchaCEP(string cep)
        {
            AtendeClienteClient ws = new AtendeClienteClient();
            var resposta = ws.consultaCEP(cep);
            return resposta;
        }

        private void btnVoltarPaginaPerfil_Click(object sender, EventArgs e)
        {
            Login cadastro = new Login();
            this.Hide();
            cadastro.Show();
        }

        private void btnSalvarPaginaPerfil_Click(object sender, EventArgs e)
        {
            Campanha novaCampanha = new Campanha();
            this.Hide();
            novaCampanha.Show();
        }

        private void btnLinkPaginaPerfil_Click(object sender, EventArgs e)
        {
            Links pgLinks = new Links();
            pgLinks.Show();
        }

        private void btnConsultarCEP_Click(object sender, EventArgs e)
        {
            enderecoERP end = new enderecoERP();
            string cep = txtbCEP.Text;
            if (!string.IsNullOrEmpty(cep))
            {
                try
                {
                    end = AchaCEP(cep);
                }
                catch (System.ServiceModel.FaultException)
                {
                    MessageBox.Show("CEP não encontrado");
                    txtbCEP.Focus();
                    return;
                }
                finally
                {
                    txtbEndereco.Text = end.end;
                    txtBairro.Text = end.bairro;
                    txtCidade.Text = end.cidade;
                    txtEstado.Text = end.uf;

                }
            }
            else
            {
                MessageBox.Show("CEP é campo obrigatório");
                txtbCEP.Focus();
                return;
            }
        }


    }
}
