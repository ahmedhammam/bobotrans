using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.google.zxing;
using com.google.zxing.common;
using System.Diagnostics;

using System.Threading;

using OnBarcode.Barcode.BarcodeScanner;

namespace QRCodeReader
{
    public partial class QRCodeReader : Form
    {
        private WebCam webcam;
        private bool dekodirao = false;

        public QRCodeReader()
        {
            InitializeComponent();
            BarCodeDetectTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pbCamera);
        }

        private void stnStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
            dekodirao = false;
            BarCodeDetectTimer.Start();
            lblStatus.Text = "Pokrenuta kamera";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            BarCodeDetectTimer.Stop();
            dekodirao = true;
            lblStatus.Text = "Zaustavljena kamera";
        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void btnIzborKamere_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            dekodirao = false;
            webcam.Continue();
            lblStatus.Text = "Nastavljeno skeniranje";
        }

        private void btnUslikaj_Click(object sender, EventArgs e)
        {
            pbSlika.Image = pbCamera.Image;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pbSlika.Image == null)
            {
                MessageBox.Show("Niste uslikali ništa!");
                return;
            }
            btnStop_Click(null, null);
            dekodirao = false;
            try
            {
                Bitmap img2 = (Bitmap)pbCamera.Image;
                Reader reader = new MultiFormatReader();
                RGBLuminanceSource source1 = new RGBLuminanceSource(img2, img2.Width, img2.Height);
                BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source1));

                Result result = reader.decode(bitmap);
                if (!dekodirao)
                {
                    dekodirao = true;
                    MessageBox.Show("Dekodirao sam: " + result.Text);
                }
                //BarCodeDetectTimer.Stop();

            }
            catch (Exception e1)
            {
                MessageBox.Show("GRESKA: (vjerovatno je slika lose kvalitete, probaj rotirati) - nisam uspio prepoznati sliku");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            webcam.Stop();
            BarCodeDetectTimer.Stop();
        }


        void skenirajSliku()
        {
            try
            {
                Bitmap img2 = (Bitmap)pbCamera.Image;
                Reader reader = new MultiFormatReader();
                RGBLuminanceSource source1 = new RGBLuminanceSource(img2, img2.Width, img2.Height);
                BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source1));

                Result result = reader.decode(bitmap);
                if (!dekodirao)
                {
                    dekodirao = true;
                    btnStop_Click(null, null);
                    MessageBox.Show("Dekodirao sam: " + result.Text);
                }
                else
                {
                    btnStop_Click(null, null);
                }

            }
            catch (Exception e1)
            {
                Console.WriteLine("GRESKA: (vjerovatno je slika lose kvalitete, probaj rotirati) - tj. nisam uspio prepoznati sliku");
            }
        }

        private void BarCodeDetectTimer_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(skenirajSliku));
            thread.Start();
        }
    }
}
