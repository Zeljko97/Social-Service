using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cassandra;
using SocialServiceDataLayer.QueryEntities;

namespace SocialServiceDataLayer
{
    public static class DataProvider
    {
        public static List<Zaposleni>  GetZaposleni()
        {
            ISession session = SessionManager.GetSession();
            List<Zaposleni> zaposleni = new List<Zaposleni>();

            if (session == null)
                return null;

            var zaposleniData = session.Execute("select * from \"zaposleni\"");
           

            foreach(var zaposlenData in zaposleniData)
            {
                int radni_staz = Convert.ToInt32(zaposlenData["radni_staz"]);
                DateTime datum = Convert.ToDateTime(zaposlenData["datum_rodjenja"]);
                int domID = Convert.ToInt32(zaposlenData["domID"]);

                Zaposleni zaposlen = new Zaposleni();

                

                zaposlen.jmbg = zaposlenData["jmbg"] != null ? zaposlenData["jmbg"].ToString() : string.Empty;
                zaposlen.ime = zaposlenData["ime"] != null ? zaposlenData["ime"].ToString() : string.Empty;
                zaposlen.prezime = zaposlenData["prezime"] != null ? zaposlenData["prezime"].ToString() : string.Empty;
                zaposlen.radni_staz = radni_staz != 0 ? radni_staz : 0;
                zaposlen.datum_rodjenja = datum != null ? datum.ToLocalTime() : DateTime.Now;
                zaposlen.user_name = zaposlenData["user_name"] != null ? zaposlenData["user_name"].ToString() : string.Empty;
                zaposlen.password = zaposlenData["password"] != null ? zaposlenData["password"].ToString() : string.Empty;
                zaposlen.domID = domID != 0 ? domID : 0;

                zaposleni.Add(zaposlen);
                
            }

            return zaposleni;
        }




        public static List<Zaposleni> GetZaposlen(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            List<Zaposleni> zaposleni = new List<Zaposleni>();

            if (session == null)
                return null;

            Row zaposlenData = session.Execute("select * from \"zaposleni\" where \"ime\"='" + ime +"' and \"prezime\" ='" + prezime +"'").FirstOrDefault();
            

            if(zaposlenData != null)
            {
                int radni_staz = Convert.ToInt32(zaposlenData["radni_staz"]);
                DateTime datum = Convert.ToDateTime(zaposlenData["datum_rodjenja"]);

               // string datum = Convert.ToString(zaposlenData["datum_rodjenja"]);

                int domID = Convert.ToInt32(zaposlenData["domID"]);


                Zaposleni zaposlen = new Zaposleni();


                zaposlen.jmbg = zaposlenData["jmbg"] != null ? zaposlenData["jmbg"].ToString() : string.Empty;
                zaposlen.ime = zaposlenData["ime"] != null ? zaposlenData["ime"].ToString() : string.Empty;
                zaposlen.prezime = zaposlenData["prezime"] != null ? zaposlenData["prezime"].ToString() : string.Empty;
                zaposlen.radni_staz = radni_staz != 0 ? radni_staz : 0;
             //  zaposlen.datum_rodjenja = datum != null ? datum : DateTime.Now;
               // zaposlen.datum_rodjenja = datum != null ? datum.Date : DateTime.Parse("yyyy-mm-dd");
                zaposlen.user_name = zaposlenData["user_name"] != null ? zaposlenData["user_name"].ToString() : string.Empty;
                zaposlen.password = zaposlenData["password"] != null ? zaposlenData["password"].ToString() : string.Empty;
                zaposlen.domID = domID != 0 ? domID : 0;

                zaposleni.Add(zaposlen);
                
            }

            return zaposleni;
        }



        public static void addZaposlen(string jmbg, string ime, string prezime, int radni_staz, int domID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet zaposlenData = session.Execute("insert into \"zaposleni\" (jmbg,ime,prezime,radni_staz,\"domID\") values ('" + jmbg + "', '" + ime + "', '" + prezime + "', " + radni_staz + ",  " + domID + ")");
           // RowSet zaposlenData = session.Execute("insert into \"zaposleni\" (jmbg,ime,prezime,radni_staz,\"domID\") values ('45545644','Jovan','Markovic',3,1)");
        }



        public static void DeleteZaposlen(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            Zaposleni zaposlen = new Zaposleni();

            if (session == null)
                return;

            RowSet row = session.Execute("delete from \"zaposleni\" where \"ime\" = '" + ime + "' and \"prezime\" = '" + prezime + "'");
        }



