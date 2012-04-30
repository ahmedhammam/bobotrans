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
        private List<DAL.Entiteti.Poruka> primljene;
        private List<DAL.Entiteti.Poruka> poslane;
        public aplikacijaPoruke(DAL.Entiteti.Korisnik k)
        {
            d.kreirajKonekciju();
            pd = d.getDAO.getPorukeDAO();

            InitializeComponent();
            primljene = pd.getByExample("idPrimaoca", Convert.ToString(k.SifraKorisnika.ToString()));
            poslane = pd.getByExample("idPosiljaoca", Convert.ToString(k.SifraKorisnika.ToString()));
            int x = 0, y = 0;
            foreach (DAL.Entiteti.Poruka p in primljene)
            {
                System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                l.AutoSize = true;
                l.Location = new Point(10 + x, 10 + y);
                l.TabIndex = 0;
                l.Text = p.Posiljaoc;
                this.panel1.Controls.Add(l);

            }
            

        }

        private void aplikacijaPoruke_Load(object sender, EventArgs e)
        {
        }

        private void b_Izadi_Click(object sender, EventArgs e)
        {
            d.terminirajKonekciju();
            Close();
        }
    }
}
