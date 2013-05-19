namespace PI_projekt.Sucelja
{
    partial class zaposlenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zaposlenik));
            this.zapUlaznice = new System.Windows.Forms.Button();
            this.zapArtikli = new System.Windows.Forms.Button();
            this.identitet = new System.Windows.Forms.Label();
            this.odjava = new System.Windows.Forms.LinkLabel();
            this.zaposleni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zapUlaznice
            // 
            this.zapUlaznice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zapUlaznice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapUlaznice.Location = new System.Drawing.Point(164, 60);
            this.zapUlaznice.Name = "zapUlaznice";
            this.zapUlaznice.Size = new System.Drawing.Size(100, 30);
            this.zapUlaznice.TabIndex = 0;
            this.zapUlaznice.Text = "Ulaznice";
            this.zapUlaznice.UseVisualStyleBackColor = true;
            // 
            // zapArtikli
            // 
            this.zapArtikli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zapArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapArtikli.Location = new System.Drawing.Point(164, 120);
            this.zapArtikli.Name = "zapArtikli";
            this.zapArtikli.Size = new System.Drawing.Size(100, 30);
            this.zapArtikli.TabIndex = 1;
            this.zapArtikli.Text = "Artikli";
            this.zapArtikli.UseVisualStyleBackColor = true;
            // 
            // identitet
            // 
            this.identitet.AutoSize = true;
            this.identitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.identitet.Location = new System.Drawing.Point(12, 9);
            this.identitet.Name = "identitet";
            this.identitet.Size = new System.Drawing.Size(146, 18);
            this.identitet.TabIndex = 2;
            this.identitet.Text = "Prijavljeni ste kao:";
            // 
            // odjava
            // 
            this.odjava.AutoSize = true;
            this.odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.Location = new System.Drawing.Point(331, 9);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(57, 18);
            this.odjava.TabIndex = 3;
            this.odjava.TabStop = true;
            this.odjava.Text = "odjava";
            // 
            // zaposleni
            // 
            this.zaposleni.Location = new System.Drawing.Point(164, 9);
            this.zaposleni.Name = "zaposleni";
            this.zaposleni.Size = new System.Drawing.Size(140, 20);
            this.zaposleni.TabIndex = 4;
            // 
            // zaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 187);
            this.Controls.Add(this.zaposleni);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.identitet);
            this.Controls.Add(this.zapArtikli);
            this.Controls.Add(this.zapUlaznice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "zaposlenik";
            this.Text = "Zaposlenik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zapUlaznice;
        private System.Windows.Forms.Button zapArtikli;
        private System.Windows.Forms.Label identitet;
        private System.Windows.Forms.LinkLabel odjava;
        private System.Windows.Forms.TextBox zaposleni;
    }
}