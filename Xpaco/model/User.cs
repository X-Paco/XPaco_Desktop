using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpaco.model
{
    public class User
    {

        /// <summary>
        ///  Nesta classe que será um <em>Modal</em>
        ///  <para>
        ///  Iremos usar <strong>PROPRIEDADES AUTOMÁTICAS</strong> disponíveis apenas no c#
        ///  Os atributos e implementação dos métodos acessores e modificadores
        ///  não serão declarados nem implementados.
        ///  O c# incorpora automáticamente:  
        ///  </para>
        ///  <list type="bullet">
        ///  <item>O tipo de retorno;</item>
        ///  <item>Regra CamelCase do atributo;</item>
        ///  <item>Os métodos (get, void set, [private set - sem acesso externo], ...).</item>
        ///  
        /// </list>
        /// </summary>
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string PasswordHash { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public Persona persona { get; set; }
    }
}
