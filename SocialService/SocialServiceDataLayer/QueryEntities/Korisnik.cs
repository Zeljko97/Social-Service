using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialServiceDataLayer.QueryEntities
{
    public class Korisnik
    {
        public int reg_broj { get; set; }
        public string jmbg { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datum_rodjenja { get; set; }
        public string pol { get; set; }
        public string starosna_odredba { get; set; }
        public string licna_primanja { get; set; }
        public string br_zdravstvene_knjizice {get; set;}
        public string zdravstveno_stanje { get; set; }
        public string pokretljivost { get; set; }
        public string lekovi { get; set; }
        public string podnosilac_zahteva { get; set; }
        public int domID { get; set; }
        public bool stanje { get; set; }
       // public int izvestaj_id { get; set; }
    }
}
