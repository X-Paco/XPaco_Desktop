using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Xpaco.middlewares
{
    class AssistenteJson
    {
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }

        public string JsonSerializar(AssistenteJson assistenteJson)
        {
            return JsonConvert.SerializeObject(assistenteJson);
        }
        public static AssistenteJson JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<AssistenteJson>(Json);
        }

    }
}
