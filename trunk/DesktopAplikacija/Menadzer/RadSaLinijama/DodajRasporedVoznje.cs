using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopAplikacija.Menadzer
{
    public partial class DodajRasporedVoznje : Form
    {
        private DesktopAplikacija.Entiteti.KolekcijaAutobusa ka = DesktopAplikacija.Entiteti.KolekcijaAutobusa.Instanca;
        private List<DAL.Entiteti.RasporedVoznje> rasporedi;
        private DodajNovuLiniju pozvanOd;

        public DodajRasporedVoznje(List<DAL.Entiteti.RasporedVoznje> rv,DodajNovuLiniju dnl)
        {
            rasporedi = rv;
            InitializeComponent();
            popuniRasporedeVoznji(rasporedi);
            pozvanOd = dnl;
        }

        private void popuniRasporedeVoznji(List<DAL.Entiteti.RasporedVoznje> rasporedi)
        {
            foreach (DAL.Entiteti.RasporedVoznje raspored in rasporedi)
            {
                dgvRasporediVoznji.Rows.Add(raspored.SifraRasporedaVoznji,raspored.DanUSedmici,
                    raspored.Vrijeme.Hour.ToString("00")+":"+raspored.Vrijeme.Minute.ToString("00"),raspored.PotrebanBrojSjedista,raspored.SifraAutobusa);
            }
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
            if (dgvRasporediVoznji.Rows[red].Cells[1].Value == null)
                return false;
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
            if (dgvRasporediVoznji.Rows[red].Cells[2].Value == null)
                return false;
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
            if (dgvRasporediVoznji.Rows[red].Cells[3].Value == null)
                return false;
            string brojSjedista = dgvRasporediVoznji.Rows[red].Cells[3].Value.ToString();
            if(brojSjedista.Length>3 || brojSjedista.Length==0)
                return false;

            if(sadrziSlovo(brojSjedista))
                return false;
            return true;
        }

        bool validirajSifruAutobusa(int red)
        {
            if (dgvRasporediVoznji.Rows[red].Cells[4].Value == null)
                return false;
            string sifraAutobusa = dgvRasporediVoznji.Rows[red].Cells[4].Value.ToString();
            if (sifraAutobusa.Length > 3 || sifraAutobusa.Length == 0)
                return false;

            if (sadrziSlovo(sifraAutobusa))
                return false;
            long sa;
            sa = long.Parse(sifraAutobusa);

            DAL.Entiteti.Autobus a = ka.dajPoSifri(sa);
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

        private DateTime ocitajDatum(string vrijeme)
        {
            int sat = (Convert.ToInt16(vrijeme[0]) - 48) * 10 + (Convert.ToInt16(vrijeme[1]) - 48);
            int minuta = (Convert.ToInt16(vrijeme[3]) - 48) * 10 + (Convert.ToInt16(vrijeme[4]) - 48);
            return new DateTime(1,1,1,sat,minuta,0);
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
                this.Enabled = false;
                int dan, brSjed, sifraAutobusa;
                DateTime vrijeme;
                List<DAL.Entiteti.RasporedVoznje> rv = new List<DAL.Entiteti.RasporedVoznje>();
                for (int i = 0; i < dgvRasporediVoznji.Rows.Count - 1; i++)
                {
                    dan = Convert.ToInt16(dgvRasporediVoznji.Rows[i].Cells[1].Value.ToString());
                    vrijeme = ocitajDatum(dgvRasporediVoznji.Rows[i].Cells[2].Value.ToString());
                    brSjed = Convert.ToInt16(dgvRasporediVoznji.Rows[i].Cells[3].Value.ToString());
                    sifraAutobusa = Convert.ToInt32(dgvRasporediVoznji.Rows[i].Cells[4].Value.ToString());
                    rv.Add(new DAL.Entiteti.RasporedVoznje(dan, vrijeme, brSjed, sifraAutobusa));
                }

                pozvanOd.uneseniRasporedi(rv);
                MessageBox.Show("Promjene su uspješno unesene!");
                this.Enabled = true;
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvRasporediVoznji.SelectedRows)
            {
                dgvRasporediVoznji.Rows.Remove(dgvr);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite izaći bez spašavanja promjena?", "Izaći?", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {
                Close();
            }
        }

        private void DodajRasporedVoznje_Load(object sender, EventArgs e)
        {

        }
    }
}
