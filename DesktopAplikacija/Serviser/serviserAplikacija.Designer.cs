namespace DesktopAplikacija.Serviser
{
    partial class serviserAplikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviserAplikacija));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IstekRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmijeniPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiPorukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.Izađi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifra,
            this.tablice,
            this.IstekRegistracije,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(17, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(507, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.IstekRegistracije.HeaderText = "IstekRegistracije";
            this.IstekRegistracije.Name = "IstekRegistracije";
            this.IstekRegistracije.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BrojSjedista";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DatumServisa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ispisi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IzlistajAutobusePo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DatumServisa",
            "DatumIstekaRegistracije"});
            this.comboBox1.Location = new System.Drawing.Point(132, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            this.izmijeniPodatkeToolStripMenuItem,
            this.prikažiPorukeToolStripMenuItem,
            this.izađiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // kreirajIzvještajToolStripMenuItem
            // 
            this.kreirajIzvještajToolStripMenuItem.Name = "kreirajIzvještajToolStripMenuItem";
            this.kreirajIzvještajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.kreirajIzvještajToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.kreirajIzvještajToolStripMenuItem.Text = "KreirajIzvještaj ";
            this.kreirajIzvještajToolStripMenuItem.Click += new System.EventHandler(this.kreirajIzvještajToolStripMenuItem_Click);
            // 
            // prikažiIzvještajToolStripMenuItem
            // 
            this.prikažiIzvještajToolStripMenuItem.Name = "prikažiIzvještajToolStripMenuItem";
            this.prikažiIzvještajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.prikažiIzvještajToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.prikažiIzvještajToolStripMenuItem.Text = "PrikažiIzvještaj ";
            this.prikažiIzvještajToolStripMenuItem.Click += new System.EventHandler(this.prikažiIzvještajToolStripMenuItem_Click);
            // 
            // izmijeniPodatkeToolStripMenuItem
            // 
            this.izmijeniPodatkeToolStripMenuItem.Name = "izmijeniPodatkeToolStripMenuItem";
            this.izmijeniPodatkeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.izmijeniPodatkeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.izmijeniPodatkeToolStripMenuItem.Text = "IzmijeniPodatke ";
            this.izmijeniPodatkeToolStripMenuItem.Click += new System.EventHandler(this.izmijeniPodatkeToolStripMenuItem_Click);
            // 
            // prikažiPorukeToolStripMenuItem
            // 
            this.prikažiPorukeToolStripMenuItem.Name = "prikažiPorukeToolStripMenuItem";
            this.prikažiPorukeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.prikažiPorukeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.prikažiPorukeToolStripMenuItem.Text = "PrikažiPoruke";
            this.prikažiPorukeToolStripMenuItem.Click += new System.EventHandler(this.prikažiPorukeToolStripMenuItem_Click_1);
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.izađiToolStripMenuItem.Text = "Izađi";
            this.izađiToolStripMenuItem.Click += new System.EventHandler(this.izađiToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
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
            this.toolStripButton1.Text = "KreirajIzvještaj";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "PrikažiIzvještaj";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "IzmijeniPodatke";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "PrikažiPoruke";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "PrikažiAutobus";
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
            // 
            // Izađi
            // 
            this.Izađi.Location = new System.Drawing.Point(449, 249);
            this.Izađi.Name = "Izađi";
            this.Izađi.Size = new System.Drawing.Size(75, 23);
            this.Izađi.TabIndex = 9;
            this.Izađi.Text = "Izađi";
            this.Izađi.UseVisualStyleBackColor = true;
            this.Izađi.Click += new System.EventHandler(this.Izađi_Click);
            // 
            // serviserAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.Controls.Add(this.Izađi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "serviserAplikacija";
            this.Text = "Bobo Trans";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablice;
        private System.Windows.Forms.DataGridViewTextBoxColumn IstekRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmijeniPodatkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiPorukeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button Izađi;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}