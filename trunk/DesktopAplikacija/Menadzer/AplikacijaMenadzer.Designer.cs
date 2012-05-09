namespace DesktopAplikacija.Menadzer
{
    partial class AplikacijaMenadzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AplikacijaMenadzer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAutobus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLinije = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIznajmljivanje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informisanjeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeOLinijamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izvodIzRedaVožnjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazNajjeftinijegPutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeOLinijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvodIzRedaVožnjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nalaženjeNajjeftinijegPutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informisanjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPoruke = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAutobus);
            this.groupBox1.Location = new System.Drawing.Point(33, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled autobusa";
            // 
            // btnAutobus
            // 
            this.btnAutobus.BackgroundImage = global::DesktopAplikacija.Properties.Resources._1bus22_med;
            this.btnAutobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutobus.Location = new System.Drawing.Point(16, 26);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Size = new System.Drawing.Size(213, 157);
            this.btnAutobus.TabIndex = 0;
            this.btnAutobus.UseVisualStyleBackColor = true;
            this.btnAutobus.Click += new System.EventHandler(this.btnAutobus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLinije);
            this.groupBox2.Location = new System.Drawing.Point(286, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pregled linija";
            // 
            // btnLinije
            // 
            this.btnLinije.BackgroundImage = global::DesktopAplikacija.Properties.Resources.BUS_STOP_STATION;
            this.btnLinije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinije.Location = new System.Drawing.Point(18, 30);
            this.btnLinije.Name = "btnLinije";
            this.btnLinije.Size = new System.Drawing.Size(213, 157);
            this.btnLinije.TabIndex = 0;
            this.btnLinije.UseVisualStyleBackColor = true;
            this.btnLinije.Click += new System.EventHandler(this.btnLinije_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIznajmljivanje);
            this.groupBox3.Location = new System.Drawing.Point(539, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Iznajmljivanje autobusa";
            // 
            // btnIznajmljivanje
            // 
            this.btnIznajmljivanje.BackgroundImage = global::DesktopAplikacija.Properties.Resources.Logo_sa_palmom;
            this.btnIznajmljivanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIznajmljivanje.Location = new System.Drawing.Point(16, 30);
            this.btnIznajmljivanje.Name = "btnIznajmljivanje";
            this.btnIznajmljivanje.Size = new System.Drawing.Size(213, 157);
            this.btnIznajmljivanje.TabIndex = 0;
            this.btnIznajmljivanje.UseVisualStyleBackColor = true;
            this.btnIznajmljivanje.Click += new System.EventHandler(this.btnIznajmljivanje_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informisanjeToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informisanjeToolStripMenuItem2
            // 
            this.informisanjeToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informisanjeOLinijamaToolStripMenuItem1,
            this.izvodIzRedaVožnjeToolStripMenuItem1,
            this.prikazNajjeftinijegPutaToolStripMenuItem});
            this.informisanjeToolStripMenuItem2.Name = "informisanjeToolStripMenuItem2";
            this.informisanjeToolStripMenuItem2.Size = new System.Drawing.Size(85, 20);
            this.informisanjeToolStripMenuItem2.Text = "Informisanje";
            // 
            // informisanjeOLinijamaToolStripMenuItem1
            // 
            this.informisanjeOLinijamaToolStripMenuItem1.Name = "informisanjeOLinijamaToolStripMenuItem1";
            this.informisanjeOLinijamaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.informisanjeOLinijamaToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.informisanjeOLinijamaToolStripMenuItem1.Text = "Informisanje o linijama";
            this.informisanjeOLinijamaToolStripMenuItem1.Click += new System.EventHandler(this.informisanjeOLinijamaToolStripMenuItem_Click);
            // 
            // izvodIzRedaVožnjeToolStripMenuItem1
            // 
            this.izvodIzRedaVožnjeToolStripMenuItem1.Name = "izvodIzRedaVožnjeToolStripMenuItem1";
            this.izvodIzRedaVožnjeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.izvodIzRedaVožnjeToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.izvodIzRedaVožnjeToolStripMenuItem1.Text = "Izvod iz reda vožnje";
            this.izvodIzRedaVožnjeToolStripMenuItem1.Click += new System.EventHandler(this.izvodIzRedaVožnjeToolStripMenuItem_Click);
            // 
            // prikazNajjeftinijegPutaToolStripMenuItem
            // 
            this.prikazNajjeftinijegPutaToolStripMenuItem.Name = "prikazNajjeftinijegPutaToolStripMenuItem";
            this.prikazNajjeftinijegPutaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.prikazNajjeftinijegPutaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.prikazNajjeftinijegPutaToolStripMenuItem.Text = "Najjeftiniji put";
            this.prikazNajjeftinijegPutaToolStripMenuItem.Click += new System.EventHandler(this.nalaženjeNajjeftinijegPutaToolStripMenuItem_Click);
            // 
            // informisanjeToolStripMenuItem
            // 
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
            // informisanjeToolStripMenuItem1
            // 
            this.informisanjeToolStripMenuItem1.Name = "informisanjeToolStripMenuItem1";
            this.informisanjeToolStripMenuItem1.Size = new System.Drawing.Size(85, 20);
            this.informisanjeToolStripMenuItem1.Text = "Informisanje";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPoruke});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPoruke
            // 
            this.tsbPoruke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPoruke.Image = ((System.Drawing.Image)(resources.GetObject("tsbPoruke.Image")));
            this.tsbPoruke.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPoruke.Name = "tsbPoruke";
            this.tsbPoruke.Size = new System.Drawing.Size(23, 22);
            this.tsbPoruke.ToolTipText = "Otvori poruke";
            this.tsbPoruke.Click += new System.EventHandler(this.tsbPoruke_Click);
            // 
            // AplikacijaMenadzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 306);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AplikacijaMenadzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AplikacijaMenadzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AplikacijaMenadzer_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutobus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLinije;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIznajmljivanje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informisanjeOLinijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvodIzRedaVožnjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nalaženjeNajjeftinijegPutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informisanjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informisanjeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem informisanjeOLinijamaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izvodIzRedaVožnjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prikazNajjeftinijegPutaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPoruke;


    }
}