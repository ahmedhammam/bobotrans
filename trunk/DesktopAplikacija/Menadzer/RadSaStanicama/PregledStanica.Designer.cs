namespace DesktopAplikacija.Menadzer
{
    partial class PregledStanica
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
            this.lvStanice = new System.Windows.Forms.ListView();
            this.colSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMjesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIzaji = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.tsbNovaStanica = new System.Windows.Forms.ToolStripButton();
            this.tsbBrisi = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStanice
            // 
            this.lvStanice.CheckBoxes = true;
            this.lvStanice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSifra,
            this.colNaziv,
            this.colMjesto});
            this.lvStanice.FullRowSelect = true;
            this.lvStanice.Location = new System.Drawing.Point(12, 28);
            this.lvStanice.Name = "lvStanice";
            this.lvStanice.Size = new System.Drawing.Size(321, 236);
            this.lvStanice.TabIndex = 0;
            this.lvStanice.UseCompatibleStateImageBehavior = false;
            this.lvStanice.View = System.Windows.Forms.View.Details;
            this.lvStanice.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
            this.lvStanice.SelectedIndexChanged += new System.EventHandler(this.lvStanice_SelectedIndexChanged);
            // 
            // colSifra
            // 
            this.colSifra.Text = "Šifra stanice";
            this.colSifra.Width = 71;
            // 
            // colNaziv
            // 
            this.colNaziv.Text = "Naziv stanice";
            this.colNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNaziv.Width = 133;
            // 
            // colMjesto
            // 
            this.colMjesto.Text = "Mjesto";
            this.colMjesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMjesto.Width = 111;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovaStanica,
            this.tsbBrisi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(346, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIzaji
            // 
            this.btnIzaji.Location = new System.Drawing.Point(259, 271);
            this.btnIzaji.Name = "btnIzaji";
            this.btnIzaji.Size = new System.Drawing.Size(75, 23);
            this.btnIzaji.TabIndex = 2;
            this.btnIzaji.Text = "Izađi";
            this.btnIzaji.UseVisualStyleBackColor = true;
            this.btnIzaji.Click += new System.EventHandler(this.btnIzaji_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(178, 271);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // tsbNovaStanica
            // 
            this.tsbNovaStanica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovaStanica.Image = global::DesktopAplikacija.Properties.Resources._1336259801_add;
            this.tsbNovaStanica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovaStanica.Name = "tsbNovaStanica";
            this.tsbNovaStanica.Size = new System.Drawing.Size(23, 22);
            this.tsbNovaStanica.Text = "toolStripButton1";
            this.tsbNovaStanica.Click += new System.EventHandler(this.tsbNovaStanica_Click);
            // 
            // tsbBrisi
            // 
            this.tsbBrisi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBrisi.Image = global::DesktopAplikacija.Properties.Resources.mail_delete;
            this.tsbBrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrisi.Name = "tsbBrisi";
            this.tsbBrisi.Size = new System.Drawing.Size(23, 22);
            this.tsbBrisi.Text = "toolStripButton2";
            this.tsbBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // PregledStanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 306);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzaji);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvStanice);
            this.Name = "PregledStanica";
            this.Text = "PregledStanica";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStanice;
        private System.Windows.Forms.ColumnHeader colSifra;
        private System.Windows.Forms.ColumnHeader colNaziv;
        private System.Windows.Forms.ColumnHeader colMjesto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovaStanica;
        private System.Windows.Forms.ToolStripButton tsbBrisi;
        private System.Windows.Forms.Button btnIzaji;
        private System.Windows.Forms.Button btnUredi;
    }
}