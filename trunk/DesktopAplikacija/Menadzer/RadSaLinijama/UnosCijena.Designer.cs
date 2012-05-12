namespace DesktopAplikacija.Menadzer
{
    partial class UnosCijena
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
            this.gbCijene = new System.Windows.Forms.GroupBox();
            this.dgvCijene = new System.Windows.Forms.DataGridView();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.gbCijene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijene)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCijene
            // 
            this.gbCijene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCijene.Controls.Add(this.dgvCijene);
            this.gbCijene.Location = new System.Drawing.Point(12, 12);
            this.gbCijene.Name = "gbCijene";
            this.gbCijene.Size = new System.Drawing.Size(534, 224);
            this.gbCijene.TabIndex = 3;
            this.gbCijene.TabStop = false;
            this.gbCijene.Text = "Cijene (Unositi zarez kao decimalno mjesto)";
            // 
            // dgvCijene
            // 
            this.dgvCijene.AllowUserToAddRows = false;
            this.dgvCijene.AllowUserToDeleteRows = false;
            this.dgvCijene.AllowUserToResizeColumns = false;
            this.dgvCijene.AllowUserToResizeRows = false;
            this.dgvCijene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCijene.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCijene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCijene.Location = new System.Drawing.Point(7, 20);
            this.dgvCijene.Name = "dgvCijene";
            this.dgvCijene.RowHeadersWidth = 180;
            this.dgvCijene.Size = new System.Drawing.Size(521, 191);
            this.dgvCijene.TabIndex = 0;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzadji.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIzadji.Location = new System.Drawing.Point(468, 243);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpasi.Location = new System.Drawing.Point(387, 243);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 5;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // UnosCijena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIzadji;
            this.ClientSize = new System.Drawing.Size(558, 278);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.gbCijene);
            this.MaximumSize = new System.Drawing.Size(1487, 673);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "UnosCijena";
            this.Text = "Unos cijena za novu liniju";
            this.gbCijene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCijene;
        private System.Windows.Forms.DataGridView dgvCijene;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnSpasi;
    }
}