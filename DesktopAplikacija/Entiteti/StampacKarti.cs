using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

namespace DesktopAplikacija.Entiteti
{
    class StampacKarti
    {
        PrintDocument dokumentZaPrintanje;
        bool saPopustom;
        string tip_kupca;
        string podaci;
        DateTime pocetak;
        DateTime kraj;
        List<DAL.Entiteti.Stanica> staniceUVoznji;
        int indeks;
        DAL.Entiteti.KupacKarte kupacKarte;
        DAL.Entiteti.Linija linija;

        public StampacKarti(DAL.Entiteti.KupacSaPopustom kupac, List<DAL.Entiteti.Stanica> staniceUVoznji_)
        {
            saPopustom = true;
            tip_kupca = kupac.TipKupca.ToString();
            podaci = kupac.Podaci;
            indeks = 0;
            kupacKarte = kupac;
            dokumentZaPrintanje = new PrintDocument();
            dokumentZaPrintanje.PrintPage += new PrintPageEventHandler(printanje);
            staniceUVoznji = staniceUVoznji_;
        }

        public StampacKarti(DAL.Entiteti.KupacKarte kupac, List<DAL.Entiteti.Stanica> staniceUVoznji_)
        {
            saPopustom = false;
            indeks = 0;
            kupacKarte = kupac;
            dokumentZaPrintanje = new PrintDocument();
            dokumentZaPrintanje.PrintPage += new PrintPageEventHandler(printanje);
            staniceUVoznji = staniceUVoznji_;
        }

        public void Stampaj()
        {
            indeks = 0;
            dokumentZaPrintanje.DefaultPageSettings.PaperSize = new PaperSize("moje", 580, 410);
            long idLin = DAL.DAL.Instanca.getDAO.getVoznjaDAO().dajIdLinije(kupacKarte.Voznja.SifraVoznje);
            linija = DAL.DAL.Instanca.getDAO.getLinijaDAO().getById(idLin);
            pocetak = kraj = kupacKarte.Voznja.VrijemePolaska;
            int vrijemePocetak, vrijemeKraj;
            vrijemePocetak = linija.TrajanjeDoPolaska[dajIndexStanice(kupacKarte.PocetnaStanica)];
            vrijemeKraj = linija.TrajanjeDoDolaska[dajIndexStanice(kupacKarte.KrajnjaStanica)];
            System.Diagnostics.Debug.WriteLine("BLAAA");
            System.Diagnostics.Debug.WriteLine(vrijemePocetak);
            System.Diagnostics.Debug.WriteLine(vrijemeKraj);
            pocetak = pocetak.AddMinutes((double)vrijemePocetak);
            kraj = kraj.AddMinutes((double)vrijemeKraj);
            dokumentZaPrintanje.Print();
        }

        private void printanje(object sender, PrintPageEventArgs e)
        {
            e.HasMorePages = true;
            crtajLayout(e);
            indeks++;
            if (indeks == kupacKarte.Sjedista.Count) e.HasMorePages = false;
        }

        private void crtajLayout(PrintPageEventArgs e)
        {


            Color bojaLinija = Color.Black;
            Color bojaTeksta = Color.Black;
            //e.Graphics.DrawImage(pictureBox1.Image, 280, -20, 300, 300);

            e.Graphics.DrawRectangle(new Pen(bojaLinija), 20, 20, 260, 130);
            e.Graphics.DrawRectangle(new Pen(bojaLinija), 20, 150, 260, 170);
            e.Graphics.DrawRectangle(new Pen(bojaLinija), 20, 320, 260, 70);
            e.Graphics.DrawString(kupacKarte.Ime, new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 30));
            if (saPopustom)
            {
                e.Graphics.DrawString(tip_kupca, new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 70));
                e.Graphics.DrawString(podaci, new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 110));
            }
            e.Graphics.DrawString(linija.ToString(), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 160));
            e.Graphics.DrawString(kupacKarte.PocetnaStanica.ToString(), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 190));
            e.Graphics.DrawString(pocetak.ToString("dd.MM.yyyy. HH:mm:ss"), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 220));
            e.Graphics.DrawString(kupacKarte.KrajnjaStanica.ToString(), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 250));
            e.Graphics.DrawString(kraj.ToString("dd.MM.yyyy. HH:mm:ss"), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 280));
            e.Graphics.DrawString(String.Format("Broj sjedišta: {0}", kupacKarte.Sjedista[indeks]), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(30, 350));
            e.Graphics.DrawString("Vozna karta", new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(360, 90));
            e.Graphics.DrawString(String.Format("Cijena: {0} KM", kupacKarte.Cijene[indeks]), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(bojaTeksta), new PointF(340, 150));


            e.Graphics.DrawRectangle(new Pen(bojaLinija), 410, 230, 150, 150);
        }

        private int dajIndexStanice(DAL.Entiteti.Stanica stan)
        {
            for (int i = 0; i < staniceUVoznji.Count; i++)
                if (staniceUVoznji[i].SifraStanice == stan.SifraStanice) return i;
            throw new Exception("Greška sa stanicama");
        }
    }
}
