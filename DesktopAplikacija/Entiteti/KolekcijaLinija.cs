using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija.Entiteti
{
    class KolekcijaLinija
    {
        private List<DAL.Entiteti.Linija> linije;
        private static KolekcijaLinija instanca = null;

        public static KolekcijaLinija Instanca
        {
            get { return (KolekcijaLinija.instanca==null)? new KolekcijaLinija(): instanca; }
        }

        public List<DAL.Entiteti.Linija> Linije
        {
            get { return linije; }
            set { linije = value; }
        }

        private KolekcijaLinija()
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            DAL.DAL.LinijaDAO ld = d.getDAO.getLinijaDAO();
            linije = ld.GetAll();
            d.terminirajKonekciju();
        }
    }
}
