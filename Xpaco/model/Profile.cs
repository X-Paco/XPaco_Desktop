using System;
using System.Collections.Generic;
using System.Text;

namespace Xpaco.model
{
    public class Profile
    {
        public int id { get; set; }
        public int userId { get; set; }
        public object einItin { get; set; }
        public object codState { get; set; }
        public object phone { get; set; }
        public object num { get; set; }
        public object address { get; set; }
        public object district { get; set; }
        public object city { get; set; }
        public object state { get; set; }
        public object zipCode { get; set; }
        public object photo { get; set; }
        public object birthday { get; set; }
        public User user { get; set; }
    }
}
