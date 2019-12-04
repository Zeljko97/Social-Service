using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialServiceDataLayer.QueryEntities
{
    public class Izvestaj
    {
        public int izvestaj_id { get; set; }
        public DateTime datum { get; set; }
        public string aktivnost { get; set; }
        public int reg_broj { get; set; }
        
    }
}
