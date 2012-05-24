namespace DesktopAplikacija.Menadzer
{
    partial class IznajmljivanjeAutobusa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IznajmljivanjeAutobusa));
            this.gbZakupi = new System.Windows.Forms.GroupBox();
            this.lvZakupi = new System.Windows.Forms.ListView();
            this.colSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPocetak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAutobus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovi = new System.Windows.Forms.ToolStripButton();
            this.tsbTekuci = new System.Windows.Forms.ToolStripButton();
            this.tsbProsli = new System.Windows.Forms.ToolStripButton();
            this.tsbBuduci = new System.Windows.Forms.ToolStripButton();
            this.gbZakupi.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbZakupi
            // 
            this.gbZakupi.Controls.Add(this.lvZakupi);
            this.gbZakupi.Location = new System.Drawing.Point(12, 28);
            this.gbZakupi.Name = "gbZakupi";
            this.gbZakupi.Size = new System.Drawing.Size(422, 223);
            this.gbZakupi.TabIndex = 0;
            this.gbZakupi.TabStop = false;
            this.gbZakupi.Text = "Zakupi";
            // 
            // lvZakupi
            // 
            this.lvZakupi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSifra,
            this.colIme,
            this.colPocetak,
            this.colKraj,
            this.colCijena,
            this.colAutobus});
            this.lvZakupi.Location = new System.Drawing.Point(7, 20);
            this.lvZakupi.Name = "lvZakupi";
            this.lvZakupi.Size = new System.Drawing.Size(406, 197);
            this.lvZakupi.TabIndex = 0;
            this.lvZakupi.UseCompatibleStateImageBehavior = false;
            this.lvZakupi.View = System.Windows.Forms.View.Details;
            // 
            // colSifra
            // 
            this.colSifra.Text = "Šifra";
            this.colSifra.Width = 37;
            // 
            // colIme
            // 
            this.colIme.Text = "Ime";
            this.colIme.Width = 100;
            // 
            // colPocetak
            // 
            this.colPocetak.Text = "Početak";
            this.colPocetak.Width = 68;
            // 
            // colKraj
            // 
            this.colKraj.Text = "Kraj";
            this.colKraj.Width = 74;
            // 
            // colCijena
            // 
            this.colCijena.Text = "Cijena";
            this.colCijena.Width = 64;
            // 
            // colAutobus
            // 
            this.colAutobus.Text = "Autobus";
            this.colAutobus.Width = 56;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovi,
            this.tsbTekuci,
            this.tsbProsli,
            this.tsbBuduci});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovi
            // 
            this.tsbNovi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovi.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovi.Image")));
            this.tsbNovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovi.Name = "tsbNovi";
            this.tsbNovi.Size = new System.Drawing.Size(23, 22);
            this.tsbNovi.Text = "Novi zakup";
            this.tsbNovi.ToolTipText = "Dodaj novi zakup";
            this.tsbNovi.Click += new System.EventHandler(this.tsbNovi_Click);
            // 
            // tsbTekuci
            // 
            this.tsbTekuci.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTekuci.Image = ((System.Drawing.Image)(resources.GetObject("tsbTekuci.Image")));
            this.tsbTekuci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTekuci.Name = "tsbTekuci";
            this.tsbTekuci.Size = new System.Drawing.Size(23, 22);
            this.tsbTekuci.Text = "Tekući zakupi";
            this.tsbTekuci.ToolTipText = "Prikazi tekuce zakupe";
            this.tsbTekuci.Click += new System.EventHandler(this.tsbTekuci_Click);
            // 
            // tsbProsli
            // 
            this.tsbProsli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProsli.Image = ((System.Drawing.Image)(resources.GetObject("tsbProsli.Image")));
            this.tsbProsli.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProsli.Name = "tsbProsli";
            this.tsbProsli.Size = new System.Drawing.Size(23, 22);
            this.tsbProsli.Text = "Prošli zakupi";
            this.tsbProsli.ToolTipText = "Prikazi prosle zakupe";
            this.tsbProsli.Click += new System.EventHandler(this.tsbProsli_Click);
            // 
            // tsbBuduci
            // 
            this.tsbBuduci.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuduci.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuduci.Image")));
            this.tsbBuduci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuduci.Name = "tsbBuduci";
            this.tsbBuduci.Size = new System.Drawing.Size(23, 22);
            this.tsbBuduci.Text = "Budući zakupi";
            this.tsbBuduci.ToolTipText = "Prikazi buduce zakupe";
            this.tsbBuduci.Click += new System.EventHandler(this.tsbBuduci_Click);
            // 
            // IznajmljivanjeAutobusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 269);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbZakupi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 9999);
            this.MinimumSize = new System.Drawing.Size(460, 307);
            this.Name = "IznajmljivanjeAutobusa";
            this.Text = "Iznajmljivanje autobusa";
            this.gbZakupi.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbZakupi;
        private System.Windows.Forms.ListView lvZakupi;
        private System.Windows.Forms.ColumnHeader colSifra;
        private System.Windows.Forms.ColumnHeader colIme;
        private System.Windows.Forms.ColumnHeader colPocetak;
        private System.Windows.Forms.ColumnHeader colKraj;
        private System.Windows.Forms.ColumnHeader colCijena;
        private System.Windows.Forms.ColumnHeader colAutobus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovi;
        private System.Windows.Forms.ToolStripButton tsbTekuci;
        private System.Windows.Forms.ToolStripButton tsbProsli;
        private System.Windows.Forms.ToolStripButton tsbBuduci;
    }
}