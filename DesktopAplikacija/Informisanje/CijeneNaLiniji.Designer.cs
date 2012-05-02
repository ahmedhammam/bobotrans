namespace DesktopAplikacija.Informisanje
{
    partial class CijeneNaLiniji
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
            this.gbLinija = new System.Windows.Forms.GroupBox();
            this.lblBrojStanica = new System.Windows.Forms.Label();
            this.lblSifraLinije = new System.Windows.Forms.Label();
            this.dgvCijene = new System.Windows.Forms.DataGridView();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.gbLinija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijene)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLinija
            // 
            this.gbLinija.Controls.Add(this.lblBrojStanica);
            this.gbLinija.Controls.Add(this.lblSifraLinije);
            this.gbLinija.Location = new System.Drawing.Point(13, 13);
            this.gbLinija.Name = "gbLinija";
            this.gbLinija.Size = new System.Drawing.Size(198, 51);
            this.gbLinija.TabIndex = 0;
            this.gbLinija.TabStop = false;
            this.gbLinija.Text = "Linija";
            // 
            // lblBrojStanica
            // 
            this.lblBrojStanica.AutoSize = true;
            this.lblBrojStanica.Location = new System.Drawing.Point(6, 29);
            this.lblBrojStanica.Name = "lblBrojStanica";
            this.lblBrojStanica.Size = new System.Drawing.Size(68, 13);
            this.lblBrojStanica.TabIndex = 1;
            this.lblBrojStanica.Text = "Broj stanica: ";
            // 
            // lblSifraLinije
            // 
            this.lblSifraLinije.AutoSize = true;
            this.lblSifraLinije.Location = new System.Drawing.Point(6, 16);
            this.lblSifraLinije.Name = "lblSifraLinije";
            this.lblSifraLinije.Size = new System.Drawing.Size(57, 13);
            this.lblSifraLinije.TabIndex = 0;
            this.lblSifraLinije.Text = "Sifra linije: ";
            // 
            // dgvCijene
            // 
            this.dgvCijene.AllowUserToAddRows = false;
            this.dgvCijene.AllowUserToDeleteRows = false;
            this.dgvCijene.AllowUserToOrderColumns = true;
            this.dgvCijene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCijene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCijene.Location = new System.Drawing.Point(13, 71);
            this.dgvCijene.Name = "dgvCijene";
            this.dgvCijene.ReadOnly = true;
            this.dgvCijene.RowHeadersWidth = 180;
            this.dgvCijene.Size = new System.Drawing.Size(591, 150);
            this.dgvCijene.TabIndex = 1;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzadji.Location = new System.Drawing.Point(528, 227);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 2;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // CijeneNaLiniji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 262);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvCijene);
            this.Controls.Add(this.gbLinija);
            this.MaximumSize = new System.Drawing.Size(99999, 999999);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "CijeneNaLiniji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cijene na liniji";
            this.Load += new System.EventHandler(this.CijeneNaLiniji_Load);
            this.gbLinija.ResumeLayout(false);
            this.gbLinija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLinija;
        private System.Windows.Forms.Label lblBrojStanica;
        private System.Windows.Forms.Label lblSifraLinije;
        private System.Windows.Forms.DataGridView dgvCijene;
        private System.Windows.Forms.Button btnIzadji;
    }
}