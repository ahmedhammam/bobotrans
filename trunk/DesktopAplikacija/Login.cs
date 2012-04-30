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
                    //dok se naprave forme koje ce se otvarati stavila sam da mi ispisuje na toolStrioStatusLabel//
                    DAL.Entiteti.Korisnik k = kd.getByUsernameAndPassword(t_nazivKorisnika.Text, t_sifraKorisnika.Text);
                    DesktopAplikacija.Entiteti.LoginPodaci lg = new DesktopAplikacija.Entiteti.LoginPodaci(k.ImeIPrezime, k.Password);

                    if (k.Tip == DAL.TipoviPodataka.TipoviKorisnika.MENAGER)
                        toolStripStatusLabel1.Text = "logovani ste kao menager";
                    if (k.Tip == DAL.TipoviPodataka.TipoviKorisnika.RADNIK_ZA_SALTEROM)
                        toolStripStatusLabel1.Text = "logovani ste kao radnik";
                    if (k.Tip == DAL.TipoviPodataka.TipoviKorisnika.SERVISER)
                    {
                        
                        serviserAplikacija s = new serviserAplikacija(k.Password);
                        
                        s.Show();
                       
                    }


                }
                catch (Exception e1)
                { toolStripStatusLabel1.Text = e1.Message; }
            }
            
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
            d.kreirajKonekciju();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.terminirajKonekciju();
            Close();
        }
    
    
    
    }


    }

