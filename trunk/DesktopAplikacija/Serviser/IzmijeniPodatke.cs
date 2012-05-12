using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DesktopAplikacija.Entiteti;


namespace DesktopAplikacija.Serviser
{
    public partial class IzmijeniPodatke : Form
    {
        long sifra;
        DAL.DAL d = DAL.DAL.Instanca;
        KolekcijaAutobusa ka = KolekcijaAutobusa.Instanca;
        DAL.Entiteti.Autobus odabraniAutobus;

        public IzmijeniPodatke(long s)
        {
            sifra = s;
            InitializeComponent();
            odabraniAutobus = ka.dajPoSifri(sifra);
        }

        private void IzmijeniPodatke_Load(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(odabraniAutobus.SifraAutobusa);
                textBox2.Text = odabraniAutobus.RegistracijskeTablice;
                numericUpDown1.Value = odabraniAutobus.BrojSjedista;
                textBox3.Text = Convert.ToString(Convert.ToInt32(odabraniAutobus.ImaToalet));
                textBox4.Text = Convert.ToString(Convert.ToInt32(odabraniAutobus.ImaKlimu));
                textBox5.Text = Convert.ToString(Convert.ToInt32(odabraniAutobus.Slobodan));
                dateTimePicker1.Value = odabraniAutobus.IstekRegistracije;
                dateTimePicker2.Value = odabraniAutobus.DatumServisa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                d.kreirajKonekciju();

                DAL.DAL.AutobusDAO ad = d.getDAO.getAutobusDAO();

                odabraniAutobus.RegistracijskeTablice = textBox2.Text;
                odabraniAutobus.IstekRegistracije = dateTimePicker1.Value;
                odabraniAutobus.DatumServisa = dateTimePicker2.Value;
                DialogResult dres;
                dres = MessageBox.Show("Jeste li sigurni da želite promijeniti podatke?", "provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dres == System.Windows.Forms.DialogResult.Yes)
                {
                    ad.update(odabraniAutobus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
