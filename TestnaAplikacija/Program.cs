using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Entiteti;
using DesktopAplikacija;

namespace TestnaAplikacija
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {


                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("127.0.0.1", "bobotrans", "root", "");
                
               // DAL.DAL.PorukeDAO pd = d.getDAO.getPorukeDAO();
                /*
                List<Poruka> p = pd.getByExample("idPrimaoca",string.Format("5"));

                foreach (Poruka pp in p)
                {
                    Console.WriteLine(pp.Tekst);
                }*/

               /* DAL.DAL.StanicaDAO sd= d.getDAO.getStaniceDAO();
                DAL.DAL.AutobusDAO ad = d.getDAO.getAutobusDAO();
                DAL.DAL.LinijaDAO ld = d.getDAO.getLinijaDAO();

                    List<Stanica> stanice = new List<Stanica>();
                    stanice.Add(sd.getById(14));
                    stanice.Add(sd.getById(13));

                    List<List<double>> cijene = new List<List<double>>();
                    cijene.Add(new List<double>());
                    cijene[0] = new List<double>() { 5 };


                    List<int> trajanjeDoDolaska = new List<int>() { 0, 30 };
                    List<int> trajanjeDoPolaska = new List<int>() { 0, 30 };

                    List<Voznja> voznje = new List<Voznja>() { new Voznja(new DateTime(2012, 5,10, 11, 10, 0), ad.getById(5)), new Voznja(new DateTime(2012, 5, 7, 17, 30, 0), ad.getById(5)) };
                    List<RasporedVoznje> rasporedi = new List<RasporedVoznje>() { new RasporedVoznje(3, new DateTime(1, 1, 1, 11, 10, 0), 25), new RasporedVoznje(7, new DateTime(1, 1, 1, 17, 30, 0), 25) };
                    Linija l = new Linija("Banja Luka - Doboj", stanice, trajanjeDoDolaska, trajanjeDoPolaska, cijene, voznje, rasporedi);
                */
                    /*stanice.Add(sd.getById(5));
                    stanice.Add(sd.getById(10));
                    stanice.Add(sd.getById(11));
                    stanice.Add(sd.getById(13));
                    stanice.Add(sd.getById(12));
                    stanice.Add(sd.getById(9));*/

                    /*List<List<double>> cijene = new List<List<double>>();
                    cijene.Add(new List<double>()); cijene.Add(new List<double>()); cijene.Add(new List<double>()); cijene.Add(new List<double>()); cijene.Add(new List<double>());
                    cijene[0] = new List<double>() { 2,5,10,13,15};
                    cijene[1] = new List<double>() { 3.5, 8.5, 11.5, 13.5 };
                    cijene[2] = new List<double>() { 5.5,9,11};
                    cijene[3] = new List<double>() { 4,5.5};
                    cijene[4] = new List<double>() { 2.5};*/
                

                    /*List<int> trajanjeDoDolaska = new List<int>() {0,30,60,80,110,130 };
                    List<int> trajanjeDoPolaska = new List<int>() {0, 35, 65, 90, 120, 130 };*/

                    /*List<Voznja> voznje = new List<Voznja>() { new Voznja(new DateTime(2012, 5, 5,10,0,0), ad.getById(1)), new Voznja(new DateTime(2012,5,7,15,30,0),ad.getById(4)) };
                    List<RasporedVoznje> rasporedi = new List<RasporedVoznje>() {new RasporedVoznje(1,new DateTime(1,1,1,10,0,0),50),new RasporedVoznje(5,new DateTime(1,1,1,15,30,0),50)};*/

                    /*Linija l = new Linija("Kakanj - Tuzla", stanice, trajanjeDoDolaska, trajanjeDoPolaska, cijene, voznje, rasporedi);*/
                   /* l.SifraLinije = ld.create(l);
                    Console.WriteLine(l.SifraLinije);*/
                
               /* List<Linija> linije = ld.GetAll();

                Linija nova = linije[0];

                Console.WriteLine(nova.NazivLinije,nova.SifraLinije);

                foreach (Stanica s in nova.Stanice)
//foreach (Korisnik k in korisnici)
//Console.WriteLine(k.ImeIPrezime);
               }
                catch (Exception e)
                {
                    Console.WriteLine(s.SifraStanice.ToString() + " " + s.Naziv.ToString());
                }

                foreach (Voznja v in nova.Voznje)
                    Console.WriteLine(v.VrijemePolaska.ToString());

                foreach (RasporedVoznje rv in nova.RasporediVoznje)
                    Console.WriteLine(rv.DanUSedmici + " "+rv.PotrebanBrojSjedista.ToString()+" "+rv.Vrijeme.ToString());

                Console.WriteLine("do dolaska:");

                foreach (int br in nova.TrajanjeDoDolaska)
                    Console.WriteLine(br);

                Console.WriteLine("do polaska:");
                foreach (int br in nova.TrajanjeDoPolaska)
                    Console.WriteLine(br);


                for (int i = 0; i < nova.Cijene.Count; i++)
                {
                    for (int j = 0; j < nova.Cijene[i].Count; j++)
                        Console.Write(nova.Cijene[i][j].ToString() + " ");
                    Console.WriteLine();
                }
                */
                Console.ReadKey();
                d.terminirajKonekciju();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}