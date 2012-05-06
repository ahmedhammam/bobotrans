using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.Entiteti;

namespace DesktopAplikacija.Menadzer
{
    public partial class IznajmljivanjeAutobusa : Form
    {
        Entiteti.KolekcijaZakupacaAutobusa kza = Entiteti.KolekcijaZakupacaAutobusa.Instanca;
        List<ZakupacAutobusa> tekuciZakupi, prosliZakupi, buduciZakupi;
        
        private enum vrijemezakupa
        {
            SADA = 0,
            PROSLO = 1,
            BUDUCE = 2
        };

        public IznajmljivanjeAutobusa()
        {
            InitializeComponent();
            tekuciZakupi = kza.dajTekuceZakupe();
            prosliZakupi = kza.dajProsleZakupe();
            buduciZakupi = kza.dajBuduceZakupe();
        }

        private void prikaziZakupe(List<ZakupacAutobusa> l, string naslov)
        {
            lvZakupi.Items.Clear();
            gbZakupi.Text = naslov;

            for (int i = 0; i < l.Count; i++)
            {
                lvZakupi.Items.Add(l[i].SifraKupca.ToString());
                lvZakupi.Items[i].SubItems.Add(l[i].Ime);
                lvZakupi.Items[i].SubItems.Add(l[i].PocetakZakupa.ToString("dd.MM.yyyy"));
                lvZakupi.Items[i].SubItems.Add(l[i].KrajZakupa.ToString("dd.MM.yyyy"));
                lvZakupi.Items[i].SubItems.Add(l[i].Cijena.ToString());
                lvZakupi.Items[i].SubItems.Add(l[i].Autobus.SifraAutobusa.ToString());
            }
        }

        public void zakupljenAutobus(ZakupacAutobusa za)
        {
            kza.Zakupci.Add(za);
            buduciZakupi.Add(za);
        }

        private void tsbTekuci_Click(object sender, EventArgs e)
        {
            prikaziZakupe(tekuciZakupi, "Tekuci zakupi:");
        }

        private void tsbProsli_Click(object sender, EventArgs e)
        {
            prikaziZakupe(prosliZakupi, "Prosli zakupi:");
        }

        private void tsbBuduci_Click(object sender, EventArgs e)
        {
            prikaziZakupe(buduciZakupi, "Buduci zakupi:");
        }

        private void tsbNovi_Click(object sender, EventArgs e)
        {
            NoviZakupAutobusa nza = new NoviZakupAutobusa(this);
            nza.Show();
        }

    }
}
