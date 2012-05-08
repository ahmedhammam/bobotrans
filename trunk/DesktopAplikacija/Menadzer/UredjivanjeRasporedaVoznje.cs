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
    public partial class UredjivanjeRasporedaVoznje : Form
    {
        private string[] dani = { "", "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };
        private Linija linija;

        public UredjivanjeRasporedaVoznje(Linija l)
        {
            InitializeComponent();
            linija = l;

            popuniRasporedeVoznji(linija.RasporediVoznje);
        }
        private void popuniRasporedeVoznji(List<RasporedVoznje> rasporedi)
        {
            foreach (RasporedVoznje raspored in rasporedi)
            {
                dgvRasporediVoznji.Rows.Add(raspored.SifraRasporedaVoznji,dani[raspored.DanUSedmici],
                    raspored.Vrijeme.Hour.ToString()+":"+raspored.Vrijeme.Minute.ToString("00"),raspored.PotrebanBrojSjedista,raspored.SifraAutobusa);
            }
        }

        /*
        void popuniRasporedeVoznji(List<RasporedVoznje> rasporedi)
        {
            for (int i = 0; i < rasporedi.Count; i++)
            {
                lvRasporedi.Items.Add(rasporedi[i].SifraRasporedaVoznji.ToString());
                lvRasporedi.Items[i].SubItems.Add(dani[rasporedi[i].DanUSedmici]);
                lvRasporedi.Items[i].SubItems.Add(rasporedi[i].Vrijeme.Hour.ToString() + ":" + rasporedi[i].Vrijeme.Minute.ToString("00"));
                lvRasporedi.Items[i].SubItems.Add(rasporedi[i].PotrebanBrojSjedista.ToString());
                lvRasporedi.Items[i].SubItems.Add(rasporedi[i].SifraAutobusa.ToString());
            }
        }*/
    }
}
