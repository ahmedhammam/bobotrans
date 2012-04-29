using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija.Serviser.Entiteti
{
    class KolekcijaAutobusa
    {
       private  DAL.DAL d = DAL.DAL.Instanca;
       private  DAL.DAL.AutobusDAO ad;
       List<DAL.Entiteti.Autobus> autobusi;
       private static KolekcijaAutobusa instanca=null;

       public static KolekcijaAutobusa Instanca
       {
           get { return (instanca==null)? new KolekcijaAutobusa() : instanca;}
       }
       
        private KolekcijaAutobusa(){
           ad= d.getDAO.getAutobusDAO();
                autobusi = ad.GetAll();
        }

        
        public List<DAL.Entiteti.Autobus>  dajPoDatumu()
        {
            List<DAL.Entiteti.Autobus> nova = new List<DAL.Entiteti.Autobus>();
            foreach (DAL.Entiteti.Autobus a in autobusi)
                nova.Add(a);        
            for (int i=0;i<nova.Count;i++)
            {
                for (int j = i + 1; j < nova.Count;j++ )
                {
                    if (nova[j].DatumServisa<nova[i].DatumServisa)
                    {
                        DAL.Entiteti.Autobus novi = nova[i];
                        nova[i] = nova[j];
                        nova[j] = novi;
                        
                    }
                }             
            }
            return nova;
        }

       public  List<DAL.Entiteti.Autobus>  dajPoIsteku()
        {

            List<DAL.Entiteti.Autobus> nova = new List<DAL.Entiteti.Autobus>();
            foreach (DAL.Entiteti.Autobus a in autobusi)
                nova.Add(a);


            for (int i = 0; i < nova.Count; i++)
            {
                for (int j = i + 1; j < nova.Count; j++)
                {
                    if (nova[j].IstekRegistracije> nova[i].IstekRegistracije)
                    {
                        DAL.Entiteti.Autobus novi = nova[i];
                        nova[i] = nova[j];
                        nova[j] = novi;
                    }
                }
            }
            return nova;
        }


    }
}
