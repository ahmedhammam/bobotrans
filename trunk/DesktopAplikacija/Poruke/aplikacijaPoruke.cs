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
        public aplikacijaPoruke()
        {
            primljene = new List<DAL.Entiteti.Poruka>();
            primljene = pd.getByExample("idPrimaoca", Convert.ToString(3));

            poslane = new List<DAL.Entiteti.Poruka>();
            
            InitializeComponent();
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
