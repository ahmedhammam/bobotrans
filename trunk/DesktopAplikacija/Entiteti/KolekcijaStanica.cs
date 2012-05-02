using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija.Entiteti
{
    class KolekcijaStanica
    {
        List<DAL.Entiteti.Stanica> stanice;
        private static KolekcijaStanica instanca = null;

        internal static KolekcijaStanica Instanca
        {
            get { return (KolekcijaStanica.instanca==null)? new KolekcijaStanica():instanca; }
        }


        public List<DAL.Entiteti.Stanica> Stanice
        {
            get { return stanice; }
            set { stanice = value; }
        }

        private KolekcijaStanica()
        {
            DAL.DAL d = DAL.DAL.Instanca;
            DAL.DAL.StanicaDAO sd = d.getDAO.getStaniceDAO();

            d.kreirajKonekciju();
            stanice = sd.GetAll();
            d.terminirajKonekciju();
        }

        public DAL.Entiteti.Stanica getById(long id)
        {
            foreach (DAL.Entiteti.Stanica s in stanice)
                if (s.SifraStanice == id) return s;

            throw new Exception("Nepostojeca stanica");
        }

        public long dajMaksimalnuSifru()
        {
            long max = 0;
            foreach (DAL.Entiteti.Stanica s in stanice)
                max = (s.SifraStanice > max) ? s.SifraStanice : max;
            return max;
        }
    }
}
