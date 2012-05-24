namespace DesktopAplikacija.Menadzer
{
    partial class PregledAutobusa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledAutobusa));
            this.lvAutobusi = new System.Windows.Forms.ListView();
            this.colSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegistracija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatumServisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIstekRegistracije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSlobodan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBrojSjedista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKlima = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colToalet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNoviAutobus = new System.Windows.Forms.ToolStripButton();
            this.tsbBrisi = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAutobusi
            // 
            this.lvAutobusi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvAutobusi.CheckBoxes = true;
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
            this.lvAutobusi.Location = new System.Drawing.Point(7, 28);
            this.lvAutobusi.MultiSelect = false;
            this.lvAutobusi.Name = "lvAutobusi";
            this.lvAutobusi.Size = new System.Drawing.Size(638, 246);
            this.lvAutobusi.TabIndex = 0;
            this.lvAutobusi.UseCompatibleStateImageBehavior = false;
            this.lvAutobusi.View = System.Windows.Forms.View.Details;
            this.lvAutobusi.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
            this.lvAutobusi.SelectedIndexChanged += new System.EventHandler(this.lvAutobusi_SelectedIndexChanged);
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
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNoviAutobus,
            this.tsbBrisi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(58, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNoviAutobus
            // 
            this.tsbNoviAutobus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNoviAutobus.Image = ((System.Drawing.Image)(resources.GetObject("tsbNoviAutobus.Image")));
            this.tsbNoviAutobus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNoviAutobus.Name = "tsbNoviAutobus";
            this.tsbNoviAutobus.Size = new System.Drawing.Size(23, 22);
            this.tsbNoviAutobus.Text = "Dodaj novi autobus";
            this.tsbNoviAutobus.ToolTipText = "Dodaj novi autobus";
            this.tsbNoviAutobus.Click += new System.EventHandler(this.tsbNoviAutobus_Click);
            // 
            // tsbBrisi
            // 
            this.tsbBrisi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBrisi.Image = global::DesktopAplikacija.Properties.Resources.mail_delete;
            this.tsbBrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrisi.Name = "tsbBrisi";
            this.tsbBrisi.Size = new System.Drawing.Size(23, 22);
            this.tsbBrisi.Text = "Brisanje autobusa";
            this.tsbBrisi.ToolTipText = "Izbriši selektirane autobuse";
            this.tsbBrisi.Click += new System.EventHandler(this.tsbBrisi_Click);
            // 
            // PregledAutobusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 283);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvAutobusi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(673, 99999);
            this.MinimumSize = new System.Drawing.Size(673, 200);
            this.Name = "PregledAutobusa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled autobusa";
            this.Load += new System.EventHandler(this.PregledAutobusa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAutobusi;
        private System.Windows.Forms.ColumnHeader colSifra;
        private System.Windows.Forms.ColumnHeader colRegistracija;
        private System.Windows.Forms.ColumnHeader colDatumServisa;
        private System.Windows.Forms.ColumnHeader colIstekRegistracije;
        private System.Windows.Forms.ColumnHeader colSlobodan;
        private System.Windows.Forms.ColumnHeader colBrojSjedista;
        private System.Windows.Forms.ColumnHeader colKlima;
        private System.Windows.Forms.ColumnHeader colToalet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNoviAutobus;
        private System.Windows.Forms.ToolStripButton tsbBrisi;
    }
}