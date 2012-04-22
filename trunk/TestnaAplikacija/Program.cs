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

                DAL.DAL.AutobusDAO ad = d.getDAO.getAutobusDAO();

                //Autobus novi = new Autobus(50, "138-J-197", true, true, true, new DateTime(2011, 11, 2), new DateTime(2010, 3, 3));

               // novi.SifraAutobusa = ad.create(novi);
                //Console.WriteLine(novi.SifraAutobusa);

                List<Autobus> l = ad.getByExample("brojSjedista", "50");

                foreach (Autobus a in l)
                {
                    Console.WriteLine(a.SifraAutobusa);
                }
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
