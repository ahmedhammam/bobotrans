using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using DAL;
using DesktopAplikacija.Serviser;
using DesktopAplikacija.RadnikZaSalterom;

namespace DesktopAplikacija
{
    public partial class Login : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        public Login()
        {
                InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                try
                {
                   
                    DAL.DAL.KorisnikDAO kd = d.getDAO.getKorisnikDAO();
                    DAL.Entiteti.Korisnik k = kd.getByUsernameAndPassword(t_nazivKorisnika.Text, t_sifraKorisnika.Text);
                    

                    if (k.Tip == DAL.TipoviPodataka.TipoviKorisnika.MENAGER)
                    {
                        Menadzer.AplikacijaMenadzer am = new Menadzer.AplikacijaMenadzer(k,this);
                        am.FormClosed += new System.Windows.Forms.FormClosedEventHandler(brisiSve);
                        am.Show();
                    }
                    if (k.Tip == DAL.TipoviPodataka.TipoviKorisnika.RADNIK_ZA_SALTEROM)
                    {
                        aplikacijaSalter a=new aplikacijaSalter(k,this);
                        a.FormClosed += new System.Windows.Forms.FormClosedEventHandler(brisiSve);
                        a.Show();
                    }
                    if (k.Tip == DAL.TipoviPodataka.TipoviKorisnika.SERVISER)
                    {
                        
                        ServiserAplikacija s = new ServiserAplikacija(k,this);
                        s.FormClosed += new System.Windows.Forms.FormClosedEventHandler(brisiSve);
                        s.Show();
                        
                    }

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    toolStripStatusLabel1.Text = e1.Message;
                }
            }
            
        }

        private void brisiSve(object sender, EventArgs e)
        {
            t_nazivKorisnika.Text = "";
            t_sifraKorisnika.Text = "";
        }

            
        

        private void t_nazivKorisnika_Validating(object sender, CancelEventArgs e)
        {
            if (t_nazivKorisnika.Text.Length < 3)
                errorProvider1.SetError(t_nazivKorisnika, "Unesite naziv");
            else
                errorProvider1.SetError(t_nazivKorisnika, "");
        }

        private void t_sifraKorisnika_Validating(object sender, CancelEventArgs e)
        {
            if (t_sifraKorisnika.Text.Length< 3)
                errorProvider1.SetError(t_sifraKorisnika, "Unestite šifru");
            else errorProvider1.SetError(t_sifraKorisnika, "");
        }

        private bool Validiraj()
        {
             if((errorProvider1.GetError(t_nazivKorisnika)=="")&&(errorProvider1.GetError(t_sifraKorisnika)==""))
                 return true;
             return false;
        
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


    
    
    }


    }

