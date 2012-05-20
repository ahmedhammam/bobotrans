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
            return d.getDAO.getLinijaDAO().getById(sifraLinije).NazivLinije;
        }

        [WebMethod]
        public string dajImeStanice(long sifraStanice)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            return d.getDAO.getStaniceDAO().getById(sifraStanice).ToString();
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
    }
}
