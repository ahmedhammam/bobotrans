using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DesktopAplikacija.Serviser.Entiteti;


namespace DesktopAplikacija.Serviser
{
    public partial class IzmijeniPodatke : Form
    {
        int s;
        DAL.DAL d = DAL.DAL.Instanca;
        List<DAL.Entiteti.Autobus> autobusi;
        KolekcijaAutobusa a;
        public IzmijeniPodatke(int sifra)
        {
            InitializeComponent();
            try
            {
                a = KolekcijaAutobusa.Instanca;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            s = sifra;
        }

        private void IzmijeniPodatke_Load(object sender, EventArgs e)
        {
            try
            {
                d.kreirajKonekciju();
                autobusi = a.dajPoDatumu();
                foreach (DAL.Entiteti.Autobus au in autobusi)
                {
                    if (au.SifraAutobusa == s)
                    {
                        textBox1.Text = Convert.ToString(au.SifraAutobusa);
                        textBox2.Text = au.RegistracijskeTablice;
                        numericUpDown1.Value = au.BrojSjedista;
                        textBox3.Text = Convert.ToString(Convert.ToInt32(au.ImaToalet));
                        textBox4.Text = Convert.ToString(Convert.ToInt32(au.ImaKlimu));
                        textBox5.Text = Convert.ToString(Convert.ToInt32(au.Slobodan));
                        dateTimePicker1.Value = au.IstekRegistracije;
                        dateTimePicker2.Value = au.DatumServisa;
                    }
                }
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
                DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
                autobusi = a.dajPoDatumu();

                foreach (DAL.Entiteti.Autobus au in autobusi)
                {
                    if (au.SifraAutobusa == s)
                    {
                        au.RegistracijskeTablice = textBox2.Text;
                        au.IstekRegistracije = dateTimePicker1.Value;
                        au.DatumServisa = dateTimePicker2.Value;
                        ad.update(au);
                        DialogResult dres;
                        dres = MessageBox.Show("Jeste li sigurni da želite promijeniti podatke?", "provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dres == System.Windows.Forms.DialogResult.Yes)
                            MessageBox.Show("Podaci su promijenjeni!");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