        public static void UpdateZaposlen(string ime, string prezime, int radni_staz, string ussername, string password)
        {
            ISession session = SessionManager.GetSession();
            Zaposleni zaposlen = new Zaposleni();

            if (session == null)
                return;

            RowSet row = session.Execute("update \"zaposleni\" set user_name = '" + ussername + "', password = '" + password + "' where ime = '" + ime + "' and prezime = '" + prezime + "' and radni_staz = " + radni_staz+ "");
        }


        public static List<Izvestaj> GetIzvestaji()
        {
            ISession session = SessionManager.GetSession();
            List<Izvestaj> izvestaji = new List<Izvestaj>();

            if (session == null)
                return null;

            var izvestajiData = session.Execute("select * from \"izvestaj\"");


            foreach(var izvestajData in izvestajiData)
            {

                int izvestaj_id = Convert.ToInt32(izvestajData["izvestaj_id"]);
                int reg_broj = Convert.ToInt32(izvestajData["reg_broj"]);

                Izvestaj izvestaj = new Izvestaj();
                izvestaj.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;
                //dat
                izvestaj.aktivnost = izvestajData["aktivnost"] != null ? izvestajData["aktivnost"].ToString() : string.Empty;
                izvestaj.reg_broj = reg_broj != 0 ? reg_broj : 0;

                izvestaji.Add(izvestaj);
            }

            return izvestaji;
        }



    



        public static List<Izvestaj> GetIzvestaj(int izvestajId)
        {
            ISession session = SessionManager.GetSession();
            List<Izvestaj> izvestaji = new List<Izvestaj>();

            if (session == null)
                return null;

            var izvestajData = session.Execute("select * from \"izvestaj\" where \"izvestaj_id\" = " + izvestajId + "").FirstOrDefault();


            if(izvestajData != null)
            {
                int izvestaj_id = Convert.ToInt32(izvestajData["izvestaj_id"]);
                int reg_broj = Convert.ToInt32(izvestajData["reg_broj"]);

                Izvestaj izvestaj = new Izvestaj();
                izvestaj.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;
                //dat
                izvestaj.aktivnost = izvestajData["aktivnost"] != null ? izvestajData["aktivnost"].ToString() : string.Empty;
                izvestaj.reg_broj = reg_broj != 0 ? reg_broj : 0;

                izvestaji.Add(izvestaj);
               
            }

            return izvestaji;
        }


        public static void AddIzvestaj(int id,DateTime date,string aktivnost, int reg_broj)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet izvestajData = session.Execute("insert into \"izvestaj\" (\"izvestaj_id\", datum,aktivnost, \"reg_broj\") values (" + id +", " + date + ", '" + aktivnost + "', " + reg_broj +")");
        }

        public static void DeleteIzvestaj(int id)
        {
            ISession session = SessionManager.GetSession();
            Izvestaj izvestaj = new Izvestaj();

            if (session == null)
                return;

            RowSet row = session.Execute("delete from \"izvestaj\" where \"izvestaj_id\" = " + id);
        }


        public static void UpdateIzvestaj(string aktivnost, int izvestaj_id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet row = session.Execute("update \"izvestaj\" set aktivnost = '" + aktivnost + "' where izvestaj_id= " + izvestaj_id + "");

        }

        
        public static List<Izvestaj> FindIzvestaj(int registarski_broj)
        {
            ISession session = SessionManager.GetSession();

            List<Izvestaj> izvestaji = new List<Izvestaj>();

            if (session == null)
                return null;

            var izvestajData = session.Execute("select * from \"izvestaj\" where \"reg_broj\" = " + registarski_broj + "").FirstOrDefault();


            if (izvestajData != null)
            {
                int izvestaj_id = Convert.ToInt32(izvestajData["izvestaj_id"]);
                int reg_broj = Convert.ToInt32(izvestajData["reg_broj"]);

                Izvestaj izvestaj = new Izvestaj();
                izvestaj.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;
                //dat
                izvestaj.aktivnost = izvestajData["aktivnost"] != null ? izvestajData["aktivnost"].ToString() : string.Empty;
                izvestaj.reg_broj = reg_broj != 0 ? reg_broj : 0;

                izvestaji.Add(izvestaj);

            }

            return izvestaji;
        }
     
    }
}
