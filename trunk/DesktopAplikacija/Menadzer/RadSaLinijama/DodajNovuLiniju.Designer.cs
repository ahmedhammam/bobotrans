namespace DesktopAplikacija.Menadzer
{
    partial class DodajNovuLiniju
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.dgvStanice = new System.Windows.Forms.DataGridView();
            this.colSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDolazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPolazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbStanice = new System.Windows.Forms.ComboBox();
            this.btnDodajStanicu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRednibroj = new System.Windows.Forms.ComboBox();
            this.rbPocetak = new System.Windows.Forms.RadioButton();
            this.rbPolozaj = new System.Windows.Forms.RadioButton();
            this.rbKraj = new System.Windows.Forms.RadioButton();
            this.btnUnosCijena = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnRasporedi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnBrisiStanice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(60, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv linije:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(78, 25);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(228, 20);
            this.tbNaziv.TabIndex = 1;
            // 
            // dgvStanice
            // 
            this.dgvStanice.AllowUserToAddRows = false;
            this.dgvStanice.AllowUserToDeleteRows = false;
            this.dgvStanice.AllowUserToResizeColumns = false;
            this.dgvStanice.AllowUserToResizeRows = false;
            this.dgvStanice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStanice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSifra,
            this.colNaziv,
            this.colDolazak,
            this.colPolazak});
            this.dgvStanice.Location = new System.Drawing.Point(7, 19);
            this.dgvStanice.Name = "dgvStanice";
            this.dgvStanice.RowHeadersWidth = 20;
            this.dgvStanice.Size = new System.Drawing.Size(425, 187);
            this.dgvStanice.TabIndex = 2;
            // 
            // colSifra
            // 
            this.colSifra.HeaderText = "Šifra stanice";
            this.colSifra.Name = "colSifra";
            this.colSifra.ReadOnly = true;
            // 
            // colNaziv
            // 
            this.colNaziv.HeaderText = "Naziv Stanice";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.ReadOnly = true;
            // 
            // colDolazak
            // 
            this.colDolazak.HeaderText = "Trajanje do dolaska";
            this.colDolazak.Name = "colDolazak";
            // 
            // colPolazak
            // 
            this.colPolazak.HeaderText = "Trajanje do polaska";
            this.colPolazak.Name = "colPolazak";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrisiStanice);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvStanice);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 225);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Stanice na liniji";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStanice);
            this.groupBox2.Controls.Add(this.btnDodajStanicu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbRednibroj);
            this.groupBox2.Controls.Add(this.rbPocetak);
            this.groupBox2.Controls.Add(this.rbPolozaj);
            this.groupBox2.Controls.Add(this.rbKraj);
            this.groupBox2.Location = new System.Drawing.Point(448, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 151);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje stanice:";
            // 
            // cbStanice
            // 
            this.cbStanice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStanice.FormattingEnabled = true;
            this.cbStanice.Location = new System.Drawing.Point(20, 17);
            this.cbStanice.Name = "cbStanice";
            this.cbStanice.Size = new System.Drawing.Size(211, 21);
            this.cbStanice.TabIndex = 4;
            // 
            // btnDodajStanicu
            // 
            this.btnDodajStanicu.Location = new System.Drawing.Point(200, 118);
            this.btnDodajStanicu.Name = "btnDodajStanicu";
            this.btnDodajStanicu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStanicu.TabIndex = 10;
            this.btnDodajStanicu.Text = "Dodaj";
            this.btnDodajStanicu.UseVisualStyleBackColor = true;
            this.btnDodajStanicu.Click += new System.EventHandler(this.btnDodajStanicu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Na položaj:";
            // 
            // cbRednibroj
            // 
            this.cbRednibroj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRednibroj.Enabled = false;
            this.cbRednibroj.FormattingEnabled = true;
            this.cbRednibroj.Location = new System.Drawing.Point(40, 120);
            this.cbRednibroj.Name = "cbRednibroj";
            this.cbRednibroj.Size = new System.Drawing.Size(60, 21);
            this.cbRednibroj.TabIndex = 9;
            // 
            // rbPocetak
            // 
            this.rbPocetak.AutoSize = true;
            this.rbPocetak.Location = new System.Drawing.Point(20, 77);
            this.rbPocetak.Name = "rbPocetak";
            this.rbPocetak.Size = new System.Drawing.Size(65, 17);
            this.rbPocetak.TabIndex = 6;
            this.rbPocetak.Text = "Početak";
            this.rbPocetak.UseVisualStyleBackColor = true;
            // 
            // rbPolozaj
            // 
            this.rbPolozaj.AutoSize = true;
            this.rbPolozaj.Location = new System.Drawing.Point(20, 123);
            this.rbPolozaj.Name = "rbPolozaj";
            this.rbPolozaj.Size = new System.Drawing.Size(14, 13);
            this.rbPolozaj.TabIndex = 8;
            this.rbPolozaj.UseVisualStyleBackColor = true;
            this.rbPolozaj.CheckedChanged += new System.EventHandler(this.rbPolozaj_CheckedChanged);
            // 
            // rbKraj
            // 
            this.rbKraj.AutoSize = true;
            this.rbKraj.Checked = true;
            this.rbKraj.Location = new System.Drawing.Point(20, 100);
            this.rbKraj.Name = "rbKraj";
            this.rbKraj.Size = new System.Drawing.Size(43, 17);
            this.rbKraj.TabIndex = 7;
            this.rbKraj.TabStop = true;
            this.rbKraj.Text = "Kraj";
            this.rbKraj.UseVisualStyleBackColor = true;
            // 
            // btnUnosCijena
            // 
            this.btnUnosCijena.Enabled = false;
            this.btnUnosCijena.Location = new System.Drawing.Point(27, 26);
            this.btnUnosCijena.Name = "btnUnosCijena";
            this.btnUnosCijena.Size = new System.Drawing.Size(75, 23);
            this.btnUnosCijena.TabIndex = 4;
            this.btnUnosCijena.Text = "Unesi cijene";
            this.btnUnosCijena.UseVisualStyleBackColor = true;
            this.btnUnosCijena.Click += new System.EventHandler(this.btnUnosCijena_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(678, 329);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 5;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnRasporedi
            // 
            this.btnRasporedi.Enabled = false;
            this.btnRasporedi.Location = new System.Drawing.Point(20, 26);
            this.btnRasporedi.Name = "btnRasporedi";
            this.btnRasporedi.Size = new System.Drawing.Size(109, 23);
            this.btnRasporedi.TabIndex = 6;
            this.btnRasporedi.Text = "Unesi rasporede";
            this.btnRasporedi.UseVisualStyleBackColor = true;
            this.btnRasporedi.Click += new System.EventHandler(this.btnRasporedi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnosCijena);
            this.groupBox3.Location = new System.Drawing.Point(15, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Unos cijena";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRasporedi);
            this.groupBox4.Location = new System.Drawing.Point(154, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 70);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unos rasporeda vožnji";
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(597, 329);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 9;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnBrisiStanice
            // 
            this.btnBrisiStanice.Location = new System.Drawing.Point(648, 183);
            this.btnBrisiStanice.Name = "btnBrisiStanice";
            this.btnBrisiStanice.Size = new System.Drawing.Size(75, 23);
            this.btnBrisiStanice.TabIndex = 12;
            this.btnBrisiStanice.Text = "Briši";
            this.btnBrisiStanice.UseVisualStyleBackColor = true;
            this.btnBrisiStanice.Click += new System.EventHandler(this.btnBrisiStanice_Click);
            // 
            // DodajNovuLiniju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 364);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.lblNaziv);
            this.MaximumSize = new System.Drawing.Size(781, 402);
            this.MinimumSize = new System.Drawing.Size(781, 402);
            this.Name = "DodajNovuLiniju";
            this.Text = "Dodaj novu liniju";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.DataGridView dgvStanice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDolazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPolazak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStanice;
        private System.Windows.Forms.RadioButton rbPolozaj;
        private System.Windows.Forms.RadioButton rbKraj;
        private System.Windows.Forms.RadioButton rbPocetak;
        private System.Windows.Forms.ComboBox cbRednibroj;
        private System.Windows.Forms.Button btnDodajStanicu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUnosCijena;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnRasporedi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnBrisiStanice;
    }
}