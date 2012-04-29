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
        DAL.DAL d = DAL.DAL.Instanca;
        DAL.DAL.PorukeDAO pd = new DAL.DAL.PorukeDAO();
        List<DAL.Entiteti.Poruka> primljene;
        List<DAL.Entiteti.Poruka> poslane;
        public aplikacijaPoruke(DAL.Entiteti.Korisnik k)
        {
            
            
            InitializeComponent();
            primljene = new List<DAL.Entiteti.Poruka>();
            primljene = pd.getByExample("idPrimaoca", Convert.ToString(k.SifraKorisnika));

            poslane = new List<DAL.Entiteti.Poruka>();
            poslane = pd.getByExample("id.Posiljaoca", Convert.ToString(k.SifraKorisnika));

            foreach (DAL.Entiteti.Poruka p in primljene)
            {
                System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                l.AutoSize = true;
                l.Name = "label1";

                l.TabIndex = 0;
                l.Text = p.Posiljaoc;
                this.panel1.Controls.Add(l);
                MessageBox.Show("ima poruka");


            }
            

        }

        private void aplikacijaPoruke_Load(object sender, EventArgs e)
        {
            d.kreirajKonekciju();
        }

        private void b_Izadi_Click(object sender, EventArgs e)
        {
            d.terminirajKonekciju();
            Close();
        }
    }
}
