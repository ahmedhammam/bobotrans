namespace QRCodeReader
{
    partial class QRCodeReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeReader));
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPostavke = new System.Windows.Forms.Button();
            this.btnIzborKamere = new System.Windows.Forms.Button();
            this.btnUslikaj = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.BarCodeDetectTimer = new System.Windows.Forms.Timer(this.components);
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(23, 12);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(412, 337);
            this.pbCamera.TabIndex = 0;
            this.pbCamera.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 355);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(37, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.stnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(66, 355);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(37, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPostavke
            // 
            this.btnPostavke.Location = new System.Drawing.Point(338, 355);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(97, 23);
            this.btnPostavke.TabIndex = 3;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.UseVisualStyleBackColor = true;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            // 
            // btnIzborKamere
            // 
            this.btnIzborKamere.Location = new System.Drawing.Point(338, 385);
            this.btnIzborKamere.Name = "btnIzborKamere";
            this.btnIzborKamere.Size = new System.Drawing.Size(97, 23);
            this.btnIzborKamere.TabIndex = 4;
            this.btnIzborKamere.Text = "Izbor kamere";
            this.btnIzborKamere.UseVisualStyleBackColor = true;
            this.btnIzborKamere.Click += new System.EventHandler(this.btnIzborKamere_Click);
            // 
            // btnUslikaj
            // 
            this.btnUslikaj.Location = new System.Drawing.Point(23, 384);
            this.btnUslikaj.Name = "btnUslikaj";
            this.btnUslikaj.Size = new System.Drawing.Size(138, 25);
            this.btnUslikaj.TabIndex = 5;
            this.btnUslikaj.Text = "Uslikaj";
            this.btnUslikaj.UseVisualStyleBackColor = true;
            this.btnUslikaj.Click += new System.EventHandler(this.btnUslikaj_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 25);
            this.button6.TabIndex = 6;
            this.button6.Text = "Skeniraj uslikanu sliku";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnNastavi
            // 
            this.btnNastavi.Location = new System.Drawing.Point(109, 355);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(52, 23);
            this.btnNastavi.TabIndex = 8;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = true;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(169, 358);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(157, 81);
            this.pbSlika.TabIndex = 9;
            this.pbSlika.TabStop = false;
            // 
            // BarCodeDetectTimer
            // 
            this.BarCodeDetectTimer.Enabled = true;
            this.BarCodeDetectTimer.Interval = 500;
            this.BarCodeDetectTimer.Tick += new System.EventHandler(this.BarCodeDetectTimer_Tick);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 459);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(449, 22);
            this.ssStatus.TabIndex = 10;
            this.ssStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 17);
            this.lblStatus.Text = "Kamera nije pokrenuta";
            // 
            // QRCodeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 481);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnUslikaj);
            this.Controls.Add(this.btnIzborKamere);
            this.Controls.Add(this.btnPostavke);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbCamera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRCodeReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Čitač QR koda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.Button btnIzborKamere;
        private System.Windows.Forms.Button btnUslikaj;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Timer BarCodeDetectTimer;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

