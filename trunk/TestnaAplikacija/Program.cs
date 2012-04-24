using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Entiteti;

namespace TestnaAplikacija
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DAL.DAL d = DAL.DAL.Instanca;
                //d.kreirajKonekciju("127.0.0.1", "bobotrans", "amer", "jCwB448bWhWcCuAC");
                d.kreirajKonekciju("127.0.0.1", "bobotrans", "root", "");

                DAL.DAL.LinijaDAO ld = d.getDAO.getLinijaDAO();

                DAL.DAL.StanicaDAO sd = d.getDAO.getStaniceDAO();
                DAL.DAL.AutobusDAO ad = d.getDAO.getAutobusDAO();
                try
                {
                    /*List<Stanica> stanice = new List<Stanica>();
                    stanice.Add(sd.getById(5));
                    stanice.Add(sd.getById(10));
                    stanice.Add(sd.getById(11));
                    stanice.Add(sd.getById(13));
                    stanice.Add(sd.getById(12));
                    stanice.Add(sd.getById(9));*/

                    //ad.create(new Autobus(50, "123-K-456", true, true, true, new DateTime(2012, 5, 5), new DateTime(2012, 4, 4)));
                   // ad.create(new Autobus(40, "234-K-317", false, true, false, new DateTime(2012, 10, 7), new DateTime(2012, 4, 20)));

                    List<List<double>> cijene = new List<List<double>>(6);
                    cijene[0] = new List<double>(){};
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                //Linija l = new Linija("Zenica - Tuzla");

                
                //try
                //{

                    //List<RasporedVoznje> rv = rvd.GetAll();
                   
                    /*foreach (RasporedVoznje trv in rv)
                    {
                        Console.WriteLine(trv.DanUSedmici);
                    }*/
                    //Korisnik k = new Korisnik("amesanovic", "Amer Mešanović", DAL.TipoviPodataka.TipoviKorisnika.MENAGER, "nekipass");
                   // k.SifraKorisnika = kd.create(k);
                   // kd.delete(kd.getById(7));
               //}
                //catch (Exception e)
               // {
                //    Console.WriteLine(e.Message);
                //}
            

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
