using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialServiceDataLayer.QueryEntities
{
    public class Zaposleni
    {
        public string jmbg { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string radno_mesto { get; set; }
        public int radni_staz { get; set; }
        public DateTime datum_rodjenja { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public int domID { get; set; }
    }
}
