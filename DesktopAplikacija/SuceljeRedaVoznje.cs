using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DesktopAplikacija
{
    abstract class SuceljeRedaVoznje
    {
        DAL.DAL d = DAL.DAL.Instanca;
        protected List<DAL.Entiteti.Autobus> autobusi;
        private DesktopAplikacija.Eniteti.KolekcijaLinija kolekcijaLinija = DesktopAplikacija.Eniteti.KolekcijaLinija.Instanca;

        /*public List<DAL.Entiteti.Linija> vratiPolazneLinijeStanice(DAL.Entiteti.Stanica stanica)
        {
            d.kreirajKonekciju();
            DAL.DAL.LinijaDAO ld = d.getDAO.getLinijaDAO();
            List<DAL.Entiteti.Linija> linijeUStanici = ld.vratiLinijeUStanici(stanica);


            foreach (DAL.Entiteti.Linija linija in linijeUStanici)
            {

            }

            return polazneLinije;
        }*/
        

        
    }
}
