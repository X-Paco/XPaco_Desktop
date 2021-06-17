using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpaco.models
{
    public class Persona

    {
        /// <summary>
        /// Através das propriedades auto-implementadas
        /// podemos fazer a declaração das propriedades
        /// de uma classe de uma maneira mais concisa 
        /// quando nenhuma lógica adicional é necessária
        /// nos assessores (get e set) das propriedades.
        /// </summary>
        /// <param name="Persona"></param>
        /// ------------------------------------------------------------
        /// TODO  - Neste exemplo definimos a propriedade id 
        /// como sendo somente leitura atribuindo o modificador
        /// private ao acessor set:

        public int id { get; set; }
        public string description { get; set; }
        public string oldDescription { get; set; }
    }

}
