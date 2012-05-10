namespace DesktopAplikacija.RadnikZaSalterom
{
    partial class podaciORezervaciji
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
            this.lbSpisakKarti = new System.Windows.Forms.ListView();
            this.imeIPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pocetnaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.krajnjaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vrijeme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brojSjedista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dIVKupovine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbKrajStan = new System.Windows.Forms.ComboBox();
            this.cbPocStan = new System.Windows.Forms.ComboBox();
            this.cbVoznje = new System.Windows.Forms.ComboBox();
            this.cbLinije = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbImeIPrez = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSpisakKarti
            // 
            this.lbSpisakKarti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSpisakKarti.CheckBoxes = true;
            this.lbSpisakKarti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imeIPrezime,
            this.pocetnaStanica,
            this.krajnjaStanica,
            this.datum,
            this.vrijeme,
            this.brojSjedista,
            this.cijena,
            this.dIVKupovine});
            this.lbSpisakKarti.FullRowSelect = true;
            this.lbSpisakKarti.Location = new System.Drawing.Point(12, 150);
            this.lbSpisakKarti.MultiSelect = false;
            this.lbSpisakKarti.Name = "lbSpisakKarti";
            this.lbSpisakKarti.Size = new System.Drawing.Size(657, 322);
            this.lbSpisakKarti.TabIndex = 22;
            this.lbSpisakKarti.UseCompatibleStateImageBehavior = false;
            this.lbSpisakKarti.View = System.Windows.Forms.View.Details;
            // 
            // imeIPrezime
            // 
            this.imeIPrezime.Text = "Ime i prezime";
            this.imeIPrezime.Width = 76;
            // 
            // pocetnaStanica
            // 
            this.pocetnaStanica.Text = "Početna stanica";
            this.pocetnaStanica.Width = 93;
            // 
            // krajnjaStanica
            // 
            this.krajnjaStanica.Text = "Krajnja Stanica";
            this.krajnjaStanica.Width = 89;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 53;
            // 
            // vrijeme
            // 
            this.vrijeme.Text = "Vrijeme";
            this.vrijeme.Width = 52;
            // 
            // brojSjedista
            // 
            this.brojSjedista.Text = "Broj sjedišta";
            this.brojSjedista.Width = 73;
            // 
            // cijena
            // 
            this.cijena.Text = "Cijena";
            // 
            // dIVKupovine
            // 
            this.dIVKupovine.Text = "Datum i vrijeme kupovine";
            this.dIVKupovine.Width = 132;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(582, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Briši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbKrajStan);
            this.groupBox2.Controls.Add(this.cbPocStan);
            this.groupBox2.Controls.Add(this.cbVoznje);
            this.groupBox2.Controls.Add(this.cbLinije);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 132);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o vožnji";
            // 
            // cbKrajStan
            // 
            this.cbKrajStan.FormattingEnabled = true;
            this.cbKrajStan.Location = new System.Drawing.Point(124, 98);
            this.cbKrajStan.Name = "cbKrajStan";
            this.cbKrajStan.Size = new System.Drawing.Size(121, 21);
            this.cbKrajStan.TabIndex = 55;
            // 
            // cbPocStan
            // 
            this.cbPocStan.FormattingEnabled = true;
            this.cbPocStan.Location = new System.Drawing.Point(124, 71);
            this.cbPocStan.Name = "cbPocStan";
            this.cbPocStan.Size = new System.Drawing.Size(121, 21);
            this.cbPocStan.TabIndex = 54;
            // 
            // cbVoznje
            // 
            this.cbVoznje.FormattingEnabled = true;
            this.cbVoznje.Location = new System.Drawing.Point(124, 44);
            this.cbVoznje.Name = "cbVoznje";
            this.cbVoznje.Size = new System.Drawing.Size(121, 21);
            this.cbVoznje.TabIndex = 53;
            // 
            // cbLinije
            // 
            this.cbLinije.FormattingEnabled = true;
            this.cbLinije.Location = new System.Drawing.Point(124, 18);
            this.cbLinije.Name = "cbLinije";
            this.cbLinije.Size = new System.Drawing.Size(121, 21);
            this.cbLinije.TabIndex = 50;
            this.cbLinije.SelectedIndexChanged += new System.EventHandler(this.cbLinije_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Krajnja stanica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Početna stanica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Vožnja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Linija:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbImeIPrez);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 132);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o kupcu";
            // 
            // tbImeIPrez
            // 
            this.tbImeIPrez.Location = new System.Drawing.Point(126, 18);
            this.tbImeIPrez.Name = "tbImeIPrez";
            this.tbImeIPrez.Size = new System.Drawing.Size(104, 20);
            this.tbImeIPrez.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ime i prezime:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(582, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 49;
            this.button2.Text = "Pretraži";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // podaciORezervaciji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSpisakKarti);
            this.MinimumSize = new System.Drawing.Size(655, 309);
            this.Name = "podaciORezervaciji";
            this.Text = "Kupci karti";
            this.Load += new System.EventHandler(this.podaciORezervaciji_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader imeIPrezime;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader vrijeme;
        private System.Windows.Forms.ColumnHeader brojSjedista;
        private System.Windows.Forms.ColumnHeader cijena;
        private System.Windows.Forms.ListView lbSpisakKarti;
        private System.Windows.Forms.ColumnHeader pocetnaStanica;
        private System.Windows.Forms.ColumnHeader krajnjaStanica;
        private System.Windows.Forms.ColumnHeader dIVKupovine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbImeIPrez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbKrajStan;
        private System.Windows.Forms.ComboBox cbPocStan;
        private System.Windows.Forms.ComboBox cbVoznje;
        private System.Windows.Forms.ComboBox cbLinije;
    }
}