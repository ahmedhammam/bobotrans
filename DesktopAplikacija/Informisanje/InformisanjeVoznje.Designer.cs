namespace DesktopAplikacija.Informisanje
{
    partial class InformisanjeVoznje
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
            this.lblNazivLinije = new System.Windows.Forms.Label();
            this.lblSifraLinije = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVoznje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojVoznji = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNazivLinije
            // 
            this.lblNazivLinije.AutoSize = true;
            this.lblNazivLinije.Location = new System.Drawing.Point(6, 19);
            this.lblNazivLinije.Name = "lblNazivLinije";
            this.lblNazivLinije.Size = new System.Drawing.Size(60, 13);
            this.lblNazivLinije.TabIndex = 0;
            this.lblNazivLinije.Text = "Naziv linije:";
            // 
            // lblSifraLinije
            // 
            this.lblSifraLinije.AutoSize = true;
            this.lblSifraLinije.Location = new System.Drawing.Point(6, 34);
            this.lblSifraLinije.Name = "lblSifraLinije";
            this.lblSifraLinije.Size = new System.Drawing.Size(54, 13);
            this.lblSifraLinije.TabIndex = 1;
            this.lblSifraLinije.Text = "Sifra linije:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(359, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBrojVoznji);
            this.groupBox1.Controls.Add(this.lblNazivLinije);
            this.groupBox1.Controls.Add(this.lblSifraLinije);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linija";
            // 
            // cbVoznje
            // 
            this.cbVoznje.FormattingEnabled = true;
            this.cbVoznje.Location = new System.Drawing.Point(215, 82);
            this.cbVoznje.Name = "cbVoznje";
            this.cbVoznje.Size = new System.Drawing.Size(121, 21);
            this.cbVoznje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prikazi podatke za voznju:";
            // 
            // lblBrojVoznji
            // 
            this.lblBrojVoznji.AutoSize = true;
            this.lblBrojVoznji.Location = new System.Drawing.Point(6, 51);
            this.lblBrojVoznji.Name = "lblBrojVoznji";
            this.lblBrojVoznji.Size = new System.Drawing.Size(58, 13);
            this.lblBrojVoznji.TabIndex = 2;
            this.lblBrojVoznji.Text = "Broj voznji:";
            // 
            // InformisanjeVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVoznje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InformisanjeVoznje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformisanjeVoznje";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivLinije;
        private System.Windows.Forms.Label lblSifraLinije;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVoznje;
        private System.Windows.Forms.Label lblBrojVoznji;
        private System.Windows.Forms.Label label1;
    }
}