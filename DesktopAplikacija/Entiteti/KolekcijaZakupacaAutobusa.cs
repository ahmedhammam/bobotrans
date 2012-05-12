using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Entiteti;

namespace DesktopAplikacija.Entiteti
{
    class KolekcijaZakupacaAutobusa
    {
        List<ZakupacAutobusa> zakupci;
        private static KolekcijaZakupacaAutobusa instanca = null;

        public List<ZakupacAutobusa> Zakupci
        {
            get { return zakupci; }
            set { zakupci = value; }
        }

        public static KolekcijaZakupacaAutobusa Instanca
        {
            get { return (KolekcijaZakupacaAutobusa.instanca == null) ? new KolekcijaZakupacaAutobusa() : instanca; }
        }

        private KolekcijaZakupacaAutobusa()
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            DAL.DAL.ZakupacAutobusaDAO zd = d.getDAO.getZakupacAutobusaDAO();
            zakupci = zd.GetAll();
        }

        public List<ZakupacAutobusa> dajTekuceZakupe()
        {
            List<ZakupacAutobusa> tekuci = new List<ZakupacAutobusa>();

            DateTime sada = DateTime.Now;

            foreach (ZakupacAutobusa za in zakupci)
            {
                if (DateTime.Compare(za.KrajZakupa, sada) >= 0 && DateTime.Compare(za.PocetakZakupa,sada)<=0)
                    tekuci.Add(za);
            }

            return tekuci;
        }


        public List<ZakupacAutobusa> dajProsleZakupe()
        {
            List<ZakupacAutobusa> prosli = new List<ZakupacAutobusa>();
            DateTime sada = DateTime.Now;
            foreach(ZakupacAutobusa za in zakupci)
            {
                if(DateTime.Compare(za.KrajZakupa,sada)<0)
                {
                    prosli.Add(za);
                }
            }
            return prosli;
        }

        public List<ZakupacAutobusa> dajBuduceZakupe()
        {
            List<ZakupacAutobusa> buduci = new List<ZakupacAutobusa>();
            DateTime sada = DateTime.Now;

            foreach (ZakupacAutobusa za in zakupci)
            {
                if (DateTime.Compare(za.PocetakZakupa, sada) > 0)
                    buduci.Add(za);
            }

            return buduci;

        }
    }
}
