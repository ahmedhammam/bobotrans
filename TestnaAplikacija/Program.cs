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

                DAL.DAL.RasporedVoznjeDAO rvd = d.getDAO.getRasporedVoznjiDAO();
                try
                {

                    List<RasporedVoznje> rv = rvd.GetAll();
                   

                    foreach (RasporedVoznje trv in rv)
                    {
                        Console.WriteLine(trv.DanUSedmici);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


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
