using Xpaco.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;   // WebRequest
using System.IO;    // StreamReader
using System.Windows.Forms; // MessageBox

namespace Xpaco.controllers
{
    class WebRequestAPI
    {
        /// <summary>
        /// METODO QUE RETORNA o objStreamURI DO TIPO System.IO.StreamReader
        /// Utilizando as classes:
        /// System.IO.WebRequest / System.IO.StreamReader / System.Windows.Forms
        /// Importando o namespace XPaco.models
        /// </summary>
        /// <param name="GetLista"></param>
        /// <returns>objStreamURI</returns> Lançado quando
        /// o resultado do retorno for caracteres vazia ("")</exception>

// ??? Vou comentar até saber como usar o token????????????????????????????????????????
        // public static Object GetLista(String rota, String token)

        public static Object GetLista(String rota) 
        {
            // Declarando o Objeto que será o objeto de retorno
            Object objStreamURI = null;

            try
            {
                /// O .NET Framework fornece classes específicas de protocolo
                /// derivadas das classes WebRequest e WebResponse para solicitação a uma URIs 
                /// que começam com http:, https:, ftp: e file:

                /// solicitaURI solicitar dados de um servidor host
                var solicitaURI = WebRequest.CreateHttp(rota.ToLower());
                solicitaURI.Method = "GET";
                /// headers.Add() adiciona ao cabeçalho os parâmetros passados 
// ??? Vou comentar até saber como usar o token????????????????????????????????????????
//                solicitaURI.Headers.Add("Authorization", "Bearer " + token);

                /// Esse método retorna um objeto que contém a resposta do servidor.
                /// O tipo do objeto WebResponse retornado é determinado pelo esquema
                /// do URI da solicitação
                /// TODO  - WebResponse
                var respostaURI = solicitaURI.GetResponse();

                /* Para que a respostaURI esteja compativel para ser deserializada devemos:
                 * 1. Obter um stream (fluxo de bytes) as partir dos dados de respostaURI enviados
                 * 2. Armazenar esta stream como um simples objeto: Classe StreamReade
                 * 3. Ler a informacao deste objeto com metodo ReadToEnd().
                 */

                /// Para obter o fluxo que contém os dados de resposta enviados pelo servidor, 
                /// chame o método GetResponseStream
                var streamURI = respostaURI.GetResponseStream();

                /// StreamReader é projetado para entrada de caracteres em uma codificação
                /// específica. Use StreamReader para ler linhas de informações de um arquivo
                /// de texto padrão.
                /// Agora abra o stream criado usando um StreamReader para acessar seu conteúdo
                StreamReader reader = new StreamReader(streamURI);

                // TODO Lembre-se que o objStreamURI foi declarado fora do try no top da classe
                /// ReadToEnd() ==> Ler todos os caracteres da posição atual até o final.
                /// Se a posição atual estiver no final do fluxo, será retornado uma 
                /// cadeia de caracteres vazia (""). 
                objStreamURI = reader.ReadToEnd();

                // TODO - WebResponse - Quando substituído por uma classe descendente, fecha
                // o fluxo de resposta.
                respostaURI.Close();
                // TODO - Fecha o objeto StreamReader e o fluxo subjacente e libera os recursos
                // do sistema associados ao leitor.
                reader.Close();

                return objStreamURI;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao exportar a lista: " + err.Message);
                return objStreamURI;
            }
        }

        public static Object post(String rota, String json)
        {
            Object objStreamURI = null;

            try
            {
                // Classe WebRequest: Faz uma solicitaçao para um URL
                var solicitaURI = WebRequest.CreateHttp(rota.ToLower());

                solicitaURI.Method = "POST";
            //    solicitaURI.Headers.Add("Authorization", "Bearer " + Token);

                // Método ContentType: Define o tipo do conteudo dos dados que serao enviados
                solicitaURI.ContentType = "application/json; charset=utf-8";

                // Converter caracteres em um array de bytes
                var byteArray = Encoding.UTF8.GetBytes(json);

                // Atributo ContentLength: Define o tamanho do conteúdo dos dados que serão enviados
                solicitaURI.ContentLength = byteArray.Length;

                // Metodo GetRequestStream: retorna um objeto da classe Stream (fluxo de dados)
                // para gravar dados no recurso da internet
                Stream stream = solicitaURI.GetRequestStream();

                /* Método Write: Grava um sequencia de bytes no stream atual e
                 * avança a posição atual dentro do stream até o número de bytes gravados
                 * Parâmetros:
                 * 1º) Array de byte que se deseja gravar
                 * 2º) Deslocamento de bytes no qual será iniciado a cópia de bytes
                 * 3º) Número de bytes que serão gravados
                 */
                stream.Write(byteArray, 0, byteArray.Length);
                stream.Close();


                //GetResponse: obtem um objeto com a respostaURI do servidor
                var respostaURI = solicitaURI.GetResponse();

                /* Para que a respostaURI esteja compativel para ser deserializada devemos:
                 * 1. Obter um stream (fluxo de bytes) as partir dos dados de respostaURI enviados
                 * 2. Armazenar esta stream como um simples objeto: Classe StreamReade
                 * 3. Ler a informacao deste objeto com metodo ReadToEnd().
                 */

                var streamURI = respostaURI.GetResponseStream();
                StreamReader reader = new StreamReader(streamURI);
                objStreamURI = reader.ReadToEnd();

                respostaURI.Close();
                reader.Close();

                return objStreamURI;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao exportar lista: " + err.Message);
                return objStreamURI;
            }
        }

    }
}
