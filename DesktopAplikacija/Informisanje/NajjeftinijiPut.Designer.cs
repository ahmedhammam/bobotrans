namespace DesktopAplikacija.Informisanje
{
    partial class NajjeftinijiPut
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
            this.cbPocetna = new System.Windows.Forms.ComboBox();
            this.cbKrajnja = new System.Windows.Forms.ComboBox();
            this.lblPocetnaStanica = new System.Windows.Forms.Label();
            this.lblKrajnjaStanica = new System.Windows.Forms.Label();
            this.gbOdabir = new System.Windows.Forms.GroupBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOdabir.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPocetna
            // 
            this.cbPocetna.FormattingEnabled = true;
            this.cbPocetna.Location = new System.Drawing.Point(98, 19);
            this.cbPocetna.Name = "cbPocetna";
            this.cbPocetna.Size = new System.Drawing.Size(187, 21);
            this.cbPocetna.TabIndex = 0;
            // 
            // cbKrajnja
            // 
            this.cbKrajnja.FormattingEnabled = true;
            this.cbKrajnja.Location = new System.Drawing.Point(98, 50);
            this.cbKrajnja.Name = "cbKrajnja";
            this.cbKrajnja.Size = new System.Drawing.Size(187, 21);
            this.cbKrajnja.TabIndex = 1;
            // 
            // lblPocetnaStanica
            // 
            this.lblPocetnaStanica.AutoSize = true;
            this.lblPocetnaStanica.Location = new System.Drawing.Point(5, 22);
            this.lblPocetnaStanica.Name = "lblPocetnaStanica";
            this.lblPocetnaStanica.Size = new System.Drawing.Size(87, 13);
            this.lblPocetnaStanica.TabIndex = 2;
            this.lblPocetnaStanica.Text = "Pocetna stanica:";
            // 
            // lblKrajnjaStanica
            // 
            this.lblKrajnjaStanica.AutoSize = true;
            this.lblKrajnjaStanica.Location = new System.Drawing.Point(5, 53);
            this.lblKrajnjaStanica.Name = "lblKrajnjaStanica";
            this.lblKrajnjaStanica.Size = new System.Drawing.Size(79, 13);
            this.lblKrajnjaStanica.TabIndex = 3;
            this.lblKrajnjaStanica.Text = "Krajnja stanica:";
            // 
            // gbOdabir
            // 
            this.gbOdabir.Controls.Add(this.cbPocetna);
            this.gbOdabir.Controls.Add(this.lblKrajnjaStanica);
            this.gbOdabir.Controls.Add(this.cbKrajnja);
            this.gbOdabir.Controls.Add(this.lblPocetnaStanica);
            this.gbOdabir.Location = new System.Drawing.Point(12, 12);
            this.gbOdabir.Name = "gbOdabir";
            this.gbOdabir.Size = new System.Drawing.Size(291, 86);
            this.gbOdabir.TabIndex = 4;
            this.gbOdabir.TabStop = false;
            this.gbOdabir.Text = "Odabir stanica";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(15, 108);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(89, 13);
            this.lblCijena.TabIndex = 5;
            this.lblCijena.Text = "Najjeftinija cijena:";
            // 
            // tbCijena
            // 
            this.tbCijena.Location = new System.Drawing.Point(110, 105);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.ReadOnly = true;
            this.tbCijena.Size = new System.Drawing.Size(57, 20);
            this.tbCijena.TabIndex = 6;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOpis.Location = new System.Drawing.Point(12, 151);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.ReadOnly = true;
            this.rtbOpis.Size = new System.Drawing.Size(291, 212);
            this.rtbOpis.TabIndex = 7;
            this.rtbOpis.Text = "";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(18, 135);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(55, 13);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Opis puta:";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzadji.Location = new System.Drawing.Point(228, 369);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 9;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzracunaj.Location = new System.Drawing.Point(147, 369);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 10;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "KM";
            // 
            // NajjeftinijiPut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.tbCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.gbOdabir);
            this.MaximumSize = new System.Drawing.Size(331, 440);
            this.MinimumSize = new System.Drawing.Size(331, 440);
            this.Name = "NajjeftinijiPut";
            this.Text = "Najjeftiniji put";
            this.gbOdabir.ResumeLayout(false);
            this.gbOdabir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPocetna;
        private System.Windows.Forms.ComboBox cbKrajnja;
        private System.Windows.Forms.Label lblPocetnaStanica;
        private System.Windows.Forms.Label lblKrajnjaStanica;
        private System.Windows.Forms.GroupBox gbOdabir;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label label1;
    }
}