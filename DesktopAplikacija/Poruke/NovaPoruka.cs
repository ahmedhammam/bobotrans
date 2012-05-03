using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using DesktopAplikacija.Poruke;

namespace DesktopAplikacija.Poruke
{
    public partial class NovaPoruka : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        DAL.Entiteti.Korisnik ks;
        List<DAL.Entiteti.Korisnik> svi=new List<DAL.Entiteti.Korisnik>();
        List<DAL.Entiteti.Korisnik> salterasi = new List<DAL.Entiteti.Korisnik>();
        List<DAL.Entiteti.Korisnik> menadzeri = new List<DAL.Entiteti.Korisnik>();
        List<DAL.Entiteti.Korisnik> serviseri = new List<DAL.Entiteti.Korisnik>();
        

        
        public NovaPoruka(DAL.Entiteti.Korisnik k,List<DAL.Entiteti.Korisnik> kor)
        {
            foreach (DAL.Entiteti.Korisnik p in svi)
                comboBox1.Items.Add(p);
            ks = k;
            
            foreach (DAL.Entiteti.Korisnik korisnik in svi)
            {
                if (korisnik.Tip == DAL.TipoviPodataka.TipoviKorisnika.MENAGER)
                    menadzeri.Add(korisnik);
                else if (korisnik.Tip == DAL.TipoviPodataka.TipoviKorisnika.RADNIK_ZA_SALTEROM)
                    salterasi.Add(korisnik);
                else if (korisnik.Tip == DAL.TipoviPodataka.TipoviKorisnika.SERVISER)
                    serviseri.Add(korisnik);
            }
            InitializeComponent();
            comboBox1.DisplayMember = "imeIPrezime";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            if (comboBox2.Text == "Svi")
            {
                comboBox1.DataSource = svi;
            }
            if (comboBox2.Text == "Radnik za šalterom")
            {
                comboBox1.DataSource = salterasi;
            }
            if (comboBox2.Text == "Menadžer")
            {
                comboBox1.DataSource = menadzeri;

            }
            if (comboBox2.Text == "Serviser")
            {
                comboBox1.DataSource = serviseri;
            }
                
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            d.terminirajKonekciju();
            Close();
        }
        private void NovaPoruka_Load(object sender, EventArgs e)
        {
            
        }

        private void b_posalji_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Izaberite primaoca");
            else if (richTextBox1.Text == "")
                MessageBox.Show("Unesite poruku");
             else
             {
                 try
                 {
                     DAL.Entiteti.Korisnik prima = comboBox1.SelectedItem as DAL.Entiteti.Korisnik;
                     DAL.Entiteti.Poruka poslati = new DAL.Entiteti.Poruka(richTextBox1.Text, ks.Username, prima.Username, DateTime.Now);
                     DAL.DAL.PorukeDAO kd = d.getDAO.getPorukeDAO();

                     poslati.SifraPoruke = kd.create(poslati);
                     MessageBox.Show("Poruka je poslana");
                     richTextBox1.Text = "";
                 }
                 catch (Exception ee)
                 {
                     MessageBox.Show(ee.Message);
                 }
               
                
             }
        }
    }
}
