namespace DesktopAplikacija.RadnikZaSalterom
{
    partial class PreuzimanjeInternetRezervacije
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
            this.btnStampaj = new System.Windows.Forms.Button();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(68, 66);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(102, 31);
            this.btnStampaj.TabIndex = 0;
            this.btnStampaj.Text = "Štampaj";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(68, 28);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(189, 20);
            this.tbSifra.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Šifra:";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(176, 66);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(81, 31);
            this.btnIzadji.TabIndex = 45;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // PreuzimanjeInternetRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 120);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStampaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreuzimanjeInternetRezervacije";
            this.Text = "Preuzimanje Internet Rezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzadji;
    }
}