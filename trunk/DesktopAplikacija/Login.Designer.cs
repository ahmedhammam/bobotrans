namespace DesktopAplikacija
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.l_nazivKorisnika = new System.Windows.Forms.Label();
            this.l_sifra = new System.Windows.Forms.Label();
            this.t_nazivKorisnika = new System.Windows.Forms.TextBox();
            this.t_sifraKorisnika = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_izadi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_nazivKorisnika
            // 
            this.l_nazivKorisnika.AutoSize = true;
            this.l_nazivKorisnika.Location = new System.Drawing.Point(66, 42);
            this.l_nazivKorisnika.Name = "l_nazivKorisnika";
            this.l_nazivKorisnika.Size = new System.Drawing.Size(82, 13);
            this.l_nazivKorisnika.TabIndex = 0;
            this.l_nazivKorisnika.Text = "Naziv korisnika:";
            this.l_nazivKorisnika.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_sifra
            // 
            this.l_sifra.AutoSize = true;
            this.l_sifra.Location = new System.Drawing.Point(66, 82);
            this.l_sifra.Name = "l_sifra";
            this.l_sifra.Size = new System.Drawing.Size(31, 13);
            this.l_sifra.TabIndex = 1;
            this.l_sifra.Text = "Šifra:";
            // 
            // t_nazivKorisnika
            // 
            this.t_nazivKorisnika.Location = new System.Drawing.Point(165, 35);
            this.t_nazivKorisnika.Name = "t_nazivKorisnika";
            this.t_nazivKorisnika.Size = new System.Drawing.Size(116, 20);
            this.t_nazivKorisnika.TabIndex = 2;
            this.t_nazivKorisnika.Validating += new System.ComponentModel.CancelEventHandler(this.t_nazivKorisnika_Validating);
            // 
            // t_sifraKorisnika
            // 
            this.t_sifraKorisnika.Location = new System.Drawing.Point(165, 82);
            this.t_sifraKorisnika.Name = "t_sifraKorisnika";
            this.t_sifraKorisnika.PasswordChar = '*';
            this.t_sifraKorisnika.Size = new System.Drawing.Size(116, 20);
            this.t_sifraKorisnika.TabIndex = 3;
            this.t_sifraKorisnika.Validating += new System.ComponentModel.CancelEventHandler(this.t_sifraKorisnika_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.l_nazivKorisnika);
            this.groupBox1.Controls.Add(this.t_sifraKorisnika);
            this.groupBox1.Controls.Add(this.l_sifra);
            this.groupBox1.Controls.Add(this.t_nazivKorisnika);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(225, 172);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 5;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_izadi
            // 
            this.b_izadi.Location = new System.Drawing.Point(306, 172);
            this.b_izadi.Name = "b_izadi";
            this.b_izadi.Size = new System.Drawing.Size(75, 23);
            this.b_izadi.TabIndex = 6;
            this.b_izadi.Text = "Izađi";
            this.b_izadi.UseVisualStyleBackColor = true;
            this.b_izadi.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 200);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(393, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 222);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.b_izadi);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Bobo Trans";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nazivKorisnika;
        private System.Windows.Forms.Label l_sifra;
        private System.Windows.Forms.TextBox t_nazivKorisnika;
        private System.Windows.Forms.TextBox t_sifraKorisnika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_izadi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
    }
}

