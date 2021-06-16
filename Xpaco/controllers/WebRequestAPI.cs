using Xpaco.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;   // WebRequest
using System.IO;    // StreamReader

namespace Xpaco.controllers
{
    class WebRequestAPI
    {
        /// <summary>
        /// METODO QUE RETORNA o objResposta DO TIPO StreamReader
        /// </summary>
        /// <param name=""></param>
        /// <returns>objResponse</returns>

        public static Object getLista(String rota, String token) 
        {
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
                solicitaURI.Headers.Add("Authorization", "Bearer " + token);

                /// Esse método retorna um objeto que contém a resposta do servidor.
                /// O tipo do objeto WebResponse retornado é determinado pelo esquema
                /// do URI da solicitação
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
                // Lembre-se que o objStreamURI foi criando fora do try no top da classe
                objStreamURI = ReadToEnd();
            }
            catch (Exception err)
            {

            }

            



        }
    }
}
