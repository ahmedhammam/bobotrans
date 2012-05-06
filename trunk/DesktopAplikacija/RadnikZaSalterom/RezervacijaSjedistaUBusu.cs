using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopAplikacija.RadnikZaSalterom
{
    public partial class RezervacijaSjedistaUBusu : Form
    {
        RezervacijaSjedista rezervacijaDugmad;
        public RezervacijaSjedistaUBusu()
        {
            InitializeComponent();
        }

        private void RezervacijaSjedistaUBusu_Load(object sender, EventArgs e)
        {

            //PRIMJER KODA KOJI TREBA PRI OTVARANJU FORME BIT:
            List<bool> sjedista = new List<bool>();
            for (int i = 0; i < 65; i++) sjedista.Add(false);
            sjedista[0] = true;
            sjedista[17] = true;
            sjedista[5] = true;
            postaviDugmad(65, sjedista);
        }

        /* nacrta se mapa sjedista, sa datim brojem sjedista (koji pri dijeljenju s 4 daje ostatak 1 ! ! !
         * i datom listom booleana, ciji je (i-1). element odgovor na pitanje da li je mjesto vec prije zauzeto
         */
        private void postaviDugmad(int brojSjedista, List<bool> zauzetostSjedista)
        {
            rezervacijaDugmad = new RezervacijaSjedista(brojSjedista, zauzetostSjedista);
            elementHost1.Child = rezervacijaDugmad;
            rezervacijaDugmad.Width = (brojSjedista / 4) * 50;
            rezervacijaDugmad.Height = 450;
            elementHost1.Width = (brojSjedista / 4) * 50;
            elementHost1.Height = 450;
        }

        /* vraca listu mjesta koje je korisnik odabrao */
        List<int> trazenaMjesta()
        {
            return rezervacijaDugmad.trazenaMjesta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> ovo = trazenaMjesta();
            textBox1.Text = "";
            foreach(int ovaj in ovo)
            {
                textBox1.Text += ovaj.ToString()+", ";
            }
        }
    }
}
