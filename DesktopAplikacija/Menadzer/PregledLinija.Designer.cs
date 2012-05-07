namespace DesktopAplikacija.Menadzer
{
    partial class PregledLinija
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
            this.lvLinije = new System.Windows.Forms.ListView();
            this.colSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvLinije
            // 
            this.lvLinije.CheckBoxes = true;
            this.lvLinije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSifra,
            this.colNaziv});
            this.lvLinije.FullRowSelect = true;
            this.lvLinije.Location = new System.Drawing.Point(12, 75);
            this.lvLinije.Name = "lvLinije";
            this.lvLinije.Size = new System.Drawing.Size(291, 201);
            this.lvLinije.TabIndex = 0;
            this.lvLinije.UseCompatibleStateImageBehavior = false;
            this.lvLinije.View = System.Windows.Forms.View.Details;
            this.lvLinije.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
            this.lvLinije.SelectedIndexChanged += new System.EventHandler(this.lvLinije_SelectedIndexChanged);
            // 
            // colSifra
            // 
            this.colSifra.Text = "Šifra";
            // 
            // colNaziv
            // 
            this.colNaziv.Text = "Naziv linije";
            this.colNaziv.Width = 227;
            // 
            // PregledLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 392);
            this.Controls.Add(this.lvLinije);
            this.Name = "PregledLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UredjivanjeLinija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLinije;
        private System.Windows.Forms.ColumnHeader colSifra;
        private System.Windows.Forms.ColumnHeader colNaziv;
    }
}