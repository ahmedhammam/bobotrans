using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija.Entiteti
{
    class KolekcijaKorisnika
    {
        private List<DAL.Entiteti.Korisnik> korisnici;
        private static KolekcijaKorisnika instanca = null;

        public static KolekcijaKorisnika Instanca
        {
            get { return (KolekcijaKorisnika.instanca == null) ? new KolekcijaKorisnika(): instanca; }
        }

        public List<DAL.Entiteti.Korisnik> Korisnici
        {
            get {return korisnici;}
            set {korisnici = value;}
        }

        private KolekcijaKorisnika()
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            DAL.DAL.KorisnikDAO kd = d.getDAO.getKorisnikDAO();
            korisnici = kd.GetAll();
            d.terminirajKonekciju();
        }

        public string getNameByUsername(string username)
        {
            foreach (DAL.Entiteti.Korisnik k in korisnici)
                if (k.Username == username)
                    return k.ImeIPrezime;
            return "";
        }
    }
}