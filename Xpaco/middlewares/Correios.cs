using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Xpaco.middlewares
{
    using BuscaCEP;
    class Correios
    {
        
        /// <summary>
        ///  configurar método private do BuscaCEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private enderecoERP PesquisarCEP(String cep)
        {
            AtendeClienteClient ws = new AtendeClienteClient();
            var resposta = ws.consultaCEP(cep);
            return resposta;
        }

    }
}
