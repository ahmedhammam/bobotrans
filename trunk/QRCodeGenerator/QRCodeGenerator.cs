using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnBarcode.Barcode;

namespace QRCodeGenerator
{
    public partial class QRCodeGenerator : Form
    {
        public static Bitmap dajQRCode(string sifra, float velicina_pixela=3, int rezolucija = 72)
        {
            QRCode barkod = new QRCode();
            barkod.Data = sifra;
            barkod.DataMode = QRCodeDataMode.AlphaNumeric;

            barkod.UOM = UnitOfMeasure.PIXEL;
            barkod.X = velicina_pixela;
            barkod.Resolution = rezolucija;

            return barkod.drawBarcode();
            
        }
    }
}
