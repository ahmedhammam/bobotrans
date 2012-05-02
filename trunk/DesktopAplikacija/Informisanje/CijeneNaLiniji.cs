using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopAplikacija.Informisanje
{
    public partial class CijeneNaLiniji : Form
    {
        private DAL.Entiteti.Linija odabranaLinija;
        public CijeneNaLiniji(DAL.Entiteti.Linija l)
        {
            odabranaLinija = l;
            InitializeComponent();

            gbLinija.Text = odabranaLinija.NazivLinije;
            lblBrojStanica.Text += odabranaLinija.Stanice.Count.ToString();
            lblSifraLinije.Text += odabranaLinija.SifraLinije.ToString();
            popuniTabelu();
        }

        private void popuniTabelu()
        {
            DataGridViewCellStyle crveno = new DataGridViewCellStyle();
            crveno.BackColor = System.Drawing.Color.Red;

            for (int i = 1; i < odabranaLinija.Stanice.Count; i++)
                dgvCijene.Columns.Add("col" + i.ToString(), odabranaLinija.Stanice[i].Naziv);
            for (int i = 0; i < odabranaLinija.Cijene.Count; i++)
            {
                dgvCijene.Rows.Add();
                dgvCijene.Rows[i].HeaderCell.Value = odabranaLinija.Stanice[i].Naziv + ", " + odabranaLinija.Stanice[i].Mjesto;
                for (int j = 0; j < i; j++)
                    dgvCijene.Rows[i].Cells[j].Style = crveno;

                for (int j = 0; j < odabranaLinija.Cijene[i].Count; j++)
                {
                    dgvCijene.Rows[i].Cells[j + i].Value = odabranaLinija.Cijene[i][j];
                }
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CijeneNaLiniji_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformisanjeVoznje iv = new InformisanjeVoznje(odabranaLinija);
            iv.Show();
        }
    }
}
