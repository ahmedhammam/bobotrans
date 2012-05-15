using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QRCodeGenerator;

namespace DesktopAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = QRCodeGenerator.QRCodeGenerator.dajQRCode("AMER", 10);

            Bitmap kod = QRCodeGenerator.QRCodeGenerator.dajQRCode("324522", 10);

    /*// Create a DeviceManager instance
    var deviceManager = new DeviceManager();

    // Loop through the list of devices and add the name to the listbox
    for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
    {
        var deviceName = deviceManager.DeviceInfos[i].Properties["Name"].get_Value().ToString();
        Devices.Items.Add(deviceName);
    }
}*/

            /*CommonDialogClass class1 = new CommonDialogClass();
            Device d = class1.ShowSelectDevice(WiaDeviceType.UnspecifiedDeviceType, true, false);
            if (d != null)
            {
                settings.DeviceID = d.DeviceID;
                settings.Save();
            }*/

            //DesktopAplikacija.Entiteti.KolekcijaStanica ks = DesktopAplikacija.Entiteti.KolekcijaStanica.Instanca;
                //DesktopAplikacija.SuceljeRedaVoznje srv = new DesktopAplikacija.SuceljeRedaVoznje();

              // DAL.Entiteti.Stanica s1 = ks.getById(5);
              // DAL.Entiteti.Stanica s2 = ks.getById(9);

                /*List<DesktopAplikacija.Entiteti.VoznjaNaStanici> voznje = srv.vratiDolazneVoznjeStanice(ks.getById(13));

                foreach (DesktopAplikacija.Entiteti.VoznjaNaStanici v in voznje)
                    bla.Text += v.NazivLinije + " " + v.Sati.ToString() + " " + v.Minute.ToString() + "\n";
                bla.Text += "------------------\n";
                List<DesktopAplikacija.Entiteti.VoznjaNaStanici> voznje2 = srv.vratiPolazneVoznjeStanice(ks.getById(13));

                foreach (DesktopAplikacija.Entiteti.VoznjaNaStanici v in voznje2)
                    bla.Text += v.NazivLinije + " " + v.Sati.ToString() + " " + v.Minute.ToString() + "\n";*/
               //DesktopAplikacija.Entiteti.Put p= srv.vratiNajjeftinijiPut(s1, s2);
               //bla.Text = p.OpisPuta + "\n" + p.Cijena;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
