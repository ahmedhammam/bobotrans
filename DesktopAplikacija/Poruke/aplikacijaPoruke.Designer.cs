namespace DesktopAplikacija.Poruke
{
    partial class aplikacijaPoruke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aplikacijaPoruke));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPorukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izadiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primljeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNova = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPoslane = new System.Windows.Forms.ToolStripButton();
            this.tsbPrimljene = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbKorisnici = new System.Windows.Forms.ToolStripComboBox();
            this.tsbPretragaPoImenu = new System.Windows.Forms.ToolStripButton();
            this.tsbPretragaPoslanih = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbIzbrisi = new System.Windows.Forms.ToolStripButton();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.b_Izadi = new System.Windows.Forms.Button();
            this.lvPoruke = new System.Windows.Forms.ListView();
            this.colKorisnik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVrijeme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTekst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPoruke = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbPoruke.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPorukaToolStripMenuItem,
            this.izadiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // novaPorukaToolStripMenuItem
            // 
            this.novaPorukaToolStripMenuItem.Name = "novaPorukaToolStripMenuItem";
            this.novaPorukaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.novaPorukaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.novaPorukaToolStripMenuItem.Text = "Nova Poruka";
            this.novaPorukaToolStripMenuItem.Click += new System.EventHandler(this.novaPorukaToolStripMenuItem_Click);
            // 
            // izadiToolStripMenuItem
            // 
            this.izadiToolStripMenuItem.Name = "izadiToolStripMenuItem";
            this.izadiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.izadiToolStripMenuItem.Text = "Izađi";
            this.izadiToolStripMenuItem.Click += new System.EventHandler(this.izadiToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primljeneToolStripMenuItem,
            this.poslaneToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.viewToolStripMenuItem.Text = "Prikaz";
            // 
            // primljeneToolStripMenuItem
            // 
            this.primljeneToolStripMenuItem.Name = "primljeneToolStripMenuItem";
            this.primljeneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.primljeneToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.primljeneToolStripMenuItem.Text = "Primljene";
            this.primljeneToolStripMenuItem.Click += new System.EventHandler(this.primljeneToolStripMenuItem_Click_1);
            // 
            // poslaneToolStripMenuItem
            // 
            this.poslaneToolStripMenuItem.Name = "poslaneToolStripMenuItem";
            this.poslaneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.poslaneToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.poslaneToolStripMenuItem.Text = "Poslane";
            this.poslaneToolStripMenuItem.Click += new System.EventHandler(this.poslaneToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNova,
            this.toolStripSeparator1,
            this.tsbPoslane,
            this.tsbPrimljene,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tscbKorisnici,
            this.tsbPretragaPoImenu,
            this.tsbPretragaPoslanih,
            this.toolStripSeparator3,
            this.tsbIzbrisi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(462, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNova
            // 
            this.tsbNova.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNova.Image = global::DesktopAplikacija.Properties.Resources.email_new;
            this.tsbNova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNova.Name = "tsbNova";
            this.tsbNova.Size = new System.Drawing.Size(23, 22);
            this.tsbNova.Text = "Nova poruka";
            this.tsbNova.Click += new System.EventHandler(this.tsbNova_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPoslane
            // 
            this.tsbPoslane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPoslane.Image = global::DesktopAplikacija.Properties.Resources.stock_outbox;
            this.tsbPoslane.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPoslane.Name = "tsbPoslane";
            this.tsbPoslane.Size = new System.Drawing.Size(23, 22);
            this.tsbPoslane.Text = "Poslane poruke";
            this.tsbPoslane.Click += new System.EventHandler(this.tsbPoslane_Click);
            // 
            // tsbPrimljene
            // 
            this.tsbPrimljene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimljene.Image = global::DesktopAplikacija.Properties.Resources.stock_inbox;
            this.tsbPrimljene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimljene.Name = "tsbPrimljene";
            this.tsbPrimljene.Size = new System.Drawing.Size(23, 22);
            this.tsbPrimljene.Text = "Primljene poruke";
            this.tsbPrimljene.Click += new System.EventHandler(this.tsbPrimljene_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "Traži";
            // 
            // tscbKorisnici
            // 
            this.tscbKorisnici.Name = "tscbKorisnici";
            this.tscbKorisnici.Size = new System.Drawing.Size(121, 25);
            this.tscbKorisnici.Sorted = true;
            // 
            // tsbPretragaPoImenu
            // 
            this.tsbPretragaPoImenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPretragaPoImenu.Image = global::DesktopAplikacija.Properties.Resources.outbox;
            this.tsbPretragaPoImenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPretragaPoImenu.Name = "tsbPretragaPoImenu";
            this.tsbPretragaPoImenu.Size = new System.Drawing.Size(23, 22);
            this.tsbPretragaPoImenu.Text = "Pretraži primljene po imenu";
            this.tsbPretragaPoImenu.Click += new System.EventHandler(this.tsbPretragaPoImenu_Click);
            // 
            // tsbPretragaPoslanih
            // 
            this.tsbPretragaPoslanih.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPretragaPoslanih.Image = global::DesktopAplikacija.Properties.Resources.stock_mail_receive;
            this.tsbPretragaPoslanih.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPretragaPoslanih.Name = "tsbPretragaPoslanih";
            this.tsbPretragaPoslanih.Size = new System.Drawing.Size(23, 22);
            this.tsbPretragaPoslanih.Text = "Pretraži poslane po imenu";
            this.tsbPretragaPoslanih.Click += new System.EventHandler(this.tsbPretragaPoslanih_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbIzbrisi
            // 
            this.tsbIzbrisi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIzbrisi.Image = global::DesktopAplikacija.Properties.Resources.mail_delete;
            this.tsbIzbrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzbrisi.Name = "tsbIzbrisi";
            this.tsbIzbrisi.Size = new System.Drawing.Size(23, 22);
            this.tsbIzbrisi.Text = "Izbriši označeno";
            this.tsbIzbrisi.Click += new System.EventHandler(this.tsbIzbrisi_Click);
            // 
            // rtbTekst
            // 
            this.rtbTekst.AcceptsTab = true;
            this.rtbTekst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbTekst.Location = new System.Drawing.Point(18, 266);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(426, 155);
            this.rtbTekst.TabIndex = 3;
            this.rtbTekst.Text = "";
            // 
            // b_Izadi
            // 
            this.b_Izadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Izadi.Location = new System.Drawing.Point(369, 427);
            this.b_Izadi.Name = "b_Izadi";
            this.b_Izadi.Size = new System.Drawing.Size(75, 23);
            this.b_Izadi.TabIndex = 4;
            this.b_Izadi.Text = "Izađi";
            this.b_Izadi.UseVisualStyleBackColor = true;
            this.b_Izadi.Click += new System.EventHandler(this.b_Izadi_Click);
            // 
            // lvPoruke
            // 
            this.lvPoruke.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPoruke.CheckBoxes = true;
            this.lvPoruke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKorisnik,
            this.colVrijeme,
            this.colTekst});
            this.lvPoruke.FullRowSelect = true;
            this.lvPoruke.Location = new System.Drawing.Point(6, 19);
            this.lvPoruke.Name = "lvPoruke";
            this.lvPoruke.Size = new System.Drawing.Size(426, 162);
            this.lvPoruke.TabIndex = 9;
            this.lvPoruke.UseCompatibleStateImageBehavior = false;
            this.lvPoruke.View = System.Windows.Forms.View.Details;
            this.lvPoruke.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
            this.lvPoruke.SelectedIndexChanged += new System.EventHandler(this.lvPoruke_SelectedIndexChanged);
            // 
            // colKorisnik
            // 
            this.colKorisnik.Text = "Korisnik";
            this.colKorisnik.Width = 143;
            // 
            // colVrijeme
            // 
            this.colVrijeme.Text = "Vrijeme slanja";
            this.colVrijeme.Width = 103;
            // 
            // colTekst
            // 
            this.colTekst.Text = "Tekst";
            this.colTekst.Width = 176;
            // 
            // gbPoruke
            // 
            this.gbPoruke.Controls.Add(this.lvPoruke);
            this.gbPoruke.Location = new System.Drawing.Point(12, 67);
            this.gbPoruke.Name = "gbPoruke";
            this.gbPoruke.Size = new System.Drawing.Size(441, 193);
            this.gbPoruke.TabIndex = 10;
            this.gbPoruke.TabStop = false;
            // 
            // aplikacijaPoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 462);
            this.Controls.Add(this.gbPoruke);
            this.Controls.Add(this.b_Izadi);
            this.Controls.Add(this.rtbTekst);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(478, 900000);
            this.MinimumSize = new System.Drawing.Size(478, 500);
            this.Name = "aplikacijaPoruke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bobo Trans-Poruke";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbPoruke.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNova;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPoslane;
        private System.Windows.Forms.ToolStripButton tsbPrimljene;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscbKorisnici;
        private System.Windows.Forms.ToolStripButton tsbPretragaPoImenu;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.Button b_Izadi;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPorukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primljeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbPretragaPoslanih;
        private System.Windows.Forms.ToolStripMenuItem izadiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbIzbrisi;
        private System.Windows.Forms.ListView lvPoruke;
        private System.Windows.Forms.ColumnHeader colKorisnik;
        private System.Windows.Forms.ColumnHeader colVrijeme;
        private System.Windows.Forms.ColumnHeader colTekst;
        private System.Windows.Forms.GroupBox gbPoruke;
    }
}