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
        DAL.DAL d;
        DAL.DAL.KorisnikDAO kd;
        DAL.Entiteti.Korisnik ks;
        List<DAL.Entiteti.Korisnik> svi;
        List<DAL.Entiteti.Korisnik> salterasi;
        List<DAL.Entiteti.Korisnik> menadzeri;
        List<DAL.Entiteti.Korisnik> serviseri;
        

        
        public NovaPoruka(DAL.Entiteti.Korisnik k)
        {
            try
            {
                d = DAL.DAL.Instanca;
                d.kreirajKonekciju();
                kd = d.getDAO.getKorisnikDAO();
                svi = kd.GetAll();
                salterasi = kd.getByExample("tip",Convert.ToString(1));
                menadzeri = kd.getByExample("tip", Convert.ToString(2));
                serviseri = kd.getByExample("tip", Convert.ToString(3));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            InitializeComponent();
            ks = k;
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            if (comboBox2.Text == "Svi")
            {
                comboBox1.Items.Clear();
                foreach (DAL.Entiteti.Korisnik k in svi)
                    comboBox1.Items.Add(k.ToString());
            }
            if (comboBox2.Text == "Radnik za šalterom")
            {
                comboBox1.Items.Clear();
                foreach (DAL.Entiteti.Korisnik k in salterasi)
                    comboBox1.Items.Add(k.ToString());
            }
            if (comboBox2.Text == "Menadžer")
            {
                comboBox1.Items.Clear();
                foreach (DAL.Entiteti.Korisnik k in menadzeri)
                    comboBox1.Items.Add(k.ToString());
            }
            if (comboBox2.Text == "Serviser")
            {
                comboBox1.Items.Clear();
                foreach (DAL.Entiteti.Korisnik k in serviseri)
                    comboBox1.Items.Add(k.ToString());
            }
                


        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            d.terminirajKonekciju();
            Close();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
           
            
        }

        private void NovaPoruka_Load(object sender, EventArgs e)
        {
            foreach (DAL.Entiteti.Korisnik k in svi)
                comboBox1.Items.Add(k.ToString());
        }

        private void b_posalji_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Izaberite primaoca");
            else if (richTextBox1.Text == "")
                MessageBox.Show("Unesite poruku");
            /* else
             {
                 DAL.Entiteti.Korisnik prima;
                 foreach (DAL.Entiteti.Korisnik k in svi)
                 {
                     if (k.ImeIPrezime == comboBox1.Text)
                     {
                          prima = k;
                          try
                          {
                             
                              DAL.Entiteti.Poruka poslati = new DAL.Entiteti.Poruka(richTextBox1.Text, ks.Username, prima.Username, DateTime.Now);
                              DAL.DAL.PorukeDAO pd = d.getDAO.getPorukeDAO();

                              poslati.SifraPoruke = pd.create(poslati);
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                        
                         break;
                     }
                     }
                

                
             }*/
        }
    }
}
