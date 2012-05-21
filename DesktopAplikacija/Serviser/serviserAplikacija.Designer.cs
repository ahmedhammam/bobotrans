namespace DesktopAplikacija.Serviser
{
    partial class ServiserAplikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiserAplikacija));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajIzvještajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiIzvještajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeOLinijamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izvOdIzRedaVožnjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.najjeftinijiPutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeOLinijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvodIzRedaVožnjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPoruke = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.Izađi = new System.Windows.Forms.Button();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IstekRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifra,
            this.tablice,
            this.IstekRegistracije,
            this.Column1,
            this.Column2});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(17, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(515, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izlistaj autobuse po:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Datum servisa",
            "Datum isteka registracije"});
            this.comboBox1.Location = new System.Drawing.Point(132, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.informisanjeToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(544, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajIzvještajToolStripMenuItem1,
            this.prikažiIzvještajToolStripMenuItem1,
            this.izađiToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // kreirajIzvještajToolStripMenuItem1
            // 
            this.kreirajIzvještajToolStripMenuItem1.Name = "kreirajIzvještajToolStripMenuItem1";
            this.kreirajIzvještajToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kreirajIzvještajToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.kreirajIzvještajToolStripMenuItem1.Text = "Kreiraj izvještaj";
            this.kreirajIzvještajToolStripMenuItem1.Click += new System.EventHandler(this.kreirajIzvještajToolStripMenuItem1_Click);
            // 
            // prikažiIzvještajToolStripMenuItem1
            // 
            this.prikažiIzvještajToolStripMenuItem1.Name = "prikažiIzvještajToolStripMenuItem1";
            this.prikažiIzvještajToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.prikažiIzvještajToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.prikažiIzvještajToolStripMenuItem1.Text = "Prikaži izvještaj";
            this.prikažiIzvještajToolStripMenuItem1.Click += new System.EventHandler(this.prikažiIzvještajToolStripMenuItem1_Click);
            // 
            // izađiToolStripMenuItem1
            // 
            this.izađiToolStripMenuItem1.Name = "izađiToolStripMenuItem1";
            this.izađiToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.izađiToolStripMenuItem1.Text = "Izađi";
            this.izađiToolStripMenuItem1.Click += new System.EventHandler(this.izađiToolStripMenuItem1_Click);
            // 
            // informisanjeToolStripMenuItem1
            // 
            this.informisanjeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informisanjeOLinijamaToolStripMenuItem1,
            this.izvOdIzRedaVožnjeToolStripMenuItem1,
            this.najjeftinijiPutToolStripMenuItem});
            this.informisanjeToolStripMenuItem1.Name = "informisanjeToolStripMenuItem1";
            this.informisanjeToolStripMenuItem1.Size = new System.Drawing.Size(85, 20);
            this.informisanjeToolStripMenuItem1.Text = "Informisanje";
            // 
            // informisanjeOLinijamaToolStripMenuItem1
            // 
            this.informisanjeOLinijamaToolStripMenuItem1.Name = "informisanjeOLinijamaToolStripMenuItem1";
            this.informisanjeOLinijamaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.informisanjeOLinijamaToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.informisanjeOLinijamaToolStripMenuItem1.Text = "Informisanje o linijama";
            this.informisanjeOLinijamaToolStripMenuItem1.Click += new System.EventHandler(this.informisanjeOLinijamaToolStripMenuItem1_Click);
            // 
            // izvOdIzRedaVožnjeToolStripMenuItem1
            // 
            this.izvOdIzRedaVožnjeToolStripMenuItem1.Name = "izvOdIzRedaVožnjeToolStripMenuItem1";
            this.izvOdIzRedaVožnjeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.izvOdIzRedaVožnjeToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.izvOdIzRedaVožnjeToolStripMenuItem1.Text = "Izvod iz reda vožnje";
            this.izvOdIzRedaVožnjeToolStripMenuItem1.Click += new System.EventHandler(this.izvOdIzRedaVožnjeToolStripMenuItem1_Click);
            // 
            // najjeftinijiPutToolStripMenuItem
            // 
            this.najjeftinijiPutToolStripMenuItem.Name = "najjeftinijiPutToolStripMenuItem";
            this.najjeftinijiPutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.najjeftinijiPutToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.najjeftinijiPutToolStripMenuItem.Text = "Najjeftiniji put";
            this.najjeftinijiPutToolStripMenuItem.Click += new System.EventHandler(this.najjeftinijiPutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajIzvještajToolStripMenuItem,
            this.prikažiIzvještajToolStripMenuItem,
            this.izađiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // kreirajIzvještajToolStripMenuItem
            // 
            this.kreirajIzvještajToolStripMenuItem.Name = "kreirajIzvještajToolStripMenuItem";
            this.kreirajIzvještajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.kreirajIzvještajToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.kreirajIzvještajToolStripMenuItem.Text = "Kreiraj izvještaj ";
            // 
            // prikažiIzvještajToolStripMenuItem
            // 
            this.prikažiIzvještajToolStripMenuItem.Name = "prikažiIzvještajToolStripMenuItem";
            this.prikažiIzvještajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.prikažiIzvještajToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.prikažiIzvještajToolStripMenuItem.Text = "Prikaži izvještaj ";
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.izađiToolStripMenuItem.Text = "Izađi";
            // 
            // informisanjeToolStripMenuItem
            // 
            this.informisanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informisanjeOLinijamaToolStripMenuItem,
            this.izvodIzRedaVožnjeToolStripMenuItem,
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem});
            this.informisanjeToolStripMenuItem.Name = "informisanjeToolStripMenuItem";
            this.informisanjeToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informisanjeToolStripMenuItem.Text = "Informisanje";
            // 
            // informisanjeOLinijamaToolStripMenuItem
            // 
            this.informisanjeOLinijamaToolStripMenuItem.Name = "informisanjeOLinijamaToolStripMenuItem";
            this.informisanjeOLinijamaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.informisanjeOLinijamaToolStripMenuItem.Text = "Informisanje o linijama";
            // 
            // izvodIzRedaVožnjeToolStripMenuItem
            // 
            this.izvodIzRedaVožnjeToolStripMenuItem.Name = "izvodIzRedaVožnjeToolStripMenuItem";
            this.izvodIzRedaVožnjeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.izvodIzRedaVožnjeToolStripMenuItem.Text = "Izvod iz reda vožnje";
            // 
            // nalaženjeNajjeftinijegPutaToolStripMenuItem
            // 
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem.Name = "nalaženjeNajjeftinijegPutaToolStripMenuItem";
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem.Text = "Nalaženje najjeftinijeg puta";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPoruke,
            this.toolStripButton4,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPoruke
            // 
            this.tsbPoruke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPoruke.Image = ((System.Drawing.Image)(resources.GetObject("tsbPoruke.Image")));
            this.tsbPoruke.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPoruke.Name = "tsbPoruke";
            this.tsbPoruke.Size = new System.Drawing.Size(23, 22);
            this.tsbPoruke.Text = "Poruke";
            this.tsbPoruke.Click += new System.EventHandler(this.tsbPoruke_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Kreiraj izvještaj";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Prikaži izvještaj";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Kreiraj izvještaj";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Prikaži izvještaj";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel1.Text = "Prikaži autobus:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Traži";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // Izađi
            // 
            this.Izađi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Izađi.Location = new System.Drawing.Point(457, 249);
            this.Izađi.Name = "Izađi";
            this.Izađi.Size = new System.Drawing.Size(75, 23);
            this.Izađi.TabIndex = 9;
            this.Izađi.Text = "Izađi";
            this.Izađi.UseVisualStyleBackColor = true;
            this.Izađi.Click += new System.EventHandler(this.Izađi_Click);
            // 
            // sifra
            // 
            this.sifra.HeaderText = "Id";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            this.sifra.Width = 65;
            // 
            // tablice
            // 
            this.tablice.HeaderText = "Tablice";
            this.tablice.Name = "tablice";
            this.tablice.ReadOnly = true;
            // 
            // IstekRegistracije
            // 
            this.IstekRegistracije.HeaderText = "Istek registracije";
            this.IstekRegistracije.Name = "IstekRegistracije";
            this.IstekRegistracije.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Broj sjedišta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Datum servisa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 107;
            // 
            // ServiserAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.Controls.Add(this.Izađi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 999999);
            this.MinimumSize = new System.Drawing.Size(560, 322);
            this.Name = "ServiserAplikacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bobo Trans - Serviser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.serviserAplikacija_FormClosing);
            this.Load += new System.EventHandler(this.serviserAplikacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button Izađi;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem informisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informisanjeOLinijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvodIzRedaVožnjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nalaženjeNajjeftinijegPutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsbPoruke;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informisanjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreirajIzvještajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prikažiIzvještajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem informisanjeOLinijamaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izvOdIzRedaVožnjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem najjeftinijiPutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablice;
        private System.Windows.Forms.DataGridViewTextBoxColumn IstekRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}