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
    public partial class UnosCijena : Form
    {
        private List<DAL.Entiteti.Stanica> stanice;
        private DodajNovuLiniju pozvanOd;
        private List<List<double>> cijene;

        public UnosCijena(List<DAL.Entiteti.Stanica> s,DodajNovuLiniju dnl,List<List<double>> c)
        {
            stanice = s;
            cijene = c;
            InitializeComponent();
            pozvanOd = dnl;
            napraviTabeluCijena();
        }

        void napraviTabeluCijena()
        {
            dgvCijene.Rows.Clear();
            DataGridViewCellStyle crveno = new DataGridViewCellStyle();
            crveno.BackColor = System.Drawing.Color.Red;

            for (int i = 1; i < stanice.Count; i++)
            {
                dgvCijene.Columns.Add("col" + i.ToString(), stanice[i].Naziv);
                dgvCijene.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < stanice.Count-1; i++)
            {
                dgvCijene.Rows.Add();
                dgvCijene.Rows[i].HeaderCell.Value = stanice[i].Naziv + ", " + stanice[i].Mjesto;
                for (int j = 0; j < i; j++)
                {
                    dgvCijene.Rows[i].Cells[j].Style = crveno;
                    dgvCijene.Rows[i].Cells[j].ReadOnly = true;
                }
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

        private bool sadrziSlovo(string s)
        {
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                    return true;
            }
            return false;
        }

        private List<List<double>> validirajUneseneCijene()
        {
            double cijena;
            string sadrzaj;
            int brojStanica = stanice.Count;
            List<List<double>> cijene = new List<List<double>>();


            for (int i = 0; i < brojStanica - 1; i++)
            {
                cijene.Add(new List<double>());
                for (int j = 0; j < brojStanica - i - 1; j++)
                    cijene[i].Add(0);
            }

            for (int i = 0; i < dgvCijene.Rows.Count; i++)
            {
                for (int j = i; j < dgvCijene.ColumnCount; j++)
                {
                    if (dgvCijene.Rows[i].Cells[j].Value == null) throw new Exception("Neispravna cijena!");
                    sadrzaj = dgvCijene.Rows[i].Cells[j].Value.ToString();
                    if (sadrzaj == "" || sadrziSlovo(sadrzaj) || !double.TryParse(sadrzaj, out cijena) || cijena < 0)
                    {
                        throw new Exception("Neispravna cijena!");
                    }
                    else
                    {
                        cijene[i][j - i] = cijena;
                    }
                }
            }
            return cijene;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {

            List<List<double>> cijene;
            try
            {
                cijene = validirajUneseneCijene();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite spasiti unesene promjene?", "Spasiti?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dres == DialogResult.Yes)
            {
                pozvanOd.uneseneCijene(cijene);

                MessageBox.Show("Cijene su spasene");
                Close();
            }
        }

    }
}
