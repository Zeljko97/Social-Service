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
        #region Zaposleni
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
               string datum1 = zaposlenData["datum_rodjenja"].ToString();
                DateTime datum = DateTime.Parse(datum1);
                int domID = Convert.ToInt32(zaposlenData["domID"]);

                Zaposleni zaposlen = new Zaposleni();

                zaposlen.jmbg = zaposlenData["jmbg"] != null ? zaposlenData["jmbg"].ToString() : string.Empty;
                zaposlen.ime = zaposlenData["ime"] != null ? zaposlenData["ime"].ToString() : string.Empty;
                zaposlen.prezime = zaposlenData["prezime"] != null ? zaposlenData["prezime"].ToString() : string.Empty;
                zaposlen.radni_staz = radni_staz != 0 ? radni_staz : 0;
                zaposlen.radno_mesto = zaposlenData["radno_mesto"] != null ? zaposlenData["radno_mesto"].ToString() : string.Empty;
                zaposlen.datum_rodjenja = datum != null ? datum : DateTime.Now;
                zaposlen.user_name = zaposlenData["user_name"] != null ? zaposlenData["user_name"].ToString() : string.Empty;
                zaposlen.password = zaposlenData["password"] != null ? zaposlenData["password"].ToString() : string.Empty;
                zaposlen.domID = domID != 0 ? domID : 0;

                zaposleni.Add(zaposlen);
                
            }

            return zaposleni;
        }

        //funkcija koja ce vratiti zaposlene odredjenog doma:
        public static List<Zaposleni> getZaposleniDom(int dom)
        {
            ISession session = SessionManager.GetSession();
            List<Zaposleni> zaposleni = new List<Zaposleni>();

            if (session == null)
                return null;

            var zaposleniData = session.Execute("select * from \"zaposleni\"");

            foreach (var zaposlenData in zaposleniData)
            {
                int domID = Convert.ToInt32(zaposlenData["domID"]);
                if (domID == dom)
                {
                    int radni_staz = Convert.ToInt32(zaposlenData["radni_staz"]);
                    string datum1 = zaposlenData["datum_rodjenja"].ToString();
                    DateTime datum = DateTime.Parse(datum1);
                    Zaposleni zaposlen = new Zaposleni();
                    zaposlen.jmbg = zaposlenData["jmbg"] != null ? zaposlenData["jmbg"].ToString() : string.Empty;
                    zaposlen.ime = zaposlenData["ime"] != null ? zaposlenData["ime"].ToString() : string.Empty;
                    zaposlen.prezime = zaposlenData["prezime"] != null ? zaposlenData["prezime"].ToString() : string.Empty;
                    zaposlen.radni_staz = radni_staz != 0 ? radni_staz : 0;
                    zaposlen.radno_mesto = zaposlenData["radno_mesto"] != null ? zaposlenData["radno_mesto"].ToString() : string.Empty;
                    zaposlen.datum_rodjenja = datum != null ? datum : DateTime.Now;
                    zaposlen.user_name = zaposlenData["user_name"] != null ? zaposlenData["user_name"].ToString() : string.Empty;
                    zaposlen.password = zaposlenData["password"] != null ? zaposlenData["password"].ToString() : string.Empty;
                    zaposlen.domID = domID != 0 ? domID : 0;
                    zaposleni.Add(zaposlen);
                }
            }
            return zaposleni;
        }

           public static Zaposleni GetZaposlen(string ime, string prezime)
            {
                ISession session = SessionManager.GetSession();
                Zaposleni zaposlen = new Zaposleni();

                if (session == null)
                    return null;
                Row zaposleniData = session.Execute("select * from \"zaposleni\" where \"ime\"='" + ime + "' and \"prezime\" ='" + prezime + "'").FirstOrDefault();


                foreach (var zaposlenData in zaposleniData)
                {
                    int radni_staz = Convert.ToInt32(zaposleniData["radni_staz"]);
                    string datum1 = zaposleniData["datum_rodjenja"].ToString();
                    DateTime datum = DateTime.Parse(datum1);

                    int domID = Convert.ToInt32(zaposleniData["domID"]);

                   //Zaposleni zaposlen = new Zaposleni();



                    zaposlen.jmbg = zaposleniData["jmbg"] != null ? zaposleniData["jmbg"].ToString() : string.Empty;
                    zaposlen.ime = zaposleniData["ime"] != null ? zaposleniData["ime"].ToString() : string.Empty;
                    zaposlen.prezime = zaposleniData["prezime"] != null ? zaposleniData["prezime"].ToString() : string.Empty;
                    zaposlen.radni_staz = radni_staz != 0 ? radni_staz : 0;
                    zaposlen.radno_mesto = zaposleniData["radno_mesto"] != null ? zaposleniData["radno_mesto"].ToString() : string.Empty;
                    zaposlen.datum_rodjenja = datum != null ? datum : DateTime.Now;
                    zaposlen.user_name = zaposleniData["user_name"] != null ? zaposleniData["user_name"].ToString() : string.Empty;
                    zaposlen.password = zaposleniData["password"] != null ? zaposleniData["password"].ToString() : string.Empty;
                    zaposlen.domID = domID != 0 ? domID : 0;
                    //zaposleni.Add(zaposlen);
                }


                return zaposlen;
            }
            

      /*  public static Zaposleni GetZaposlen(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            List<Zaposleni> zaposleni = new List<Zaposleni>();

            if (session == null)
                return null;

          //  Row zaposlenData = session.Execute("select * from \"zaposleni\" where \"ime\"='" + ime +"' and \"prezime\" ='" + prezime +"'").FirstOrDefault();

            zaposleni = DataProvider.GetZaposleni();

            Zaposleni zaposlen = new Zaposleni();
            
            for(int i = 0;i<zaposleni.Count;i++)
            {
                if (zaposleni[i].ime == ime && zaposleni[i].prezime == prezime)
                    zaposlen = zaposleni[i];
            }

            return zaposlen;

        }*/

        public static void AddZaposlen(string jmbg, string ime, string prezime, int radni_staz,string datum_rodjenja,string radno_mesto, int domID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet zaposlenData = session.Execute("insert into \"zaposleni\" (jmbg,ime,prezime,radni_staz,datum_rodjenja,radno_mesto,\"domID\") values ('" + jmbg + "', '" + ime + "', '" + prezime + "', " + radni_staz + ",  '" + datum_rodjenja + "', '" + radno_mesto + "'," + domID + ")");
          
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

            RowSet row = session.Execute("update \"zaposleni\" set user_name = '" + ussername + "', password = '" + password + "' where ime = '" + ime + "' and prezime = '" + prezime + "' and radni_staz= " + radni_staz);
        }
        //Update za Korisnicko ime i password samo,bez radnog staza!
        public static void UpdateZaposlenUsernamePW(string ime, string prezime, string ussername, string password)
        {
            ISession session = SessionManager.GetSession();
            Zaposleni zaposlen = new Zaposleni();

            if (session == null)
                return;

            RowSet row = session.Execute("update \"zaposleni\" set user_name = '" + ussername + "', password = '" + password + "' where ime = '" + ime + "' and prezime = '" + prezime +"'");
        }

        //za promenu svih informacija,ako hoces da imamo:
        public static void UpdateZaposlenAll(string ime, string prezime,string jmbg,string datum_rodjenja, int radni_staz, string radno_mesto)
        {
            ISession session = SessionManager.GetSession();
            Zaposleni zaposlen = new Zaposleni();
            if (session == null)
                return;
          //  RowSet row = session.Execute("update \"zaposleni\" set ime = '" + ime + "', prezime = '" + prezime + "', jmbg = '" + jmbg + "', datum_rodjenja = '" + datum_rodjenja + "', radni_staz = " + radni_staz + ", radno_mesto = '" + radno_mesto + "' where ime = '" + ime + "' and prezime = '" + prezime + "' and radni_staz = " + radni_staz);
            RowSet row = session.Execute("update \"zaposleni\" set jmbg = '" + jmbg + "', datum_rodjenja = '" + datum_rodjenja + "', radno_mesto = '" + radno_mesto + "' where ime = '" + ime + "' and prezime = '" + prezime + "' and radni_staz = " + radni_staz + "");
        }
        //dodato
        public static int ZaposleniIdDoma(string ime, string prezime)

        {
            Zaposleni z = new Zaposleni();
            z = GetZaposlen(ime, prezime);
            if (z != null)
            {
                return z.domID;
            }
            else
                return 0;
        }
        #endregion
        #region Izvestaji
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

                string datum1 = izvestajData["datum"].ToString();
                DateTime datum = DateTime.Parse(datum1);


                Izvestaj izvestaj = new Izvestaj();
              //  izvestaj.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;
                izvestaj.aktivnost = izvestajData["aktivnost"] != null ? izvestajData["aktivnost"].ToString() : string.Empty;
                izvestaj.datum = datum != null ? datum : DateTime.Now;
                izvestaj.reg_broj = reg_broj != 0 ? reg_broj : 0;

                izvestaji.Add(izvestaj);
            }

            return izvestaji;
        }
        public static List<Izvestaj> vratiIzvestajeKorisnika(int regBroj)
        {
            ISession session = SessionManager.GetSession();
            List<Izvestaj> izvestaji = new List<Izvestaj>();
            if (session == null)
                return null;
            var izvestajiData = session.Execute("select * from \"izvestaj\"");
            foreach (var izvestajData in izvestajiData)
            {
                int reg_broj = Convert.ToInt32(izvestajData["reg_broj"]);
                if (reg_broj == regBroj)
                {
                    string datum1 = izvestajData["datum"].ToString();
                    DateTime datum = DateTime.Parse(datum1);
                    Izvestaj izvestaj = new Izvestaj();
                    izvestaj.aktivnost = izvestajData["aktivnost"] != null ? izvestajData["aktivnost"].ToString() : string.Empty;
                    izvestaj.datum = datum != null ? datum : DateTime.Now;
                    izvestaj.reg_broj = reg_broj != 0 ? reg_broj : 0;
                    izvestaji.Add(izvestaj);
                }
            }
            return izvestaji;
        }
        public static Izvestaj GetIzvestaj(int regBroj)
        {
            ISession session = SessionManager.GetSession();
            Izvestaj izvestaj = new Izvestaj();

            if (session == null)
                return null;

            Row izvestajiData = session.Execute("select * from \"izvestaj\" where \"reg_broj\"= " + regBroj).FirstOrDefault();

            foreach(var izvestajData in izvestajiData)
            {
                string datum1 = izvestajiData["datum"].ToString();
                DateTime datum = DateTime.Parse(datum1);

                int reg_broj = Convert.ToInt32(izvestajiData["reg_broj"]);

                izvestaj.datum = datum != null ? datum : DateTime.Now;
                izvestaj.aktivnost = izvestajiData["aktivnost"] != null ? izvestajiData["aktivnost"].ToString() : string.Empty;
                izvestaj.reg_broj = reg_broj != 0 ? reg_broj : 0;
            }

            return izvestaj;
         

        }
        public static void AddIzvestaj(string date,string aktivnost, int reg_broj)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet izvestajData = session.Execute("insert into \"izvestaj\" (datum,aktivnost, \"reg_broj\") values ('" + date + "', '" + aktivnost + "', " + reg_broj +")");
        }
        public static void DeleteIzvestaj(int id)
        {
            ISession session = SessionManager.GetSession();
            Izvestaj izvestaj = new Izvestaj();

            if (session == null)
                return;

            RowSet row = session.Execute("delete from \"izvestaj\" where \"izvestaj_id\" = " + id);
        }
        public static void UpdateIzvestaj(string aktivnost, int reg_broj)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet row = session.Execute("update \"izvestaj\" set aktivnost = '" + aktivnost + "' where \"reg_broj\"= " +  reg_broj+ "");
           
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
            //    izvestaj.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;
                //dat
                izvestaj.aktivnost = izvestajData["aktivnost"] != null ? izvestajData["aktivnost"].ToString() : string.Empty;
                izvestaj.reg_broj = reg_broj != 0 ? reg_broj : 0;

                izvestaji.Add(izvestaj);

            }
            return izvestaji;
        }
        #endregion
        #region DOM
        public static List<Dom> GetDomovi()
        {
            ISession session = SessionManager.GetSession();
            List<Dom> domovi = new List<Dom>();

            if (session == null)
                return null;

            var domoviData = session.Execute("select * from \"dom\"");

            foreach(var domData in domoviData)
            {
                int domid = Convert.ToInt32(domData["domID"]);
                int kapacitet = Convert.ToInt32(domData["kapacitet"]);
                int spratnost = Convert.ToInt32(domData["spratnost"]);
                int zauzeto = Convert.ToInt32(domData["zauzeto"]);

                Dom dom = new Dom();

                dom.domID = domid != 0 ? domid : 0;
                dom.naziv = domData["naziv"] != null ? domData["naziv"].ToString() : string.Empty;
                dom.adresa = domData["adresa"] != null ? domData["adresa"].ToString() : string.Empty;
                dom.kapacitet = kapacitet != 0 ? kapacitet : 0;
                dom.spratnost = spratnost != 0 ? spratnost : 0;
                dom.zauzeto = zauzeto != 0 ? zauzeto : 0;



                domovi.Add(dom);
            }

            return domovi;
        }
        public static Dom GetDom(string naziv)
        {
            ISession session = SessionManager.GetSession();
            Dom dom = new Dom();

            if (session == null)
                return null;

            Row domData = session.Execute("select * from \"dom\" where naziv = '" + naziv + "'").FirstOrDefault();

            if(domData != null)
            {
                int domid = Convert.ToInt32(domData["domID"]);
                int kapacitet = Convert.ToInt32(domData["kapacitet"]);
                int spratnost = Convert.ToInt32(domData["spratnost"]);
                int zauzeto = Convert.ToInt32(domData["zauzeto"]);

             //   Dom dom = new Dom();

                dom.domID = domid != 0 ? domid : 0;
                dom.naziv = domData["naziv"] != null ? domData["naziv"].ToString() : string.Empty;
                dom.adresa = domData["adresa"] != null ? domData["adresa"].ToString() : string.Empty;
                dom.kapacitet = kapacitet != 0 ? kapacitet : 0;
                dom.spratnost = spratnost != 0 ? spratnost : 0;
                dom.zauzeto = zauzeto != 0 ? zauzeto : 0;



                //domovi.Add(dom);
            }

            return dom;
        }

        public static void AddDom(int domID, string naziv, string adresa, int spratnost, int kapacitet, int zauzeto)
        {
            ISession session = SessionManager.GetSession();

            if(session == null)
                return;

            RowSet domData = session.Execute("insert into \"dom\" (\"domID\", naziv, adresa, spratnost, kapacitet, zauzeto) values (" + domID + ", '" + naziv + "', '" + adresa + "', " + spratnost + ", " + kapacitet + ", " + zauzeto + ")");
        }

        public static void DeleteDom(string naziv, int domID)
        {
            ISession session = SessionManager.GetSession();
            Dom dom = new Dom();

            if (session == null)
                return;

            RowSet row = session.Execute("delete from \"dom\" where \"naziv\" = '" + naziv + "' and \"domID\" = " + domID + "");

        }

        public static void UpdateDom(string naziv,int domID, int kapacitet, int zauzeto, int spratnost, string adresa)
        {
            ISession session = SessionManager.GetSession();
            Dom dom = new Dom();

            if (session == null)
                return;

            RowSet row = session.Execute("update \"dom\" set kapacitet = " + kapacitet + ", zauzeto= " +  zauzeto + ", spratnost = " + spratnost + ", adresa = '" + adresa + "' where naziv = '" + naziv + "' and \"domID\" = " + domID);

        }

        //za povecavanje zauzetosti:
        public static void ZauzetoIncrement(string naziv, int domID,int zauzeto)
        {
            ISession session = SessionManager.GetSession();
            Dom dom = new Dom();

            if (session == null)
                return;

            RowSet row = session.Execute("update \"dom\" set  zauzeto = " + zauzeto + " where naziv = '" + naziv + "' and \"domID\" = " + domID);
            //a ovo radi u bazi:       update dom set zauzeto=6 where naziv='Dom za stare' and "domID"=1; 
        }


        //neophodno za stampanje informacija o domu: Ali nije moguce da vrati!
        public static Dom GetDomID(int domID)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            var domoviData = session.Execute("select * from \"dom\"");

            Dom dom = new Dom();
            foreach (var domData in domoviData)
            {
                int domid = Convert.ToInt32(domData["domID"]);
                if (domid== domID)
                {
                    int kapacitet = Convert.ToInt32(domData["kapacitet"]);
                    int spratnost = Convert.ToInt32(domData["spratnost"]);
                    int zauzeto = Convert.ToInt32(domData["zauzeto"]);

                    dom.domID = domid != 0 ? domid : 0;
                    dom.naziv = domData["naziv"] != null ? domData["naziv"].ToString() : string.Empty;
                    dom.adresa = domData["adresa"] != null ? domData["adresa"].ToString() : string.Empty;
                    dom.kapacitet = kapacitet != 0 ? kapacitet : 0;
                    dom.spratnost = spratnost != 0 ? spratnost : 0;
                    dom.zauzeto = zauzeto != 0 ? zauzeto : 0;
                    return dom;
                }
            }
            return null;
        }

        #endregion

        #region Korisnik
        public static List<Korisnik> getKorisnici()
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();

            if (session == null)
                return null;

            var korisniciData = session.Execute("select * from \"korisnik\"");

            foreach(var korisnikData in korisniciData)
            {
                int reg_broj = Convert.ToInt32(korisnikData["reg_broj"]);
                //int licna_primanja = Convert.ToInt32(korisnikData["licna_primanja"]);
                int domID = Convert.ToInt32(korisnikData["domID"]);
                // int izvestaj_id = Convert.ToInt32(korisnikData["izvestaj_id"]);
                bool stanje = Convert.ToBoolean(korisnikData["stanje"]);
                string datum1 = korisnikData["datum_rodjenja"].ToString();
                DateTime datum = DateTime.Parse(datum1);

                Korisnik korisnik = new Korisnik();
                korisnik.reg_broj = reg_broj != 0 ? reg_broj : 0;
                korisnik.jmbg = korisnikData["jmbg"] != null ? korisnikData["jmbg"].ToString() : string.Empty;
                korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                korisnik.datum_rodjenja = datum != null ? datum : DateTime.Now;
                korisnik.pol = korisnikData["pol"] != null ? korisnikData["pol"].ToString() : string.Empty;
                korisnik.starosna_odredba = korisnikData["starosna_odredba"] != null ? korisnikData["starosna_odredba"].ToString() : string.Empty;
                korisnik.licna_primanja = korisnikData["licna_primanja"] != null ? korisnikData["licna_primanja"].ToString() : string.Empty;
                korisnik.br_zdravstvene_knjizice = korisnikData["br_zdravstvene_knjizice"] != null ? korisnikData["br_zdravstvene_knjizice"].ToString() : string.Empty;
                korisnik.zdravstveno_stanje = korisnikData["zdravstveno_stanje"] != null ? korisnikData["zdravstveno_stanje"].ToString() : string.Empty;
                korisnik.pokretljivost = korisnikData["pokretljivost"] != null ? korisnikData["pokretljivost"].ToString() : string.Empty;
                korisnik.lekovi = korisnikData["lekovi"] != null ? korisnikData["lekovi"].ToString() : string.Empty;
                korisnik.podnosilac_zahteva = korisnikData["podnosilac_zahteva"] != null ? korisnikData["podnosilac_zahteva"].ToString() : string.Empty;
                korisnik.domID = domID != 0 ? domID : 0;
                korisnik.stanje = korisnikData["stanje"] != null ? stanje : false;
              //  korisnik.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;

                korisnici.Add(korisnik);


            }
            return korisnici;

        }
        //nova 
        public static List<Korisnik> getKorisniciDomaAktivnost(int dom,bool s) // true je za aktivne,false je za pasivne korisnike
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();

            if (session == null)
                return null;
            var korisniciData = session.Execute("select * from \"korisnik\"");
            foreach (var korisnikData in korisniciData)
            {
                int domID = Convert.ToInt32(korisnikData["domID"]);
                bool stanje = Convert.ToBoolean(korisnikData["stanje"]);
                if (domID == dom && stanje == s)
                {
                    int reg_broj = Convert.ToInt32(korisnikData["reg_broj"]);

                    string datum1 = korisnikData["datum_rodjenja"].ToString();
                    DateTime datum = DateTime.Parse(datum1);

                    Korisnik korisnik = new Korisnik();
                    korisnik.reg_broj = reg_broj != 0 ? reg_broj : 0;
                    korisnik.jmbg = korisnikData["jmbg"] != null ? korisnikData["jmbg"].ToString() : string.Empty;
                    korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                    korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                    korisnik.datum_rodjenja = datum != null ? datum : DateTime.Now;
                    korisnik.pol = korisnikData["pol"] != null ? korisnikData["pol"].ToString() : string.Empty;
                    korisnik.starosna_odredba = korisnikData["starosna_odredba"] != null ? korisnikData["starosna_odredba"].ToString() : string.Empty;
                    korisnik.licna_primanja = korisnikData["licna_primanja"] != null ? korisnikData["licna_primanja"].ToString() : string.Empty;
                    korisnik.br_zdravstvene_knjizice = korisnikData["br_zdravstvene_knjizice"] != null ? korisnikData["br_zdravstvene_knjizice"].ToString() : string.Empty;
                    korisnik.zdravstveno_stanje = korisnikData["zdravstveno_stanje"] != null ? korisnikData["zdravstveno_stanje"].ToString() : string.Empty;
                    korisnik.pokretljivost = korisnikData["pokretljivost"] != null ? korisnikData["pokretljivost"].ToString() : string.Empty;
                    korisnik.lekovi = korisnikData["lekovi"] != null ? korisnikData["lekovi"].ToString() : string.Empty;
                    korisnik.podnosilac_zahteva = korisnikData["podnosilac_zahteva"] != null ? korisnikData["podnosilac_zahteva"].ToString() : string.Empty;
                    korisnik.domID = domID != 0 ? domID : 0;
                    korisnik.stanje = korisnikData["stanje"] != null ? stanje : false;

                    korisnici.Add(korisnik);
                }
            }
            return korisnici;

        }
        public static Korisnik GetKorisnikDoma(string ime, string prezime, int domID) // funkcija koja nam pomaze da nadjemo korisnika odredjenog doma na osnovu imena i prezimena
        {
            ISession session = SessionManager.GetSession();
            Korisnik korisnik = new Korisnik();

            if (session == null)
                return null;

            var korisniciData = session.Execute("select * from \"korisnik\" where ime = '" + ime + "' and prezime = '" + prezime + "'");

            foreach (var korisnikData in korisniciData)
            {
                int ID = Convert.ToInt32(korisnikData["domID"]);
                if (ID==domID)
                {
                    int reg_broj = Convert.ToInt32(korisnikData["reg_broj"]);
                    //int licna_primanja = Convert.ToInt32(korisnikData["licna_primanja"]);

                    //  int izvestaj_id = Convert.ToInt32(korisnikData["izvestaj_id"]);
                    bool stanje = Convert.ToBoolean(korisnikData["stanje"]);
                    string datum1 = korisnikData["datum_rodjenja"].ToString();
                    DateTime datum = DateTime.Parse(datum1);

                    // Korisnik korisnik = new Korisnik();
                    korisnik.reg_broj = reg_broj != 0 ? reg_broj : 0;
                    korisnik.jmbg = korisnikData["jmbg"] != null ? korisnikData["jmbg"].ToString() : string.Empty;
                    korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                    korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                    korisnik.datum_rodjenja = datum != null ? datum : DateTime.Now;
                    korisnik.pol = korisnikData["pol"] != null ? korisnikData["pol"].ToString() : string.Empty;
                    korisnik.starosna_odredba = korisnikData["starosna_odredba"] != null ? korisnikData["starosna_odredba"].ToString() : string.Empty;
                    korisnik.licna_primanja = korisnikData["licna_primanja"] != null ? korisnikData["licna_primanja"].ToString() : string.Empty;
                    korisnik.br_zdravstvene_knjizice = korisnikData["br_zdravstvene_knjizice"] != null ? korisnikData["br_zdravstvene_knjizice"].ToString() : string.Empty;
                    korisnik.zdravstveno_stanje = korisnikData["zdravstveno_stanje"] != null ? korisnikData["zdravstveno_stanje"].ToString() : string.Empty;
                    korisnik.pokretljivost = korisnikData["pokretljivost"] != null ? korisnikData["pokretljivost"].ToString() : string.Empty;
                    korisnik.lekovi = korisnikData["lekovi"] != null ? korisnikData["lekovi"].ToString() : string.Empty;
                    korisnik.podnosilac_zahteva = korisnikData["podnosilac_zahteva"] != null ? korisnikData["podnosilac_zahteva"].ToString() : string.Empty;
                    korisnik.domID = domID != 0 ? domID : 0;
                    korisnik.stanje = korisnikData["stanje"] != null ? stanje : false;
                }
            }
            return korisnik;
        }
        public static Korisnik GetKorisnik(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            Korisnik korisnik = new Korisnik();

            if (session == null)
                return null;

            var korisniciData = session.Execute("select * from \"korisnik\" where ime = '" + ime + "' and prezime = '" + prezime + "'");

            foreach (var korisnikData in korisniciData)
            {
                int reg_broj = Convert.ToInt32(korisnikData["reg_broj"]);
                //int licna_primanja = Convert.ToInt32(korisnikData["licna_primanja"]);
                int domID = Convert.ToInt32(korisnikData["domID"]);
                //  int izvestaj_id = Convert.ToInt32(korisnikData["izvestaj_id"]);
                bool stanje = Convert.ToBoolean(korisnikData["stanje"]);
                string datum1 = korisnikData["datum_rodjenja"].ToString();
                DateTime datum = DateTime.Parse(datum1);

               // Korisnik korisnik = new Korisnik();
                korisnik.reg_broj = reg_broj != 0 ? reg_broj : 0;
                korisnik.jmbg = korisnikData["jmbg"] != null ? korisnikData["jmbg"].ToString() : string.Empty;
                korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                korisnik.datum_rodjenja = datum != null ? datum : DateTime.Now;
                korisnik.pol = korisnikData["pol"] != null ? korisnikData["pol"].ToString() : string.Empty;
                korisnik.starosna_odredba = korisnikData["starosna_odredba"] != null ? korisnikData["starosna_odredba"].ToString() : string.Empty;
                korisnik.licna_primanja = korisnikData["licna_primanja"] != null ? korisnikData["licna_primanja"].ToString() : string.Empty;
                korisnik.br_zdravstvene_knjizice = korisnikData["br_zdravstvene_knjizice"] != null ? korisnikData["br_zdravstvene_knjizice"].ToString() : string.Empty;
                korisnik.zdravstveno_stanje = korisnikData["zdravstveno_stanje"] != null ? korisnikData["zdravstveno_stanje"].ToString() : string.Empty;
                korisnik.pokretljivost = korisnikData["pokretljivost"] != null ? korisnikData["pokretljivost"].ToString() : string.Empty;
                korisnik.lekovi = korisnikData["lekovi"] != null ? korisnikData["lekovi"].ToString() : string.Empty;
                korisnik.podnosilac_zahteva = korisnikData["podnosilac_zahteva"] != null ? korisnikData["podnosilac_zahteva"].ToString() : string.Empty;
                korisnik.domID = domID != 0 ? domID : 0;
                korisnik.stanje = korisnikData["stanje"] != null ? stanje : false;
                // korisnik.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;

                // korisnici.Add(korisnik);


            }
            return korisnik;


           /* ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();

            if (session == null)
                return null;
            korisnici = DataProvider.getKorisnici();
            Korisnik korisnik = new Korisnik();
            for (int i = 0; i <korisnici.Count; i++)
            {
                if (korisnici[i].ime == ime && korisnici[i].prezime == prezime)
                    korisnik = korisnici[i];
            }
            return korisnik;*/
        }
        public static void AddKorisnik(int reg_broj, string jmbg, string ime, string prezime, string datum, string pol,
            string starosna_odredba, string licna_primanja, string br_zdravstvene, string zdravstveno_stanje, string pokretljivost,
            string lekovi, string podnosilac,int domID,bool stanje)
        {
            ISession session = SessionManager.GetSession();
            if(session == null)
                return;
            RowSet row =session.Execute("insert into \"korisnik\" (reg_broj,jmbg,ime,prezime,datum_rodjenja,pol,starosna_odredba,licna_primanja,br_zdravstvene_knjizice,zdravstveno_stanje,pokretljivost,lekovi,podnosilac_zahteva,\"domID\",stanje) values (" + reg_broj + ", '" + jmbg + "', '" + ime + "', '" + prezime + "', '" + datum + "', '" + pol + "', '" + starosna_odredba + "', '" + licna_primanja + "', '" + br_zdravstvene + "', '" + zdravstveno_stanje + "', '" + pokretljivost + "', '" + lekovi + "', '" + podnosilac + "', " + domID + ", " + stanje + ")");
        }
        //funkcija koja ce vratiti korisnike odredjenog doma:
        public static List<Korisnik> VratiKorisnikeDoma(int dom)
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();

            if (session == null)
                return null;

            var korisniciData = session.Execute("select * from \"korisnik\"");

            foreach (var korisnikData in korisniciData)
            {
                int domID = Convert.ToInt32(korisnikData["domID"]);
                if (domID == dom)
                {
                    int reg_broj = Convert.ToInt32(korisnikData["reg_broj"]);
                    //int licna_primanja = Convert.ToInt32(korisnikData["licna_primanja"]);
                    bool stanje = Convert.ToBoolean(korisnikData["stanje"]);
                    int izvestaj_id = Convert.ToInt32(korisnikData["izvestaj_id"]);
                    string datum1 = korisnikData["datum_rodjenja"].ToString();
                    DateTime datum = DateTime.Parse(datum1);

                    Korisnik korisnik = new Korisnik();
                    korisnik.reg_broj = reg_broj != 0 ? reg_broj : 0;
                    korisnik.jmbg = korisnikData["jmbg"] != null ? korisnikData["jmbg"].ToString() : string.Empty;
                    korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                    korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                    korisnik.datum_rodjenja = datum != null ? datum : DateTime.Now;
                    korisnik.pol = korisnikData["pol"] != null ? korisnikData["pol"].ToString() : string.Empty;
                    korisnik.starosna_odredba = korisnikData["starosna_odredba"] != null ? korisnikData["starosna_odredba"].ToString() : string.Empty;
                    korisnik.licna_primanja = korisnikData["licna_primanja"] != null ? korisnikData["licna_primanja"].ToString() : string.Empty;
                    korisnik.br_zdravstvene_knjizice = korisnikData["br_zdravstvene_knjizice"] != null ? korisnikData["br_zdravstvene_knjizice"].ToString() : string.Empty;
                    korisnik.zdravstveno_stanje = korisnikData["zdravstveno_stanje"] != null ? korisnikData["zdravstveno_stanje"].ToString() : string.Empty;
                    korisnik.pokretljivost = korisnikData["pokretljivost"] != null ? korisnikData["pokretljivost"].ToString() : string.Empty;
                    korisnik.lekovi = korisnikData["lekovi"] != null ? korisnikData["lekovi"].ToString() : string.Empty;
                    korisnik.podnosilac_zahteva = korisnikData["podnosilac_zahteva"] != null ? korisnikData["podnosilac_zahteva"].ToString() : string.Empty;
                    korisnik.domID = domID != 0 ? domID : 0;
                    korisnik.stanje = korisnikData["stanje"] != null ? stanje : false;
                    // korisnik.izvestaj_id = izvestaj_id != 0 ? izvestaj_id : 0;

                    korisnici.Add(korisnik);
                }

            }
            return korisnici;
        }

        public static void DeleteKorisnik(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            
            if (session == null)
                return;
            //promenjeno u bazi na regBroj?
            RowSet row = session.Execute("delete from \"korisnik\" where ime = '" + ime + "' and prezime = '" + prezime + "'");
           // RowSet row = session.Execute("delete from \"korisnik\" where \"reg_broj\" = " + regBroj); //+ " and ime = '" + ime + "' and prezime = '" + prezime + "'");
        }

        //mora postojati update,posto korisnike nikada ne brisemo!
        public static void UpdateKorisnik(string ime, string prezime, bool stanje)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("update \"korisnik\" set stanje = " + stanje + " where ime = '" + ime + "' and prezime = '" + prezime + "'");
        }
        public static void UpdateKorisnik(string ime, string prezime, string zdravstveno_stanje, string lekovi)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("update \"korisnik\" set zdravstveno_stanje = '" + zdravstveno_stanje + "', lekovi = '"+ lekovi+"' where ime = '" + ime + "' and prezime = '" + prezime + "'");
        }
        #endregion

        #region Validacije
        public static bool CheckNameZaposleni(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            Zaposleni zaposlen = new Zaposleni();

          

            List<Zaposleni> lista = new List<Zaposleni>();
            lista = GetZaposleni();

            Zaposleni radnik = new Zaposleni();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ime == ime && lista[i].prezime == prezime)
                {
                    radnik = lista[i];
                    return true;
                }
            }

            return false;
        }
        public static bool CheckUserNameDirektor(string userName, string password)
        {

            List<Direktor> lista = new List<Direktor>();
            lista = DataProvider.GetDirektori();

            Direktor direktor = new Direktor();
            for(int i = 0;i<lista.Count;i++)
            {
                if(lista[i].user_name == userName && lista[i].password == password)
                {
                    direktor = lista[i];
                    return true;
                }
            }

            return false;

           
        }
        public static bool CheckUserNameZaposleni(string userName, string password)
        {
          
           
           
            List<Zaposleni> lista = new List<Zaposleni>();
            lista = GetZaposleni();

            Zaposleni radnik = new Zaposleni();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].user_name == userName && lista[i].password == password)
                {
                    radnik = lista[i];
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Direktor
        //neophodno je imati uvid i u direktore domova.
        public static List<Direktor> GetDirektori() // nece se bas koristiti cesto.
        {
            ISession session = SessionManager.GetSession();
            List<Direktor> direktori = new List<Direktor>();

            if (session == null)
                return null;

            var direktoriData = session.Execute("select * from \"direktor\"");


            foreach (var direktorData in direktoriData)
            {
               // int id = Convert.ToInt32(direktorData["id"]); // ucitamo id
                int domID = Convert.ToInt32(direktorData["domID"]); // id doma

                Direktor direktor = new Direktor();

                //ucitavanje:
                direktor.ime = direktorData["ime"] != null ? direktorData["ime"].ToString() : string.Empty;
                direktor.prezime = direktorData["prezime"] != null ? direktorData["prezime"].ToString() : string.Empty;
               // direktor.id = id != 0 ? id : 0;
                direktor.user_name = direktorData["user_name"] != null ? direktorData["user_name"].ToString() : string.Empty;
                direktor.password = direktorData["password"] != null ? direktorData["password"].ToString() : string.Empty;
                direktor.domID = domID != 0 ? domID : 0;

                direktori.Add(direktor);
            }

            return direktori;
        }
        public static Direktor GetDirektor(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            Direktor direktor = new Direktor();

            if (session == null)
                return null;

            //var direktoriData = session.Execute("select * from \"direktor\" where username = '" + username + "'");
            Row direktorData = session.Execute("select * from \"direktor\" where ime = '" + ime + "' and prezime = '" + prezime + "'").FirstOrDefault();

            if(direktorData != null)
            {
                int id = Convert.ToInt32(direktorData["id"]); // ucitamo id
                int domID = Convert.ToInt32(direktorData["domID"]); // id doma

             //   Direktor direktor = new Direktor();
                //ucitavanje:
                direktor.ime = direktorData["ime"] != null ? direktorData["ime"].ToString() : string.Empty;
                direktor.prezime = direktorData["prezime"] != null ? direktorData["prezime"].ToString() : string.Empty;
                direktor.id = id != 0 ? id : 0;
                direktor.user_name = direktorData["user_name"] != null ? direktorData["user_name"].ToString() : string.Empty;
                direktor.password = direktorData["password"] != null ? direktorData["password"].ToString() : string.Empty;
                direktor.domID = domID != 0 ? domID : 0;

               // direktori.Add(direktor);
            }

            return direktor;
        }

        public static void AddDirektor(int id,string ime, string prezime, int domID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet direktorData = session.Execute("insert into \"direktor\" (id,ime, prezime,\"domID\") values (" +id+", '" + ime + "', '" + prezime + "', " + domID + ")");
        }

        public static void UpdateDirektor(string ime, string prezime, string user_name, string password)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet direktorData = session.Execute("update \"direktor\" set user_name = '" + user_name + "', password = '" + password + "' where ime = '" + ime + "' and prezime = '" + prezime + "'");
        }

        public static int DirektorIdDoma(string ime, string prezime)
        
        {
            Direktor d = new Direktor();
            d = GetDirektor(ime, prezime);
            if (d != null)
            {
                return d.domID;
            }
            else
                return 0;
        }

        #endregion

        #region DodatneFUnkcije

        #endregion
    }
}
