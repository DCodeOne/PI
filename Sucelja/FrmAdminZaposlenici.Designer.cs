namespace PI_projekt.Sucelja
{
    partial class FrmAdminZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminZaposlenici));
            this.dgvSviZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnZaposleniciOsvjezi = new System.Windows.Forms.Button();
            this.btnZaposleniciDodaj = new System.Windows.Forms.Button();
            this.btnZaposleniciAzuriraj = new System.Windows.Forms.Button();
            this.lblSviZaposlenici = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviZaposlenici
            // 
            this.dgvSviZaposlenici.AllowUserToAddRows = false;
            this.dgvSviZaposlenici.AllowUserToDeleteRows = false;
            this.dgvSviZaposlenici.AllowUserToResizeColumns = false;
            this.dgvSviZaposlenici.AllowUserToResizeRows = false;
            this.dgvSviZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSviZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviZaposlenici.Location = new System.Drawing.Point(10, 40);
            this.dgvSviZaposlenici.MultiSelect = false;
            this.dgvSviZaposlenici.Name = "dgvSviZaposlenici";
            this.dgvSviZaposlenici.ReadOnly = true;
            this.dgvSviZaposlenici.RowHeadersVisible = false;
            this.dgvSviZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviZaposlenici.Size = new System.Drawing.Size(692, 235);
            this.dgvSviZaposlenici.TabIndex = 24;
            this.dgvSviZaposlenici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviZaposlenici_CellClick);
            this.dgvSviZaposlenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviZaposlenici_CellClick);
            // 
            // btnZaposleniciOsvjezi
            // 
            this.btnZaposleniciOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposleniciOsvjezi.Location = new System.Drawing.Point(366, 290);
            this.btnZaposleniciOsvjezi.Name = "btnZaposleniciOsvjezi";
            this.btnZaposleniciOsvjezi.Size = new System.Drawing.Size(80, 35);
            this.btnZaposleniciOsvjezi.TabIndex = 27;
            this.btnZaposleniciOsvjezi.Text = "Osvježi";
            this.btnZaposleniciOsvjezi.UseVisualStyleBackColor = true;
            this.btnZaposleniciOsvjezi.Click += new System.EventHandler(this.btnZaposleniciOsvjezi_Click);
            // 
            // btnZaposleniciDodaj
            // 
            this.btnZaposleniciDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposleniciDodaj.Location = new System.Drawing.Point(452, 290);
            this.btnZaposleniciDodaj.Name = "btnZaposleniciDodaj";
            this.btnZaposleniciDodaj.Size = new System.Drawing.Size(80, 35);
            this.btnZaposleniciDodaj.TabIndex = 28;
            this.btnZaposleniciDodaj.Text = "Dodaj";
            this.btnZaposleniciDodaj.UseVisualStyleBackColor = true;
            this.btnZaposleniciDodaj.Click += new System.EventHandler(this.btnZaposleniciDodaj_Click);
            // 
            // btnZaposleniciAzuriraj
            // 
            this.btnZaposleniciAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposleniciAzuriraj.Location = new System.Drawing.Point(538, 290);
            this.btnZaposleniciAzuriraj.Name = "btnZaposleniciAzuriraj";
            this.btnZaposleniciAzuriraj.Size = new System.Drawing.Size(80, 35);
            this.btnZaposleniciAzuriraj.TabIndex = 29;
            this.btnZaposleniciAzuriraj.Text = "Ažuriraj";
            this.btnZaposleniciAzuriraj.UseVisualStyleBackColor = true;
            this.btnZaposleniciAzuriraj.Click += new System.EventHandler(this.btnZaposleniciAzuriraj_Click);
            // 
            // lblSviZaposlenici
            // 
            this.lblSviZaposlenici.AutoSize = true;
            this.lblSviZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSviZaposlenici.Location = new System.Drawing.Point(10, 10);
            this.lblSviZaposlenici.Name = "lblSviZaposlenici";
            this.lblSviZaposlenici.Size = new System.Drawing.Size(200, 18);
            this.lblSviZaposlenici.TabIndex = 30;
            this.lblSviZaposlenici.Text = "Pregled svih zaposlenika:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(622, 290);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(80, 35);
            this.btnObrisi.TabIndex = 31;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmAdminZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 337);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblSviZaposlenici);
            this.Controls.Add(this.btnZaposleniciAzuriraj);
            this.Controls.Add(this.btnZaposleniciDodaj);
            this.Controls.Add(this.btnZaposleniciOsvjezi);
            this.Controls.Add(this.dgvSviZaposlenici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.FrmAdminZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviZaposlenici;
        private System.Windows.Forms.Button btnZaposleniciOsvjezi;
        private System.Windows.Forms.Button btnZaposleniciDodaj;
        private System.Windows.Forms.Button btnZaposleniciAzuriraj;
        private System.Windows.Forms.Label lblSviZaposlenici;
        private System.Windows.Forms.Button btnObrisi;

    }
}