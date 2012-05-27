using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DesktopAplikacija.Serviser;
using DesktopAplikacija.Poruke;
using DesktopAplikacija.RadnikZaSalterom;

//using System.Diagnostics;

namespace DesktopAplikacija
{
    static class Program
    {
   
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DesktopAplikacija.Menadzer.AplikacijaMenadzer());
            try
            {
                DAL.DAL.Instanca.kreirajKonekciju();
                //Application.Run(new Menadzer.PregledStanica());
                //Application.Run(new Menadzer.AplikacijaMenadzer(DAL.DAL.Instanca.getDAO.getKorisnikDAO().getById(5)));
                //Application.Run(new Form1());
                Application.Run(new Login());
                DAL.DAL.Instanca.terminirajKonekciju();

               /* Process proc = new Process();
                proc.StartInfo.FileName = "C:\\Users\\Amer\\Desktop\\Bobo Trans\\trunk\\QRCodeReader\\bin\\Debug\\QRCodeReader.exe";
                proc.Start();*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
