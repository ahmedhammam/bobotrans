namespace DesktopAplikacija.Informisanje
{
    partial class InformisanjeVoznje
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
            this.lblSifraLinije = new System.Windows.Forms.Label();
            this.dgvVremena = new System.Windows.Forms.DataGridView();
            this.colVrijemeDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLinija = new System.Windows.Forms.GroupBox();
            this.lblBrojVoznji = new System.Windows.Forms.Label();
            this.cbVoznje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVremena)).BeginInit();
            this.gbLinija.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSifraLinije
            // 
            this.lblSifraLinije.AutoSize = true;
            this.lblSifraLinije.Location = new System.Drawing.Point(6, 16);
            this.lblSifraLinije.Name = "lblSifraLinije";
            this.lblSifraLinije.Size = new System.Drawing.Size(54, 13);
            this.lblSifraLinije.TabIndex = 1;
            this.lblSifraLinije.Text = "Šifra linije:";
            // 
            // dgvVremena
            // 
            this.dgvVremena.AllowUserToAddRows = false;
            this.dgvVremena.AllowUserToDeleteRows = false;
            this.dgvVremena.AllowUserToOrderColumns = true;
            this.dgvVremena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvVremena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVremena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVrijemeDolaska,
            this.colVrijemePolaska});
            this.dgvVremena.Location = new System.Drawing.Point(16, 96);
            this.dgvVremena.Name = "dgvVremena";
            this.dgvVremena.ReadOnly = true;
            this.dgvVremena.RowHeadersWidth = 180;
            this.dgvVremena.Size = new System.Drawing.Size(320, 166);
            this.dgvVremena.TabIndex = 2;
            // 
            // colVrijemeDolaska
            // 
            this.colVrijemeDolaska.HeaderText = "Vrijeme dolaska";
            this.colVrijemeDolaska.Name = "colVrijemeDolaska";
            this.colVrijemeDolaska.ReadOnly = true;
            this.colVrijemeDolaska.Width = 60;
            // 
            // colVrijemePolaska
            // 
            this.colVrijemePolaska.HeaderText = "Vrijeme polaska";
            this.colVrijemePolaska.Name = "colVrijemePolaska";
            this.colVrijemePolaska.ReadOnly = true;
            this.colVrijemePolaska.Width = 60;
            // 
            // gbLinija
            // 
            this.gbLinija.Controls.Add(this.lblBrojVoznji);
            this.gbLinija.Controls.Add(this.lblSifraLinije);
            this.gbLinija.Location = new System.Drawing.Point(12, 12);
            this.gbLinija.Name = "gbLinija";
            this.gbLinija.Size = new System.Drawing.Size(170, 49);
            this.gbLinija.TabIndex = 3;
            this.gbLinija.TabStop = false;
            this.gbLinija.Text = "Linija";
            // 
            // lblBrojVoznji
            // 
            this.lblBrojVoznji.AutoSize = true;
            this.lblBrojVoznji.Location = new System.Drawing.Point(6, 29);
            this.lblBrojVoznji.Name = "lblBrojVoznji";
            this.lblBrojVoznji.Size = new System.Drawing.Size(58, 13);
            this.lblBrojVoznji.TabIndex = 2;
            this.lblBrojVoznji.Text = "Broj vožnji:";
            // 
            // cbVoznje
            // 
            this.cbVoznje.FormattingEnabled = true;
            this.cbVoznje.Location = new System.Drawing.Point(180, 67);
            this.cbVoznje.Name = "cbVoznje";
            this.cbVoznje.Size = new System.Drawing.Size(148, 21);
            this.cbVoznje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prikaži podatke za vožnju:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrikazi.Location = new System.Drawing.Point(180, 267);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIzadji.Location = new System.Drawing.Point(263, 267);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // InformisanjeVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 302);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVoznje);
            this.Controls.Add(this.gbLinija);
            this.Controls.Add(this.dgvVremena);
            this.MaximumSize = new System.Drawing.Size(366, 999999);
            this.MinimumSize = new System.Drawing.Size(366, 340);
            this.Name = "InformisanjeVoznje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformisanjeVoznje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVremena)).EndInit();
            this.gbLinija.ResumeLayout(false);
            this.gbLinija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifraLinije;
        private System.Windows.Forms.DataGridView dgvVremena;
        private System.Windows.Forms.GroupBox gbLinija;
        private System.Windows.Forms.ComboBox cbVoznje;
        private System.Windows.Forms.Label lblBrojVoznji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijemeDolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijemePolaska;
    }
}