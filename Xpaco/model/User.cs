using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpaco.model
{
    public class User
    {
        public int id { get; set; }
        public int personaId { get; set; }
        public string passwordHash { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
        public Persona persona { get; set; }
    }
}
