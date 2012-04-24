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

DAL.DAL.KorisnikDAO kd = d.getDAO.getKorisnikDAO();

List<Korisnik> korisnici = kd.GetAll();

foreach (Korisnik k in korisnici)
Console.WriteLine(k.ImeIPrezime);
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
        }
    }
}
