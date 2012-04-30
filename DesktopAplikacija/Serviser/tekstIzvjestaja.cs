using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopAplikacija.Serviser
{
    public partial class tekstIzvjestaja : Form
    {
        string str;
        public tekstIzvjestaja(string s)
        {
            InitializeComponent();
            str = s;
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tekstIzvjestaja_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = str;
        }
    }
}
