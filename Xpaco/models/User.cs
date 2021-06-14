using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpaco.models
{
 
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public int personaId { get; set; }
        public Profile profile { get; set; }
    }

/***    public class Root
    {
        public List<User> user { get; set; }
    }
*/
}
