namespace DesktopAplikacija.Menadzer
{
    partial class UredjivanjeAutobusa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UredjivanjeAutobusa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSlobodan = new System.Windows.Forms.TextBox();
            this.cbKlima = new System.Windows.Forms.ComboBox();
            this.cbToalet = new System.Windows.Forms.ComboBox();
            this.dtpServis = new System.Windows.Forms.DateTimePicker();
            this.dtpRegistracija = new System.Windows.Forms.DateTimePicker();
            this.lblSlobodan = new System.Windows.Forms.Label();
            this.lblKlima = new System.Windows.Forms.Label();
            this.lblToalet = new System.Windows.Forms.Label();
            this.lblServis = new System.Windows.Forms.Label();
            this.lblIstek = new System.Windows.Forms.Label();
            this.nudBrojSjedista = new System.Windows.Forms.NumericUpDown();
            this.mtxtRegistracija = new System.Windows.Forms.MaskedTextBox();
            this.lblBrojSjedista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.lvIzvjestaji = new System.Windows.Forms.ListView();
            this.colSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTekst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojSjedista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSlobodan);
            this.groupBox1.Controls.Add(this.cbKlima);
            this.groupBox1.Controls.Add(this.cbToalet);
            this.groupBox1.Controls.Add(this.dtpServis);
            this.groupBox1.Controls.Add(this.dtpRegistracija);
            this.groupBox1.Controls.Add(this.lblSlobodan);
            this.groupBox1.Controls.Add(this.lblKlima);
            this.groupBox1.Controls.Add(this.lblToalet);
            this.groupBox1.Controls.Add(this.lblServis);
            this.groupBox1.Controls.Add(this.lblIstek);
            this.groupBox1.Controls.Add(this.nudBrojSjedista);
            this.groupBox1.Controls.Add(this.mtxtRegistracija);
            this.groupBox1.Controls.Add(this.lblBrojSjedista);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSifra);
            this.groupBox1.Controls.Add(this.lblSifra);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o autobusu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbSlobodan
            // 
            this.tbSlobodan.Location = new System.Drawing.Point(139, 242);
            this.tbSlobodan.Name = "tbSlobodan";
            this.tbSlobodan.ReadOnly = true;
            this.tbSlobodan.Size = new System.Drawing.Size(46, 20);
            this.tbSlobodan.TabIndex = 16;
            // 
            // cbKlima
            // 
            this.cbKlima.FormattingEnabled = true;
            this.cbKlima.Location = new System.Drawing.Point(138, 214);
            this.cbKlima.Name = "cbKlima";
            this.cbKlima.Size = new System.Drawing.Size(47, 21);
            this.cbKlima.TabIndex = 15;
            // 
            // cbToalet
            // 
            this.cbToalet.FormattingEnabled = true;
            this.cbToalet.Location = new System.Drawing.Point(138, 189);
            this.cbToalet.Name = "cbToalet";
            this.cbToalet.Size = new System.Drawing.Size(47, 21);
            this.cbToalet.TabIndex = 14;
            // 
            // dtpServis
            // 
            this.dtpServis.Location = new System.Drawing.Point(138, 163);
            this.dtpServis.Name = "dtpServis";
            this.dtpServis.Size = new System.Drawing.Size(142, 20);
            this.dtpServis.TabIndex = 13;
            // 
            // dtpRegistracija
            // 
            this.dtpRegistracija.Location = new System.Drawing.Point(138, 136);
            this.dtpRegistracija.Name = "dtpRegistracija";
            this.dtpRegistracija.Size = new System.Drawing.Size(142, 20);
            this.dtpRegistracija.TabIndex = 12;
            // 
            // lblSlobodan
            // 
            this.lblSlobodan.AutoSize = true;
            this.lblSlobodan.Location = new System.Drawing.Point(77, 244);
            this.lblSlobodan.Name = "lblSlobodan";
            this.lblSlobodan.Size = new System.Drawing.Size(55, 13);
            this.lblSlobodan.TabIndex = 11;
            this.lblSlobodan.Text = "Slobodan:";
            // 
            // lblKlima
            // 
            this.lblKlima.AutoSize = true;
            this.lblKlima.Location = new System.Drawing.Point(100, 217);
            this.lblKlima.Name = "lblKlima";
            this.lblKlima.Size = new System.Drawing.Size(32, 13);
            this.lblKlima.TabIndex = 10;
            this.lblKlima.Text = "Klima";
            // 
            // lblToalet
            // 
            this.lblToalet.AutoSize = true;
            this.lblToalet.Location = new System.Drawing.Point(92, 192);
            this.lblToalet.Name = "lblToalet";
            this.lblToalet.Size = new System.Drawing.Size(40, 13);
            this.lblToalet.TabIndex = 9;
            this.lblToalet.Text = "Toalet:";
            // 
            // lblServis
            // 
            this.lblServis.AutoSize = true;
            this.lblServis.Location = new System.Drawing.Point(54, 169);
            this.lblServis.Name = "lblServis";
            this.lblServis.Size = new System.Drawing.Size(77, 13);
            this.lblServis.TabIndex = 8;
            this.lblServis.Text = "Datum servisa:";
            this.lblServis.Click += new System.EventHandler(this.lblServis_Click);
            // 
            // lblIstek
            // 
            this.lblIstek.AutoSize = true;
            this.lblIstek.Location = new System.Drawing.Point(45, 136);
            this.lblIstek.Name = "lblIstek";
            this.lblIstek.Size = new System.Drawing.Size(86, 13);
            this.lblIstek.TabIndex = 7;
            this.lblIstek.Text = "Istek registracije:";
            // 
            // nudBrojSjedista
            // 
            this.nudBrojSjedista.Location = new System.Drawing.Point(138, 103);
            this.nudBrojSjedista.Name = "nudBrojSjedista";
            this.nudBrojSjedista.Size = new System.Drawing.Size(47, 20);
            this.nudBrojSjedista.TabIndex = 6;
            this.nudBrojSjedista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtxtRegistracija
            // 
            this.mtxtRegistracija.Location = new System.Drawing.Point(138, 72);
            this.mtxtRegistracija.Mask = "000-L-000";
            this.mtxtRegistracija.Name = "mtxtRegistracija";
            this.mtxtRegistracija.Size = new System.Drawing.Size(89, 20);
            this.mtxtRegistracija.TabIndex = 5;
            // 
            // lblBrojSjedista
            // 
            this.lblBrojSjedista.AutoSize = true;
            this.lblBrojSjedista.Location = new System.Drawing.Point(66, 105);
            this.lblBrojSjedista.Name = "lblBrojSjedista";
            this.lblBrojSjedista.Size = new System.Drawing.Size(66, 13);
            this.lblBrojSjedista.TabIndex = 4;
            this.lblBrojSjedista.Text = "Broj sjedišta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registracijske tablice:";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(138, 38);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.ReadOnly = true;
            this.tbSifra.Size = new System.Drawing.Size(89, 20);
            this.tbSifra.TabIndex = 1;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(54, 41);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(78, 13);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "Šifra autobusa:";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(621, 471);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 1;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // lvIzvjestaji
            // 
            this.lvIzvjestaji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSifra,
            this.colKreator,
            this.colDatum,
            this.colTekst});
            this.lvIzvjestaji.FullRowSelect = true;
            this.lvIzvjestaji.Location = new System.Drawing.Point(6, 19);
            this.lvIzvjestaji.Name = "lvIzvjestaji";
            this.lvIzvjestaji.Size = new System.Drawing.Size(372, 255);
            this.lvIzvjestaji.TabIndex = 2;
            this.lvIzvjestaji.UseCompatibleStateImageBehavior = false;
            this.lvIzvjestaji.View = System.Windows.Forms.View.Details;
            this.lvIzvjestaji.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
            this.lvIzvjestaji.SelectedIndexChanged += new System.EventHandler(this.lvIzvjestaji_SelectedIndexChanged);
            // 
            // colSifra
            // 
            this.colSifra.Text = "Šifra";
            this.colSifra.Width = 34;
            // 
            // colKreator
            // 
            this.colKreator.Text = "Kreator";
            this.colKreator.Width = 100;
            // 
            // colDatum
            // 
            this.colDatum.Text = "Datum servisa";
            this.colDatum.Width = 93;
            // 
            // colTekst
            // 
            this.colTekst.Text = "Tekst";
            this.colTekst.Width = 141;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvIzvjestaji);
            this.groupBox2.Location = new System.Drawing.Point(312, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 280);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izvještaji za autobus";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbTekst);
            this.groupBox3.Location = new System.Drawing.Point(13, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 165);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tekst odabranog izvještaja";
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(7, 20);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(670, 139);
            this.rtbTekst.TabIndex = 0;
            this.rtbTekst.Text = "";
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(540, 470);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 5;
            this.btnSpasi.Text = "Spremi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // UredjivanjeAutobusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 505);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(721, 543);
            this.MinimumSize = new System.Drawing.Size(721, 543);
            this.Name = "UredjivanjeAutobusa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o autobusu";
            this.Load += new System.EventHandler(this.UredjivanjeAutobusa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojSjedista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtRegistracija;
        private System.Windows.Forms.Label lblBrojSjedista;
        private System.Windows.Forms.NumericUpDown nudBrojSjedista;
        private System.Windows.Forms.Label lblServis;
        private System.Windows.Forms.Label lblIstek;
        private System.Windows.Forms.Label lblSlobodan;
        private System.Windows.Forms.Label lblKlima;
        private System.Windows.Forms.Label lblToalet;
        private System.Windows.Forms.DateTimePicker dtpRegistracija;
        private System.Windows.Forms.DateTimePicker dtpServis;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.ListView lvIzvjestaji;
        private System.Windows.Forms.ColumnHeader colSifra;
        private System.Windows.Forms.ColumnHeader colKreator;
        private System.Windows.Forms.ColumnHeader colDatum;
        private System.Windows.Forms.ColumnHeader colTekst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ComboBox cbToalet;
        private System.Windows.Forms.ComboBox cbKlima;
        private System.Windows.Forms.TextBox tbSlobodan;
    }
}