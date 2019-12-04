using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialServiceDataLayer.QueryEntities
{
    public class Dom
    {
        public int domID { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public int spratnost { get; set; }
        public int kapacitet { get; set; }
        public int zauzeto { get; set; }
    }
}
