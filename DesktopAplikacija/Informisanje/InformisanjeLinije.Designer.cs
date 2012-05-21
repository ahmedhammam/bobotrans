namespace DesktopAplikacija.Informisanje
{
    partial class InformisanjeLinije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformisanjeLinije));
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.lblIzborLinije = new System.Windows.Forms.Label();
            this.cbLinije = new System.Windows.Forms.ComboBox();
            this.lblNazivLinije = new System.Windows.Forms.Label();
            this.dgvStanice = new System.Windows.Forms.DataGridView();
            this.colNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDolazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPolazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBrojStanica = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.lblSifraLinije = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tsBtnPrikaziVoznje = new System.Windows.Forms.ToolStripButton();
            this.btnPrikaziCijene = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrikazi.Location = new System.Drawing.Point(262, 363);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // lblIzborLinije
            // 
            this.lblIzborLinije.AutoSize = true;
            this.lblIzborLinije.Location = new System.Drawing.Point(12, 40);
            this.lblIzborLinije.Name = "lblIzborLinije";
            this.lblIzborLinije.Size = new System.Drawing.Size(56, 13);
            this.lblIzborLinije.TabIndex = 2;
            this.lblIzborLinije.Text = "Izbor linije:";
            // 
            // cbLinije
            // 
            this.cbLinije.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLinije.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLinije.FormattingEnabled = true;
            this.cbLinije.Location = new System.Drawing.Point(74, 37);
            this.cbLinije.Name = "cbLinije";
            this.cbLinije.Size = new System.Drawing.Size(121, 21);
            this.cbLinije.TabIndex = 0;
            this.cbLinije.SelectedIndexChanged += new System.EventHandler(this.cbLinije_SelectedIndexChanged);
            // 
            // lblNazivLinije
            // 
            this.lblNazivLinije.AutoSize = true;
            this.lblNazivLinije.Location = new System.Drawing.Point(6, 21);
            this.lblNazivLinije.Name = "lblNazivLinije";
            this.lblNazivLinije.Size = new System.Drawing.Size(60, 13);
            this.lblNazivLinije.TabIndex = 2;
            this.lblNazivLinije.Text = "Naziv linije:";
            // 
            // dgvStanice
            // 
            this.dgvStanice.AllowUserToAddRows = false;
            this.dgvStanice.AllowUserToDeleteRows = false;
            this.dgvStanice.AllowUserToOrderColumns = true;
            this.dgvStanice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvStanice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNaziv,
            this.colMjesto,
            this.colDolazak,
            this.colPolazak});
            this.dgvStanice.Location = new System.Drawing.Point(12, 111);
            this.dgvStanice.Name = "dgvStanice";
            this.dgvStanice.ReadOnly = true;
            this.dgvStanice.Size = new System.Drawing.Size(406, 246);
            this.dgvStanice.TabIndex = 4;
            // 
            // colNaziv
            // 
            this.colNaziv.HeaderText = "Naziv stanice";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.ReadOnly = true;
            // 
            // colMjesto
            // 
            this.colMjesto.HeaderText = "Mjesto";
            this.colMjesto.Name = "colMjesto";
            this.colMjesto.ReadOnly = true;
            // 
            // colDolazak
            // 
            this.colDolazak.HeaderText = "Minuta do dolaska";
            this.colDolazak.Name = "colDolazak";
            this.colDolazak.ReadOnly = true;
            this.colDolazak.Width = 80;
            // 
            // colPolazak
            // 
            this.colPolazak.HeaderText = "Minuta do polaska";
            this.colPolazak.Name = "colPolazak";
            this.colPolazak.ReadOnly = true;
            this.colPolazak.Width = 82;
            // 
            // lblBrojStanica
            // 
            this.lblBrojStanica.AutoSize = true;
            this.lblBrojStanica.Location = new System.Drawing.Point(6, 53);
            this.lblBrojStanica.Name = "lblBrojStanica";
            this.lblBrojStanica.Size = new System.Drawing.Size(65, 13);
            this.lblBrojStanica.TabIndex = 5;
            this.lblBrojStanica.Text = "Broj stanica:";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIzadji.Location = new System.Drawing.Point(343, 363);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 8;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // lblSifraLinije
            // 
            this.lblSifraLinije.AutoSize = true;
            this.lblSifraLinije.Location = new System.Drawing.Point(6, 37);
            this.lblSifraLinije.Name = "lblSifraLinije";
            this.lblSifraLinije.Size = new System.Drawing.Size(54, 13);
            this.lblSifraLinije.TabIndex = 9;
            this.lblSifraLinije.Text = "Šifra linije:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNazivLinije);
            this.groupBox1.Controls.Add(this.lblSifraLinije);
            this.groupBox1.Controls.Add(this.lblBrojStanica);
            this.groupBox1.Location = new System.Drawing.Point(201, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linija";
            // 
            // tsBtnPrikaziVoznje
            // 
            this.tsBtnPrikaziVoznje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrikaziVoznje.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrikaziVoznje.Image")));
            this.tsBtnPrikaziVoznje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrikaziVoznje.Name = "tsBtnPrikaziVoznje";
            this.tsBtnPrikaziVoznje.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrikaziVoznje.Text = "Informisanje o vožnji";
            this.tsBtnPrikaziVoznje.ToolTipText = "Prikazi raspored voznji selektirane linije";
            this.tsBtnPrikaziVoznje.Click += new System.EventHandler(this.tsBtnPrikaziVoznje_Click);
            // 
            // btnPrikaziCijene
            // 
            this.btnPrikaziCijene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrikaziCijene.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikaziCijene.Image")));
            this.btnPrikaziCijene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrikaziCijene.Name = "btnPrikaziCijene";
            this.btnPrikaziCijene.Size = new System.Drawing.Size(23, 22);
            this.btnPrikaziCijene.Text = "Cijene na liniji";
            this.btnPrikaziCijene.ToolTipText = "Prikazi cijene između svih stanica odabrane linije";
            this.btnPrikaziCijene.Click += new System.EventHandler(this.btnPrikaziCijene_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnPrikaziVoznje,
            this.btnPrikaziCijene});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(430, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // InformisanjeLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblIzborLinije);
            this.Controls.Add(this.cbLinije);
            this.Controls.Add(this.dgvStanice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(446, 999999974);
            this.MinimumSize = new System.Drawing.Size(446, 327);
            this.Name = "InformisanjeLinije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informisanje o liniji";
            this.Load += new System.EventHandler(this.InformisanjeLinije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLinije;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label lblIzborLinije;
        private System.Windows.Forms.Label lblNazivLinije;
        private System.Windows.Forms.DataGridView dgvStanice;
        private System.Windows.Forms.Label lblBrojStanica;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Label lblSifraLinije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton tsBtnPrikaziVoznje;
        private System.Windows.Forms.ToolStripButton btnPrikaziCijene;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDolazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPolazak;
    }
}