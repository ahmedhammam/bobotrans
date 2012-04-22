using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    partial class DAL
    {
        public class DAOFactory
        {
            private static DAOFactory instanca = null;

            public static DAOFactory Instanca
            {
                get { return (instanca==null)? instanca = new DAOFactory() : instanca; }
            }

            private DAOFactory() { }

            public AutobusDAO getAutobusDAO()
            {
                return new AutobusDAO();
            }

            public IzvjestajDAO getIzvjestajDAO()
            {
                return new IzvjestajDAO();
            }

            public KorisnikDAO getKorisnikDAO()
            {
                return new KorisnikDAO();
            }

            public StaniceDAO getStaniceDAO()
            {
                return new StaniceDAO();
            }

            public ZakupacAutobusaDAO getZakupacAutobusaDAO()
            {
                return new ZakupacAutobusaDAO();
            }

            public PorukeDAO getPorukeDAO()
            {
                return new PorukeDAO();
            }

            public RasporedVoznjiDAO getRasporedVoznjiDAO()
            {
                return new RasporedVoznjiDAO();
            }

            public VoznjeDAO getVoznjeDAO()
            {
                return new VoznjeDAO();
            }

            public LinijeDAO getLinijeDAO()
            {
                return new LinijeDAO();
            }

            public KarteDAO getKarteDAO()
            {
                return new KarteDAO();
            }

            public KupacKarteDAO getKupacKarteDAO()
            {
                return new KupacKarteDAO();
            }

            public KupacKarteSPopustomDAO getKupacKarteSPopustomDAO()
            {
                return new KupacKarteSPopustomDAO();
            }
        }
    }
}
