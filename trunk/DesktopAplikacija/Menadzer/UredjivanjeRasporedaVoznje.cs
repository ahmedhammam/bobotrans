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
        //private string[] dani = { "", "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };
        private Linija linija;
        private DesktopAplikacija.Entiteti.KolekcijaAutobusa ka = DesktopAplikacija.Entiteti.KolekcijaAutobusa.Instanca;

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
                dgvRasporediVoznji.Rows.Add(raspored.SifraRasporedaVoznji,raspored.DanUSedmici,
                    raspored.Vrijeme.Hour.ToString("00")+":"+raspored.Vrijeme.Minute.ToString("00"),raspored.PotrebanBrojSjedista,raspored.SifraAutobusa);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool sadrziSlovo(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return true;
            }
            return false;
        }

        private bool validirajDan(int red)
        {
            string dan = dgvRasporediVoznji.Rows[red].Cells[1].Value.ToString();

            if (dan.Length > 1) return false;
            int d;
            if (!int.TryParse(dan,out d))
            {
                return false;
            }
            if (d < 1 || d > 7) return false;
            return true;
        }

        private bool validirajDatum(int red)
        {
            string vrijeme = dgvRasporediVoznji.Rows[red].Cells[2].Value.ToString();
            if (vrijeme.Length != 5) 
            {
                //MessageBox.Show(vrijeme.Length.ToString());
                    return false;
            }

            if (!char.IsDigit(vrijeme, 0) || !char.IsDigit(vrijeme, 1) || !char.IsDigit(vrijeme, 3) || !char.IsDigit(vrijeme, 4) || vrijeme[2] != ':')
            {
                //MessageBox.Show(char.IsDigit(vrijeme, 0).ToString() + char.IsDigit(vrijeme, 1).ToString() + char.IsDigit(vrijeme, 3).ToString() + char.IsDigit(vrijeme, 4).ToString());
                return false;
            }

            int sat = (Convert.ToInt16(vrijeme[0]) - 48) * 10 + (Convert.ToInt16(vrijeme[1]) - 48);
            int minuta = (Convert.ToInt16(vrijeme[3]) - 48) * 10 + (Convert.ToInt16(vrijeme[4]) - 48);

            if (sat > 23 || sat < 0 || minuta > 59 || minuta < 0)
            {
                //MessageBox.Show(sat.ToString() + " " + minuta.ToString());
                return false;
            }
            return true;
        }
        bool validirajBrojSjedista(int red)
        {
            string brojSjedista = dgvRasporediVoznji.Rows[red].Cells[3].Value.ToString();
            if(brojSjedista.Length>3 || brojSjedista.Length==0)
                return false;

            if(sadrziSlovo(brojSjedista))
                return false;
            return true;
        }

        bool validirajSifruAutobusa(int red)
        {
            string sifraAutobusa = dgvRasporediVoznji.Rows[red].Cells[4].Value.ToString();
            if (sifraAutobusa.Length > 3 || sifraAutobusa.Length == 0)
                return false;

            if (sadrziSlovo(sifraAutobusa))
                return false;
            long sa;
            sa = long.Parse(sifraAutobusa);

            DAL.Entiteti.Autobus a = ka.dajPoSifri(sa);
            //MessageBox.Show(sa.ToString());
            if (a == null)
                return false;

            return true;
        }

        private void validirajUnos()
        {
            for (int i = 0; i < dgvRasporediVoznji.Rows.Count-1; i++)
            {
                if (!validirajDan(i))
                    throw new Exception("Nedozvoljen ulaz za dan u redu: " + i.ToString());

                if (!validirajDatum(i))
                    throw new Exception("Nedozvoljen ulaz za vrijeme u redu: " + i.ToString());

                if(!validirajBrojSjedista(i))
                    throw new Exception("Nedozvoljen ulaz za broj sjedista u redu: " + i.ToString());
                if(!validirajSifruAutobusa(i))
                    throw new Exception("Nedozvoljen ulaz za sifru autobusa u redu: " + i.ToString());
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            try
            {
                validirajUnos();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite spasiti promjene?","Spasiti?",MessageBoxButtons.YesNo);
            if (dres==DialogResult.Yes)
            {
                int dan, brSjed, sifraAutobusa;
                DateTime vrijeme;
                List<DAL.Entiteti.RasporedVoznje> rasporedi = new List<DAL.Entiteti.RasporedVoznje>();
                for (int i = 0; i < dgvRasporediVoznji.Rows.Count - 1; i++)
                {
                    dan = Convert.ToInt16(dgvRasporediVoznji.Rows[i].Cells[1].Value.ToString());
                    //vrijeme = Convert.ToDateTime(dgvRasporediVoznji.Rows[i].Cells[2].ToString(),new IFormatProvider( "hh:mm"));
                    //rasporedi.Add(new RasporedVoznje(),));
                }
            }
        }

        private void spasi()
        {

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvRasporediVoznji.SelectedRows)
            {
                dgvRasporediVoznji.Rows.Remove(dgvr);
            }
        }
    }
}
