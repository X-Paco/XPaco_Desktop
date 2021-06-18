using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Newtonsoft.Json;
using Xpaco.models;
using Xpaco.controllers;
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

        /*private void InseriRegistro(string texto)
        {
            // Construir o objeto pelo model
            Media serializa = new Media();

            
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
                
                return;
            }
            finally
            {
                
            }*/
        }

    }

