using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;



namespace DesktopAplikacija.Poruke
{
    public partial class aplikacijaPoruke : Form
    {
        private DAL.DAL d = DAL.DAL.Instanca;
        private DAL.DAL.PorukeDAO pd;
        private DAL.DAL.KorisnikDAO kd;
        private List<DAL.Entiteti.Poruka> primljene;
        private List<DAL.Entiteti.Poruka> poslane;
        private List<DAL.Entiteti.Korisnik> korisnici;
        private DAL.Entiteti.Korisnik logovani;

        public aplikacijaPoruke(DAL.Entiteti.Korisnik k)
        {
            try
            {
                d.kreirajKonekciju();
                pd = d.getDAO.getPorukeDAO();
                kd = d.getDAO.getKorisnikDAO();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();

            try
            {
                primljene = pd.getByExample("idPrimaoca", k.SifraKorisnika.ToString());
                poslane = pd.getByExample("idPosiljaoca", k.SifraKorisnika.ToString());
                korisnici = kd.GetAll();
                logovani = k;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            int x = 0, y = 0, i=0;
            
            foreach (DAL.Entiteti.Poruka p in primljene)
            {
                System.Windows.Forms.CheckBox l = new System.Windows.Forms.CheckBox();
                l.AutoSize = true;
                l.Location = new Point(10 + x, 10 + y);
                l.TabIndex = 0;
                l.Tag = i++;
                l.Text = p.ImeIDatumPrimljenih();
                this.panel1.Controls.Add(l);
                y = y + 20;
            }
            

        }

        private void aplikacijaPoruke_Load(object sender, EventArgs e)
        {
            foreach (DAL.Entiteti.Korisnik k in korisnici)
                toolStripComboBox1.Items.Add(k.ImeIPrezime);
        }

        private void b_Izadi_Click(object sender, EventArgs e)
        {
            d.terminirajKonekciju();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           int a;
            foreach (CheckBox o in panel1.Controls)
            {
                
                if (o.Checked)
                {
                    a = (int)o.Tag;
                    MessageBox.Show(Convert.ToString(a));
                    if (!richTextBox1.Enabled)
                        richTextBox1.Enabled = true;

                    DAL.Entiteti.Poruka c = primljene[a];
                    richTextBox1.Text = c.Tekst;
                    break;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {int a;
        bool pom = false;
        int brojac = 0;
        foreach (CheckBox o in panel1.Controls)
        {
            if (o.Checked)
            {
                
                a = (int)o.Tag;
                MessageBox.Show(Convert.ToString(a));
                if (pom)
                {
                    if (a > brojac)
                        a--;
                }
                primljene.RemoveAt(a);
                MessageBox.Show(Convert.ToString(primljene.Count));
                foreach (DAL.Entiteti.Poruka p in primljene)
                    MessageBox.Show(p.Posiljaoc);
                pom = true;
            }
        }
        if (pom)
        {
            panel1.Controls.Clear();
            if (richTextBox1.Enabled)
            {
                richTextBox1.Text = "";
                richTextBox1.Enabled = false;
            }

            //ne znam sto nece da crta ..crtao je juce..:S
            int x = 0, y = 0, i = 0;
            foreach (DAL.Entiteti.Poruka p in primljene)
            {
                MessageBox.Show(p.Posiljaoc);
                System.Windows.Forms.CheckBox l = new System.Windows.Forms.CheckBox();
                l.AutoSize = true;
                l.Location = new Point(10 + x, 10 + y);
                l.TabIndex = 0;
                l.Tag = i++;
                l.Text = p.ImeIDatumPrimljenih();
                this.panel1.Controls.Add(l);
                y = y + 20;
            }

           
        }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (richTextBox1.Enabled)
            {
                richTextBox1.Text = "";
                richTextBox1.Enabled = false;
            }
            int x = 0, y = 0, i = 0;

            foreach (DAL.Entiteti.Poruka p in poslane)
            {
                System.Windows.Forms.CheckBox l = new System.Windows.Forms.CheckBox();
                l.AutoSize = true;
                l.Location = new Point(10 + x, 10 + y);
                l.TabIndex = 0;
                l.Text = p.ImeIDatumPrimljenih();
                l.Tag = i++;

                this.panel1.Controls.Add(l);

                y = y + 20;
            }
        }

        private void primljeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (richTextBox1.Enabled)
            {
                richTextBox1.Text = "";
                richTextBox1.Enabled = false;
            }
            int x = 0, y = 0, i = 0;

            foreach (DAL.Entiteti.Poruka p in primljene)
            {
                System.Windows.Forms.CheckBox l = new System.Windows.Forms.CheckBox();
                l.AutoSize = true;
                l.Location = new Point(10 + x, 10 + y);
                l.TabIndex = 0;
                l.Text = p.ImeIDatumPrimljenih();
                l.Tag = i++;

                this.panel1.Controls.Add(l);

                y = y + 20;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in panel1.Controls)
             {
                 //cekiratii sve
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (toolStripComboBox1.Text == "")
                MessageBox.Show("Izaberite radnika");
            else
            {
                int x = 0, y = 0, i = 0;
                foreach(DAL.Entiteti.Poruka p in primljene)
                {
                    if (p.Posiljaoc == toolStripComboBox1.Text)
                    {
                        System.Windows.Forms.CheckBox l = new System.Windows.Forms.CheckBox();
                        l.AutoSize = true;
                        l.Location = new Point(10 + x, 10 + y);
                        l.TabIndex = 0;
                        l.Text = p.ImeIDatumPrimljenih();
                        l.Tag = i++;

                        this.panel1.Controls.Add(l);

                        y = y + 20;
                }
                
                }
                
                
                
                
                }



        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
            if (toolStripComboBox1.Text == "")
                MessageBox.Show("Izaberite radnika");
            else
            {
                panel1.Controls.Clear();
                int x = 0, y = 0, i = 0;
                foreach (DAL.Entiteti.Poruka p in poslane)
                {
                    if (p.Primalac == toolStripComboBox1.Text)
                    {
                        System.Windows.Forms.CheckBox l = new System.Windows.Forms.CheckBox();
                        l.AutoSize = true;
                        l.Location = new Point(10 + x, 10 + y);
                        l.TabIndex = 0;
                        l.Text = p.ImeIDatumPrimljenih();
                        l.Tag = i++;

                        this.panel1.Controls.Add(l);

                        y = y + 20;
                    }

                }




            }



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NovaPoruka np = new NovaPoruka(logovani,korisnici);
            np.Show();
        }
        
            
        
    }
}
