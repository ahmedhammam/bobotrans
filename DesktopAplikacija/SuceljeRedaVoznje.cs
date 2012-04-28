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

        public List<DesktopAplikacija.Eniteti.VoznjaNaStanici> vratiPolazneVoznjeStanice(DAL.Entiteti.Stanica stanica)
        {
            int indeks, minute, sati;
            List<DesktopAplikacija.Eniteti.VoznjaNaStanici> voznjeNaStanici = new List<Eniteti.VoznjaNaStanici>();
            foreach (DAL.Entiteti.Linija linija in kolekcijaLinija.Linije)
            {

                indeks = linija.sadrziStanicu(stanica);

                if (indeks >= 0)
                {
                    foreach (DAL.Entiteti.RasporedVoznje rv in linija.RasporediVoznje)
                    {
                        sati = rv.Vrijeme.Hour;
                        minute = rv.Vrijeme.Minute;

                        minute += linija.TrajanjeDoPolaska[indeks];

                        sati += (minute / 60);
                        minute %= 60;
                        sati %= 24;


                        voznjeNaStanici.Add(new Eniteti.VoznjaNaStanici(linija.NazivLinije,sati,minute));
                    }
                     
                }

                    
            }

            return voznjeNaStanici;
        }
        public List<DesktopAplikacija.Eniteti.VoznjaNaStanici> vratiDolazneVoznjeStanice(DAL.Entiteti.Stanica stanica)
        {
            int indeks, minute, sati;
            List<DesktopAplikacija.Eniteti.VoznjaNaStanici> voznjeNaStanici = new List<Eniteti.VoznjaNaStanici>();
            foreach (DAL.Entiteti.Linija linija in kolekcijaLinija.Linije)
            {

                indeks = linija.sadrziStanicu(stanica);

                if (indeks >= 0)
                {
                    foreach (DAL.Entiteti.RasporedVoznje rv in linija.RasporediVoznje)
                    {
                        sati = rv.Vrijeme.Hour;
                        minute = rv.Vrijeme.Minute;

                        minute += linija.TrajanjeDoDolaska[indeks];

                        sati += (minute / 60);
                        minute %= 60;
                        sati %= 24;


                        voznjeNaStanici.Add(new Eniteti.VoznjaNaStanici(linija.NazivLinije, sati, minute));
                    }

                }


            }

            return voznjeNaStanici;
        }

        List<int> vratiZauzetaMjestaUAutobusu(DAL.Entiteti.Voznja trazenaVoznja)
        {
            List<int> zauzetaMjesta = new List<int>();

            return zauzetaMjesta;
        }
    }
}
