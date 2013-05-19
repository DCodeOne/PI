namespace PI_projekt.Artikli
{
    partial class Artikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artikli));
            this.Naziv_artikla = new System.Windows.Forms.Label();
            this.Cijena = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.ComboBox();
            this.Kolicina = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Ponisti = new System.Windows.Forms.Button();
            this.Cijena_box = new System.Windows.Forms.TextBox();
            this.Kolicina_box = new System.Windows.Forms.TextBox();
            this.Stavke_racun = new System.Windows.Forms.GroupBox();
            this.Iznos_racun = new System.Windows.Forms.Label();
            this.Ukupno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Naziv_artikla
            // 
            this.Naziv_artikla.AutoSize = true;
            this.Naziv_artikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naziv_artikla.Location = new System.Drawing.Point(33, 15);
            this.Naziv_artikla.Name = "Naziv_artikla";
            this.Naziv_artikla.Size = new System.Drawing.Size(89, 17);
            this.Naziv_artikla.TabIndex = 0;
            this.Naziv_artikla.Text = "Naziv artikla:";
            this.Naziv_artikla.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cijena
            // 
            this.Cijena.AutoSize = true;
            this.Cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cijena.Location = new System.Drawing.Point(33, 53);
            this.Cijena.Name = "Cijena";
            this.Cijena.Size = new System.Drawing.Size(113, 17);
            this.Cijena.TabIndex = 2;
            this.Cijena.Text = "Jedinična cijena:";
            // 
            // Naziv
            // 
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naziv.FormattingEnabled = true;
            this.Naziv.Location = new System.Drawing.Point(173, 15);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(171, 21);
            this.Naziv.TabIndex = 3;
            this.Naziv.Text = "Odabir artikla...";
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSize = true;
            this.Kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kolicina.Location = new System.Drawing.Point(33, 86);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(61, 17);
            this.Kolicina.TabIndex = 4;
            this.Kolicina.Text = "Količina:";
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(36, 273);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 5;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ponisti
            // 
            this.Ponisti.Location = new System.Drawing.Point(127, 272);
            this.Ponisti.Name = "Ponisti";
            this.Ponisti.Size = new System.Drawing.Size(75, 23);
            this.Ponisti.TabIndex = 6;
            this.Ponisti.Text = "Poništi";
            this.Ponisti.UseVisualStyleBackColor = true;
            // 
            // Cijena_box
            // 
            this.Cijena_box.Location = new System.Drawing.Point(173, 51);
            this.Cijena_box.Name = "Cijena_box";
            this.Cijena_box.Size = new System.Drawing.Size(94, 20);
            this.Cijena_box.TabIndex = 7;
            this.Cijena_box.Text = " kn";
            // 
            // Kolicina_box
            // 
            this.Kolicina_box.Location = new System.Drawing.Point(173, 86);
            this.Kolicina_box.Name = "Kolicina_box";
            this.Kolicina_box.Size = new System.Drawing.Size(94, 20);
            this.Kolicina_box.TabIndex = 8;
            this.Kolicina_box.Text = "0,00";
            // 
            // Stavke_racun
            // 
            this.Stavke_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stavke_racun.Location = new System.Drawing.Point(36, 130);
            this.Stavke_racun.Name = "Stavke_racun";
            this.Stavke_racun.Size = new System.Drawing.Size(438, 126);
            this.Stavke_racun.TabIndex = 9;
            this.Stavke_racun.TabStop = false;
            this.Stavke_racun.Text = "Stavke računa";
            // 
            // Iznos_racun
            // 
            this.Iznos_racun.AutoSize = true;
            this.Iznos_racun.Location = new System.Drawing.Point(297, 274);
            this.Iznos_racun.Name = "Iznos_racun";
            this.Iznos_racun.Size = new System.Drawing.Size(71, 13);
            this.Iznos_racun.TabIndex = 10;
            this.Iznos_racun.Text = "Iznos računa:";
            // 
            // Ukupno
            // 
            this.Ukupno.Location = new System.Drawing.Point(374, 271);
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.Size = new System.Drawing.Size(100, 20);
            this.Ukupno.TabIndex = 11;
            this.Ukupno.Text = "0,00 kn";
            // 
            // Artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 370);
            this.Controls.Add(this.Ukupno);
            this.Controls.Add(this.Iznos_racun);
            this.Controls.Add(this.Stavke_racun);
            this.Controls.Add(this.Kolicina_box);
            this.Controls.Add(this.Cijena_box);
            this.Controls.Add(this.Ponisti);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Kolicina);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.Cijena);
            this.Controls.Add(this.Naziv_artikla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Artikli";
            this.Text = "Artikli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naziv_artikla;
        private System.Windows.Forms.Label Cijena;
        private System.Windows.Forms.ComboBox Naziv;
        private System.Windows.Forms.Label Kolicina;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Ponisti;
        private System.Windows.Forms.TextBox Cijena_box;
        private System.Windows.Forms.TextBox Kolicina_box;
        private System.Windows.Forms.GroupBox Stavke_racun;
        private System.Windows.Forms.Label Iznos_racun;
        private System.Windows.Forms.TextBox Ukupno;

    }
}