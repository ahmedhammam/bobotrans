namespace DesktopAplikacija.Informisanje
{
    partial class IzvodIzRedaVoznje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzvodIzRedaVoznje));
            this.lblOdabirStanice = new System.Windows.Forms.Label();
            this.cbStanice = new System.Windows.Forms.ComboBox();
            this.dgvIzvodIzRedaVoznje = new System.Windows.Forms.DataGridView();
            this.colLinija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrijemeDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodIzRedaVoznje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdabirStanice
            // 
            this.lblOdabirStanice.AutoSize = true;
            this.lblOdabirStanice.Location = new System.Drawing.Point(13, 13);
            this.lblOdabirStanice.Name = "lblOdabirStanice";
            this.lblOdabirStanice.Size = new System.Drawing.Size(93, 13);
            this.lblOdabirStanice.TabIndex = 0;
            this.lblOdabirStanice.Text = "Odaberite stanicu:";
            // 
            // cbStanice
            // 
            this.cbStanice.FormattingEnabled = true;
            this.cbStanice.Location = new System.Drawing.Point(112, 10);
            this.cbStanice.Name = "cbStanice";
            this.cbStanice.Size = new System.Drawing.Size(171, 21);
            this.cbStanice.TabIndex = 1;
            this.cbStanice.SelectedIndexChanged += new System.EventHandler(this.cbStanice_SelectedIndexChanged);
            // 
            // dgvIzvodIzRedaVoznje
            // 
            this.dgvIzvodIzRedaVoznje.AllowUserToAddRows = false;
            this.dgvIzvodIzRedaVoznje.AllowUserToDeleteRows = false;
            this.dgvIzvodIzRedaVoznje.AllowUserToResizeColumns = false;
            this.dgvIzvodIzRedaVoznje.AllowUserToResizeRows = false;
            this.dgvIzvodIzRedaVoznje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvIzvodIzRedaVoznje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvodIzRedaVoznje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLinija,
            this.colVrijemeDolaska,
            this.colVrijemePolaska});
            this.dgvIzvodIzRedaVoznje.Location = new System.Drawing.Point(16, 37);
            this.dgvIzvodIzRedaVoznje.MultiSelect = false;
            this.dgvIzvodIzRedaVoznje.Name = "dgvIzvodIzRedaVoznje";
            this.dgvIzvodIzRedaVoznje.ReadOnly = true;
            this.dgvIzvodIzRedaVoznje.Size = new System.Drawing.Size(267, 143);
            this.dgvIzvodIzRedaVoznje.TabIndex = 2;
            // 
            // colLinija
            // 
            this.colLinija.HeaderText = "Linija";
            this.colLinija.Name = "colLinija";
            this.colLinija.ReadOnly = true;
            // 
            // colVrijemeDolaska
            // 
            this.colVrijemeDolaska.HeaderText = "Vrijeme dolaska";
            this.colVrijemeDolaska.Name = "colVrijemeDolaska";
            this.colVrijemeDolaska.ReadOnly = true;
            this.colVrijemeDolaska.Width = 62;
            // 
            // colVrijemePolaska
            // 
            this.colVrijemePolaska.HeaderText = "Vrijeme polaska";
            this.colVrijemePolaska.Name = "colVrijemePolaska";
            this.colVrijemePolaska.ReadOnly = true;
            this.colVrijemePolaska.Width = 62;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIzadji.Location = new System.Drawing.Point(208, 186);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // IzvodIzRedaVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 212);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvIzvodIzRedaVoznje);
            this.Controls.Add(this.cbStanice);
            this.Controls.Add(this.lblOdabirStanice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(311, 99999);
            this.MinimumSize = new System.Drawing.Size(311, 250);
            this.Name = "IzvodIzRedaVoznje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvod iz reda vožnje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodIzRedaVoznje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdabirStanice;
        private System.Windows.Forms.ComboBox cbStanice;
        private System.Windows.Forms.DataGridView dgvIzvodIzRedaVoznje;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinija;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijemeDolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijemePolaska;
    }
}