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
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IstekRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.Izađi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.informisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeOLinijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvodIzRedaVožnjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Column1.HeaderText = "Broj sjedista";
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
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informisanjeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(544, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
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
            this.kreirajIzvještajToolStripMenuItem.Click += new System.EventHandler(this.kreirajIzvještajToolStripMenuItem_Click);
            // 
            // prikažiIzvještajToolStripMenuItem
            // 
            this.prikažiIzvještajToolStripMenuItem.Name = "prikažiIzvještajToolStripMenuItem";
            this.prikažiIzvještajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.prikažiIzvještajToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.prikažiIzvještajToolStripMenuItem.Text = "Prikaži izvještaj ";
            this.prikažiIzvještajToolStripMenuItem.Click += new System.EventHandler(this.prikažiIzvještajToolStripMenuItem_Click);
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.izađiToolStripMenuItem.Text = "Izađi";
            this.izađiToolStripMenuItem.Click += new System.EventHandler(this.izađiToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Kreiraj izvještaj";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Prikaži izvještaj";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
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
            // Izađi
            // 
            this.Izađi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Izađi.Location = new System.Drawing.Point(449, 249);
            this.Izađi.Name = "Izađi";
            this.Izađi.Size = new System.Drawing.Size(75, 23);
            this.Izađi.TabIndex = 9;
            this.Izađi.Text = "Izađi";
            this.Izađi.UseVisualStyleBackColor = true;
            this.Izađi.Click += new System.EventHandler(this.Izađi_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(358, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ispiši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.informisanjeOLinijamaToolStripMenuItem.Click += new System.EventHandler(this.informisanjeOLinijamaToolStripMenuItem_Click);
            // 
            // izvodIzRedaVožnjeToolStripMenuItem
            // 
            this.izvodIzRedaVožnjeToolStripMenuItem.Name = "izvodIzRedaVožnjeToolStripMenuItem";
            this.izvodIzRedaVožnjeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.izvodIzRedaVožnjeToolStripMenuItem.Text = "Izvod iz reda vožnje";
            this.izvodIzRedaVožnjeToolStripMenuItem.Click += new System.EventHandler(this.izvodIzRedaVožnjeToolStripMenuItem_Click);
            // 
            // nalaženjeNajjeftinijegPutaToolStripMenuItem
            // 
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem.Name = "nalaženjeNajjeftinijegPutaToolStripMenuItem";
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem.Text = "Nalaženje najjeftinijeg puta";
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem.Click += new System.EventHandler(this.nalaženjeNajjeftinijegPutaToolStripMenuItem_Click);
            // 
            // ServiserAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Izađi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablice;
        private System.Windows.Forms.DataGridViewTextBoxColumn IstekRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem informisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informisanjeOLinijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvodIzRedaVožnjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nalaženjeNajjeftinijegPutaToolStripMenuItem;
    }
}