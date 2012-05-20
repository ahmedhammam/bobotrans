using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DesktopAplikacija.Informisanje
{
    public class InformisanjeKomande
    {
        private static Entiteti.KolekcijaLinija kolekcijaLinija = Entiteti.KolekcijaLinija.Instanca;
        private static DesktopAplikacija.Entiteti.KolekcijaStanica ks = DesktopAplikacija.Entiteti.KolekcijaStanica.Instanca;
        private static DesktopAplikacija.Entiteti.KolekcijaLinija kl = DesktopAplikacija.Entiteti.KolekcijaLinija.Instanca;


        public static List<Entiteti.VoznjaNaStanici> vratiPolazneVoznjeStanice(DAL.Entiteti.Stanica stanica)
        {
            int indeks, minute, sati;
            List<Entiteti.VoznjaNaStanici> voznjeNaStanici = new List<Entiteti.VoznjaNaStanici>();
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


                        voznjeNaStanici.Add(new Entiteti.VoznjaNaStanici(linija.NazivLinije,sati,minute));
                    }
                     
                }

                    
            }

            return voznjeNaStanici;
        }
        public static List<Entiteti.VoznjaNaStanici> vratiDolazneVoznjeStanice(DAL.Entiteti.Stanica stanica)
        {
            int indeks, minute, sati;
            List<Entiteti.VoznjaNaStanici> voznjeNaStanici = new List<Entiteti.VoznjaNaStanici>();
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


                        voznjeNaStanici.Add(new Entiteti.VoznjaNaStanici(linija.NazivLinije, sati, minute));
                    }

                }


            }

            return voznjeNaStanici;
        }

        private class edge:IComparable
        {
            public double c;
            public long v;
            public long parent;

            public edge() { }
            public edge(double cc, long vv) { c = cc; v = vv; }
            public edge(double cc, long vv, long parentt) { c = cc; v = vv; parent = parentt; }

            public int CompareTo(object obj)
            {
                edge edg = obj as edge;
                if (c < edg.c) return -1;
                else if(c>edg.c) return 1;

                if(v!=edg.v) return -1;

                return 0;
            }
        };

        public static List<int> vratiZauzetaMjestaUAutobusu(DAL.Entiteti.Voznja trazenaVoznja)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju();
            DAL.DAL.VoznjaDAO vd = d.getDAO.getVoznjaDAO();
            List<int> zauzetaMjesta = vd.dajZauzetaSjedista(trazenaVoznja);
            return zauzetaMjesta;
        }

        public static Entiteti.Put vratiNajjeftinijiPut(DAL.Entiteti.Stanica pocetnaStanica, DAL.Entiteti.Stanica krajnjaStanica)
        {
            long velicina = ks.dajMaksimalnuSifru();
            velicina++;
            List<edge>[] v = new List<edge>[velicina];
            for (int i = 0; i < velicina; i++)
                v[i] = new List<edge>();

            napraviGraf(ref v, velicina);

            DesktopAplikacija.Entiteti.Put put = dijkstra(v,pocetnaStanica,krajnjaStanica,velicina);

            return put;
        }


        private static DesktopAplikacija.Entiteti.Put dijkstra(List<edge>[] v, DAL.Entiteti.Stanica pocetak, DAL.Entiteti.Stanica kraj, long velicina)
        {
            string s = string.Format("");
            bool[] visited = new bool[velicina];
            edge[] dd = new edge[velicina];
            for (int i = 0; i < velicina; i++)
            {
                visited[i] = false;
                dd[i] = new edge(-1,0,0);
            }

            SortedSet<edge> ss = new SortedSet<edge>();
            
            for (int i = 0; i < v[pocetak.SifraStanice].Count; i++)
            {
                ss.Add(new edge(v[pocetak.SifraStanice][i].c,v[pocetak.SifraStanice][i].v,pocetak.SifraStanice));
            }
            
            dd[pocetak.SifraStanice].v = pocetak.SifraStanice;
            visited[pocetak.SifraStanice] = true;
            dd[pocetak.SifraStanice].c = 0;
            edge tmp;
            
            while (ss.Count > 0)
            {
                tmp = ss.Min;
                ss.Remove(ss.Min);
                if (visited[tmp.v]) continue;

                dd[tmp.v].c = tmp.c;
                visited[tmp.v] = true;
                dd[tmp.v].v = tmp.parent;

                for (int i = 0; i < v[tmp.v].Count; i++)
                {
                    ss.Add(new edge(dd[tmp.v].c + v[tmp.v][i].c, v[tmp.v][i].v,tmp.v));
                }
            }

            if (dd[kraj.SifraStanice].c == -1)
            {
                return new Entiteti.Put(-1, "Ne postoji put izmedju trazenih stanica!");
            }

            long tmp2 = kraj.SifraStanice;
            List<long> put = new List<long>();
            put.Add(tmp2);
            while (tmp2 != pocetak.SifraStanice)
            {
                put.Add(dd[tmp2].v);
                tmp2 = dd[tmp2].v;
            }
            double tmpCijena;
            DAL.Entiteti.Stanica stanica1,stanica2;
            for(int i=put.Count-1;i>0;i--)
            {
                tmpCijena = 0;
                stanica1 = ks.getById(put[i]);
                stanica2 = ks.getById(put[i - 1]);
                foreach(edge ee in v[put[i]])
                    if (ee.v == put[i - 1])
                    {
                        tmpCijena = ee.c;
                        break;
                    }
                s += stanica1.Naziv + ", " + stanica1.Mjesto + " - " + stanica2.Naziv + ", " + stanica2.Mjesto +": "+tmpCijena.ToString()+ "KM\n";
            }

            return new Entiteti.Put(dd[kraj.SifraStanice].c, s);
        }

        private static List<edge>[] napraviGraf(ref List<edge>[] v, long velicina)
        {
            foreach (DAL.Entiteti.Linija l in kl.Linije)
            {
                for (int i = 0; i < l.Stanice.Count; i++)
                {
                    for (int j = i + 1; j < l.Stanice.Count; j++)
                    {
                        v[l.Stanice[i].SifraStanice].Add(new edge(l.Cijene[i][j-i-1],l.Stanice[j].SifraStanice));
                    }
                }
            }
            return v;
        }

    }
}
