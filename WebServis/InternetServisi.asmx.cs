using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAL;

namespace WebServis
{
    /// <summary>
    /// Summary description for InternetServisi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InternetServisi : System.Web.Services.WebService
    {

        [WebMethod]
        public string dajImeLinije(long sifraLinije)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            try
            {
                return d.getDAO.getLinijaDAO().getById(sifraLinije).NazivLinije;
            }
            catch (Exception ex)
            {
                return "__GRESHKA__";
            }
        }

        [WebMethod]
        public string dajImeStanice(long sifraStanice)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            try
            {
                return d.getDAO.getStaniceDAO().getById(sifraStanice).ToString();
            }
            catch (Exception ex)
            {
                return "__GRESHKA__";
            }
        }

        [WebMethod]
        public List<long> dajLinije()
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            List<long> spisak = new List<long>();
            List<DAL.Entiteti.Linija> linije = d.getDAO.getLinijaDAO().GetAll();
            foreach (DAL.Entiteti.Linija linija in linije)
            {
                spisak.Add(linija.SifraLinije);
            }
            return spisak;
        }

        [WebMethod]
        public List<long> dajVoznje(long sifraLinije)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            List<long> spisak = new List<long>();
            DAL.Entiteti.Linija linija = d.getDAO.getLinijaDAO().getById(sifraLinije);
            foreach (DAL.Entiteti.Voznja voznja in linija.Voznje)
            {
                spisak.Add(voznja.SifraVoznje);
            }
            return spisak;
        }

        [WebMethod]
        public string dajPodatkeVoznje(long sifraVoznje)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            return d.getDAO.getVoznjaDAO().getById(sifraVoznje).ToString();
        }

        [WebMethod]
        public List<long> dajLinijeKrozStanicu(long sifraStanice)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            List<long> spisak = new List<long>();
            List<DAL.Entiteti.Linija> linije = d.getDAO.getLinijaDAO().GetAll();
            foreach (DAL.Entiteti.Linija linija in linije)
            {
                bool nasao = false;
                foreach (DAL.Entiteti.Stanica stanica in linija.Stanice)
                {
                    if (stanica.SifraStanice == sifraStanice) nasao=true;
                }
                if (nasao) spisak.Add(linija.SifraLinije);
            }
            return spisak;
        }

        [WebMethod]
        public List<long> dajStaniceULiniji(long sifraLinije)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            List<long> spisak = new List<long>();
            DAL.Entiteti.Linija linija = d.getDAO.getLinijaDAO().getById(sifraLinije);
            foreach (DAL.Entiteti.Stanica stanica in linija.Stanice)
            {
                spisak.Add(stanica.SifraStanice);
            }
            return spisak;
        }

        [WebMethod]
        public List<long> dajStanice()
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            List<long> spisak = new List<long>();
            List<DAL.Entiteti.Stanica> stanice= d.getDAO.getStaniceDAO().GetAll();
            foreach (DAL.Entiteti.Stanica stanica in stanice)
            {
                spisak.Add(stanica.SifraStanice);
            }
            return spisak;
        }

        [WebMethod]
        public string dajNajjeftinijiPut(long sifraPocetneStanice, long sifraKrajnjeStanice)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            DAL.Entiteti.Stanica pocetnaStanica = d.getDAO.getStaniceDAO().getById(sifraPocetneStanice);
            DAL.Entiteti.Stanica krajnjaStanica = d.getDAO.getStaniceDAO().getById(sifraKrajnjeStanice);
            DesktopAplikacija.Entiteti.Put put = DesktopAplikacija.Informisanje.InformisanjeKomande.vratiNajjeftinijiPut(pocetnaStanica,krajnjaStanica);
            return put.ToString().Replace("\n", "; ");
        }

        [WebMethod]
        public List<string> dajVoznjeKrozStanicu(long sifraStanice)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            List<string> spisak = new List<string>();
            List<DAL.Entiteti.Linija> linije = d.getDAO.getLinijaDAO().GetAll();
            foreach (DAL.Entiteti.Linija linija in linije)
            {
                bool nasao = false;
                int pozicija = 0;
                for (int i=0;i<linija.Stanice.Count;i++)
                {
                    if (linija.Stanice[i].SifraStanice == sifraStanice)
                    {
                        nasao = true;
                        pozicija = i;
                    }
                }
                if (nasao)
                {
                    List<DAL.Entiteti.Voznja> voznje = linija.Voznje;
                    foreach (DAL.Entiteti.Voznja voznja in voznje)
                    {
                        string naziv = String.Format("{0}, {1}",linija.NazivLinije, voznja.VrijemePolaska.AddMinutes((double)linija.TrajanjeDoPolaska[pozicija]).ToString("dd.MM.yy, HH:mm:ss"));
                        spisak.Add(naziv);
                    }
                }
            }
            return spisak;
        }
    }
}
