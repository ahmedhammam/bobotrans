namespace DesktopAplikacija.Menadzer
{
    partial class UredjivanjeLinije
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.gbStanice = new System.Windows.Forms.GroupBox();
            this.gbDodajStanicu = new System.Windows.Forms.GroupBox();
            this.btnDodajStanicu = new System.Windows.Forms.Button();
            this.tbPolazak = new System.Windows.Forms.TextBox();
            this.tbDolazak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRedniBroj = new System.Windows.Forms.ComboBox();
            this.lblRedniBroj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStanice = new System.Windows.Forms.ComboBox();
            this.lvStanice = new System.Windows.Forms.ListView();
            this.colSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMjesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrajanjeDoDolaska = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrajanjeDoPolaska = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCijene = new System.Windows.Forms.GroupBox();
            this.dgvCijene = new System.Windows.Forms.DataGridView();
            this.gbRasporedi = new System.Windows.Forms.GroupBox();
            this.lvRasporedi = new System.Windows.Forms.ListView();
            this.colSifraRasporeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVrijemePolaska = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSjedista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSifraAutobusa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbStanice.SuspendLayout();
            this.gbDodajStanicu.SuspendLayout();
            this.gbCijene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijene)).BeginInit();
            this.gbRasporedi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNaziv);
            this.groupBox1.Controls.Add(this.lblNaziv);
            this.groupBox1.Controls.Add(this.lblSifra);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linija";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(53, 39);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(160, 20);
            this.tbNaziv.TabIndex = 2;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(6, 42);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(7, 20);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(34, 13);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "Šifra: ";
            // 
            // gbStanice
            // 
            this.gbStanice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStanice.Controls.Add(this.gbDodajStanicu);
            this.gbStanice.Controls.Add(this.lvStanice);
            this.gbStanice.Location = new System.Drawing.Point(13, 92);
            this.gbStanice.Name = "gbStanice";
            this.gbStanice.Size = new System.Drawing.Size(955, 231);
            this.gbStanice.TabIndex = 1;
            this.gbStanice.TabStop = false;
            this.gbStanice.Text = "Stanice";
            // 
            // gbDodajStanicu
            // 
            this.gbDodajStanicu.Controls.Add(this.btnDodajStanicu);
            this.gbDodajStanicu.Controls.Add(this.tbPolazak);
            this.gbDodajStanicu.Controls.Add(this.tbDolazak);
            this.gbDodajStanicu.Controls.Add(this.label3);
            this.gbDodajStanicu.Controls.Add(this.label2);
            this.gbDodajStanicu.Controls.Add(this.cbRedniBroj);
            this.gbDodajStanicu.Controls.Add(this.lblRedniBroj);
            this.gbDodajStanicu.Controls.Add(this.label1);
            this.gbDodajStanicu.Controls.Add(this.cbStanice);
            this.gbDodajStanicu.Location = new System.Drawing.Point(571, 20);
            this.gbDodajStanicu.Name = "gbDodajStanicu";
            this.gbDodajStanicu.Size = new System.Drawing.Size(277, 159);
            this.gbDodajStanicu.TabIndex = 1;
            this.gbDodajStanicu.TabStop = false;
            this.gbDodajStanicu.Text = "Dodaj stanicu";
            // 
            // btnDodajStanicu
            // 
            this.btnDodajStanicu.Location = new System.Drawing.Point(195, 127);
            this.btnDodajStanicu.Name = "btnDodajStanicu";
            this.btnDodajStanicu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStanicu.TabIndex = 8;
            this.btnDodajStanicu.Text = "Dodaj";
            this.btnDodajStanicu.UseVisualStyleBackColor = true;
            this.btnDodajStanicu.Click += new System.EventHandler(this.btnDodajStanicu_Click);
            // 
            // tbPolazak
            // 
            this.tbPolazak.Location = new System.Drawing.Point(142, 101);
            this.tbPolazak.Name = "tbPolazak";
            this.tbPolazak.Size = new System.Drawing.Size(128, 20);
            this.tbPolazak.TabIndex = 7;
            this.tbPolazak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinute_KeyPress);
            // 
            // tbDolazak
            // 
            this.tbDolazak.Location = new System.Drawing.Point(141, 76);
            this.tbDolazak.Name = "tbDolazak";
            this.tbDolazak.Size = new System.Drawing.Size(129, 20);
            this.tbDolazak.TabIndex = 6;
            this.tbDolazak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinute_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trajanje do polaska (min):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trajanje do dolaska (min):";
            // 
            // cbRedniBroj
            // 
            this.cbRedniBroj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRedniBroj.FormattingEnabled = true;
            this.cbRedniBroj.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbRedniBroj.Location = new System.Drawing.Point(141, 48);
            this.cbRedniBroj.Name = "cbRedniBroj";
            this.cbRedniBroj.Size = new System.Drawing.Size(129, 21);
            this.cbRedniBroj.TabIndex = 3;
            // 
            // lblRedniBroj
            // 
            this.lblRedniBroj.AutoSize = true;
            this.lblRedniBroj.Location = new System.Drawing.Point(9, 51);
            this.lblRedniBroj.Name = "lblRedniBroj";
            this.lblRedniBroj.Size = new System.Drawing.Size(123, 13);
            this.lblRedniBroj.TabIndex = 2;
            this.lblRedniBroj.Text = "Redni broj stanice u liniji:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova stanica:";
            // 
            // cbStanice
            // 
            this.cbStanice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStanice.FormattingEnabled = true;
            this.cbStanice.Location = new System.Drawing.Point(85, 17);
            this.cbStanice.Name = "cbStanice";
            this.cbStanice.Size = new System.Drawing.Size(186, 21);
            this.cbStanice.TabIndex = 0;
            // 
            // lvStanice
            // 
            this.lvStanice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSifra,
            this.colNaziv,
            this.colMjesto,
            this.colTrajanjeDoDolaska,
            this.colTrajanjeDoPolaska});
            this.lvStanice.FullRowSelect = true;
            this.lvStanice.Location = new System.Drawing.Point(7, 20);
            this.lvStanice.MultiSelect = false;
            this.lvStanice.Name = "lvStanice";
            this.lvStanice.Size = new System.Drawing.Size(557, 205);
            this.lvStanice.TabIndex = 0;
            this.lvStanice.UseCompatibleStateImageBehavior = false;
            this.lvStanice.View = System.Windows.Forms.View.Details;
            this.lvStanice.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvStanice_ColumnWidthChanging);
            // 
            // colSifra
            // 
            this.colSifra.Text = "Šifra";
            // 
            // colNaziv
            // 
            this.colNaziv.Text = "Naziv stanice";
            this.colNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNaziv.Width = 159;
            // 
            // colMjesto
            // 
            this.colMjesto.Text = "Mjesto";
            this.colMjesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMjesto.Width = 115;
            // 
            // colTrajanjeDoDolaska
            // 
            this.colTrajanjeDoDolaska.Text = "Trajanje do dolaska";
            this.colTrajanjeDoDolaska.Width = 105;
            // 
            // colTrajanjeDoPolaska
            // 
            this.colTrajanjeDoPolaska.Text = "Trajanje do polaska";
            this.colTrajanjeDoPolaska.Width = 112;
            // 
            // gbCijene
            // 
            this.gbCijene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCijene.Controls.Add(this.dgvCijene);
            this.gbCijene.Location = new System.Drawing.Point(13, 330);
            this.gbCijene.Name = "gbCijene";
            this.gbCijene.Size = new System.Drawing.Size(961, 235);
            this.gbCijene.TabIndex = 2;
            this.gbCijene.TabStop = false;
            this.gbCijene.Text = "Cijene";
            // 
            // dgvCijene
            // 
            this.dgvCijene.AllowUserToAddRows = false;
            this.dgvCijene.AllowUserToDeleteRows = false;
            this.dgvCijene.AllowUserToResizeColumns = false;
            this.dgvCijene.AllowUserToResizeRows = false;
            this.dgvCijene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCijene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCijene.Location = new System.Drawing.Point(7, 20);
            this.dgvCijene.Name = "dgvCijene";
            this.dgvCijene.RowHeadersWidth = 180;
            this.dgvCijene.Size = new System.Drawing.Size(948, 204);
            this.dgvCijene.TabIndex = 0;
            // 
            // gbRasporedi
            // 
            this.gbRasporedi.Controls.Add(this.lvRasporedi);
            this.gbRasporedi.Location = new System.Drawing.Point(13, 572);
            this.gbRasporedi.Name = "gbRasporedi";
            this.gbRasporedi.Size = new System.Drawing.Size(735, 230);
            this.gbRasporedi.TabIndex = 3;
            this.gbRasporedi.TabStop = false;
            this.gbRasporedi.Text = "Rasporedi vožnji";
            // 
            // lvRasporedi
            // 
            this.lvRasporedi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSifraRasporeda,
            this.colDan,
            this.colVrijemePolaska,
            this.colSjedista,
            this.colSifraAutobusa});
            this.lvRasporedi.FullRowSelect = true;
            this.lvRasporedi.Location = new System.Drawing.Point(9, 20);
            this.lvRasporedi.Name = "lvRasporedi";
            this.lvRasporedi.Size = new System.Drawing.Size(436, 204);
            this.lvRasporedi.TabIndex = 0;
            this.lvRasporedi.UseCompatibleStateImageBehavior = false;
            this.lvRasporedi.View = System.Windows.Forms.View.Details;
            this.lvRasporedi.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvRasporedi_ColumnWidthChanging);
            // 
            // colSifraRasporeda
            // 
            this.colSifraRasporeda.Text = "Šifra";
            // 
            // colDan
            // 
            this.colDan.Text = "Dan u sedmici";
            this.colDan.Width = 83;
            // 
            // colVrijemePolaska
            // 
            this.colVrijemePolaska.Text = "Vrijeme polaska";
            this.colVrijemePolaska.Width = 90;
            // 
            // colSjedista
            // 
            this.colSjedista.Text = "Potreban broj sjedista";
            this.colSjedista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSjedista.Width = 115;
            // 
            // colSifraAutobusa
            // 
            this.colSifraAutobusa.Text = "Šifra autobusa";
            this.colSifraAutobusa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSifraAutobusa.Width = 82;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzadji.Location = new System.Drawing.Point(897, 818);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpasi.Location = new System.Drawing.Point(816, 818);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 5;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // UredjivanjeLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 859);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.gbRasporedi);
            this.Controls.Add(this.gbCijene);
            this.Controls.Add(this.gbStanice);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 806);
            this.Name = "UredjivanjeLinije";
            this.Text = "UređivanjeLinije";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStanice.ResumeLayout(false);
            this.gbDodajStanicu.ResumeLayout(false);
            this.gbDodajStanicu.PerformLayout();
            this.gbCijene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijene)).EndInit();
            this.gbRasporedi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.GroupBox gbStanice;
        private System.Windows.Forms.ListView lvStanice;
        private System.Windows.Forms.ColumnHeader colSifra;
        private System.Windows.Forms.ColumnHeader colNaziv;
        private System.Windows.Forms.ColumnHeader colMjesto;
        private System.Windows.Forms.GroupBox gbCijene;
        private System.Windows.Forms.DataGridView dgvCijene;
        private System.Windows.Forms.ColumnHeader colTrajanjeDoDolaska;
        private System.Windows.Forms.ColumnHeader colTrajanjeDoPolaska;
        private System.Windows.Forms.GroupBox gbRasporedi;
        private System.Windows.Forms.ListView lvRasporedi;
        private System.Windows.Forms.ColumnHeader colSifraRasporeda;
        private System.Windows.Forms.ColumnHeader colDan;
        private System.Windows.Forms.ColumnHeader colVrijemePolaska;
        private System.Windows.Forms.ColumnHeader colSjedista;
        private System.Windows.Forms.ColumnHeader colSifraAutobusa;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.GroupBox gbDodajStanicu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStanice;
        private System.Windows.Forms.ComboBox cbRedniBroj;
        private System.Windows.Forms.Label lblRedniBroj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPolazak;
        private System.Windows.Forms.TextBox tbDolazak;
        private System.Windows.Forms.Button btnDodajStanicu;
    }
}