namespace DesktopAplikacija.Menadzer
{
    partial class UredjivanjeRasporedaVoznje
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
            this.dgvRasporediVoznji = new System.Windows.Forms.DataGridView();
            this.gbRasporedi = new System.Windows.Forms.GroupBox();
            this.colSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanUSedmici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrijemePolaskaRasporeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPotrebnaSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAutobusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasporediVoznji)).BeginInit();
            this.gbRasporedi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRasporediVoznji
            // 
            this.dgvRasporediVoznji.AllowUserToDeleteRows = false;
            this.dgvRasporediVoznji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRasporediVoznji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSifra,
            this.colDanUSedmici,
            this.colVrijemePolaskaRasporeda,
            this.colPotrebnaSjedista,
            this.colIdAutobusa});
            this.dgvRasporediVoznji.Location = new System.Drawing.Point(16, 19);
            this.dgvRasporediVoznji.Name = "dgvRasporediVoznji";
            this.dgvRasporediVoznji.Size = new System.Drawing.Size(484, 225);
            this.dgvRasporediVoznji.TabIndex = 5;
            // 
            // gbRasporedi
            // 
            this.gbRasporedi.Controls.Add(this.dgvRasporediVoznji);
            this.gbRasporedi.Location = new System.Drawing.Point(12, 12);
            this.gbRasporedi.Name = "gbRasporedi";
            this.gbRasporedi.Size = new System.Drawing.Size(718, 336);
            this.gbRasporedi.TabIndex = 4;
            this.gbRasporedi.TabStop = false;
            this.gbRasporedi.Text = "Rasporedi vožnji";
            // 
            // colSifra
            // 
            this.colSifra.HeaderText = "Šifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.ReadOnly = true;
            this.colSifra.Width = 40;
            // 
            // colDanUSedmici
            // 
            this.colDanUSedmici.HeaderText = "Dan u sedmici";
            this.colDanUSedmici.Name = "colDanUSedmici";
            // 
            // colVrijemePolaskaRasporeda
            // 
            this.colVrijemePolaskaRasporeda.HeaderText = "Vrijeme polaska";
            this.colVrijemePolaskaRasporeda.Name = "colVrijemePolaskaRasporeda";
            this.colVrijemePolaskaRasporeda.Width = 110;
            // 
            // colPotrebnaSjedista
            // 
            this.colPotrebnaSjedista.HeaderText = "Potreban broj sjedišta";
            this.colPotrebnaSjedista.Name = "colPotrebnaSjedista";
            this.colPotrebnaSjedista.Width = 90;
            // 
            // colIdAutobusa
            // 
            this.colIdAutobusa.HeaderText = "Šifra autobusa";
            this.colIdAutobusa.Name = "colIdAutobusa";
            // 
            // UredjivanjeRasporedaVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 387);
            this.Controls.Add(this.gbRasporedi);
            this.Name = "UredjivanjeRasporedaVoznje";
            this.Text = "UredjivanjeRasporedaVoznje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasporediVoznji)).EndInit();
            this.gbRasporedi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRasporediVoznji;
        private System.Windows.Forms.GroupBox gbRasporedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanUSedmici;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijemePolaskaRasporeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPotrebnaSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAutobusa;

    }
}