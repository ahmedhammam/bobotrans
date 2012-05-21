namespace DesktopAplikacija.Menadzer
{
    partial class NoviZakupAutobusa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoviZakupAutobusa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCijena = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lvAutobusi = new System.Windows.Forms.ListView();
            this.colSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegistracija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatumServisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIstekRegistracije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSlobodan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBrojSjedista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKlima = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colToalet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCijena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o zakupu";
            // 
            // nudCijena
            // 
            this.nudCijena.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCijena.Location = new System.Drawing.Point(84, 43);
            this.nudCijena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCijena.Name = "nudCijena";
            this.nudCijena.Size = new System.Drawing.Size(71, 20);
            this.nudCijena.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(84, 17);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(119, 20);
            this.tbIme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime zakupca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Početak:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrikazi);
            this.groupBox2.Controls.Add(this.dtpKraj);
            this.groupBox2.Controls.Add(this.dtpPocetak);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(231, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o terminu zakupa";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(230, 15);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(63, 48);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(154, 20);
            this.dtpKraj.TabIndex = 4;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(63, 20);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(154, 20);
            this.dtpPocetak.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kraj:";
            // 
            // lvAutobusi
            // 
            this.lvAutobusi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSifra,
            this.colRegistracija,
            this.colDatumServisa,
            this.colIstekRegistracije,
            this.colSlobodan,
            this.colBrojSjedista,
            this.colKlima,
            this.colToalet});
            this.lvAutobusi.FullRowSelect = true;
            this.lvAutobusi.Location = new System.Drawing.Point(6, 19);
            this.lvAutobusi.MultiSelect = false;
            this.lvAutobusi.Name = "lvAutobusi";
            this.lvAutobusi.Size = new System.Drawing.Size(638, 120);
            this.lvAutobusi.TabIndex = 3;
            this.lvAutobusi.UseCompatibleStateImageBehavior = false;
            this.lvAutobusi.View = System.Windows.Forms.View.Details;
            // 
            // colSifra
            // 
            this.colSifra.Text = "Šifra";
            // 
            // colRegistracija
            // 
            this.colRegistracija.Text = "Registracija";
            this.colRegistracija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRegistracija.Width = 92;
            // 
            // colDatumServisa
            // 
            this.colDatumServisa.Text = "Datum servisa";
            this.colDatumServisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDatumServisa.Width = 108;
            // 
            // colIstekRegistracije
            // 
            this.colIstekRegistracije.Text = "Istek registracije";
            this.colIstekRegistracije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colIstekRegistracije.Width = 110;
            // 
            // colSlobodan
            // 
            this.colSlobodan.Text = "Slobodan";
            this.colSlobodan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colBrojSjedista
            // 
            this.colBrojSjedista.Text = "Broj sjedišta";
            this.colBrojSjedista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBrojSjedista.Width = 82;
            // 
            // colKlima
            // 
            this.colKlima.Text = "Klima";
            this.colKlima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colToalet
            // 
            this.colToalet.Text = "Toalet";
            this.colToalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvAutobusi);
            this.groupBox3.Location = new System.Drawing.Point(12, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dostupni autobusi u datom terminu";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(590, 256);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 5;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(509, 256);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 6;
            this.btnUnesi.Text = "Spremi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // NoviZakupAutobusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 287);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoviZakupAutobusa";
            this.Text = "Zakup autobusa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ListView lvAutobusi;
        private System.Windows.Forms.ColumnHeader colSifra;
        private System.Windows.Forms.ColumnHeader colRegistracija;
        private System.Windows.Forms.ColumnHeader colDatumServisa;
        private System.Windows.Forms.ColumnHeader colIstekRegistracije;
        private System.Windows.Forms.ColumnHeader colSlobodan;
        private System.Windows.Forms.ColumnHeader colBrojSjedista;
        private System.Windows.Forms.ColumnHeader colKlima;
        private System.Windows.Forms.ColumnHeader colToalet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnUnesi;
    }
}