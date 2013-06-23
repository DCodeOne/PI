namespace PI_projekt.Sucelja
{
    partial class FrmAdminProjekcije
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
            this.dgvSveProjekcije = new System.Windows.Forms.DataGridView();
            this.btnProjekcijeOsvjezi = new System.Windows.Forms.Button();
            this.btnProjekcijeDodaj = new System.Windows.Forms.Button();
            this.btnProjekcijeAžuriraj = new System.Windows.Forms.Button();
            this.lblSveProjekcije = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveProjekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSveProjekcije
            // 
            this.dgvSveProjekcije.AllowUserToAddRows = false;
            this.dgvSveProjekcije.AllowUserToDeleteRows = false;
            this.dgvSveProjekcije.AllowUserToResizeColumns = false;
            this.dgvSveProjekcije.AllowUserToResizeRows = false;
            this.dgvSveProjekcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSveProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveProjekcije.Location = new System.Drawing.Point(10, 40);
            this.dgvSveProjekcije.MultiSelect = false;
            this.dgvSveProjekcije.Name = "dgvSveProjekcije";
            this.dgvSveProjekcije.ReadOnly = true;
            this.dgvSveProjekcije.RowHeadersVisible = false;
            this.dgvSveProjekcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSveProjekcije.Size = new System.Drawing.Size(612, 235);
            this.dgvSveProjekcije.TabIndex = 23;
            this.dgvSveProjekcije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSveProjekcije_CellClick);
            // 
            // btnProjekcijeOsvjezi
            // 
            this.btnProjekcijeOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProjekcijeOsvjezi.Location = new System.Drawing.Point(370, 290);
            this.btnProjekcijeOsvjezi.Name = "btnProjekcijeOsvjezi";
            this.btnProjekcijeOsvjezi.Size = new System.Drawing.Size(80, 35);
            this.btnProjekcijeOsvjezi.TabIndex = 25;
            this.btnProjekcijeOsvjezi.Text = "Osvježi";
            this.btnProjekcijeOsvjezi.UseVisualStyleBackColor = true;
            this.btnProjekcijeOsvjezi.Click += new System.EventHandler(this.btnProjekcijeOsvjezi_Click);
            // 
            // btnProjekcijeDodaj
            // 
            this.btnProjekcijeDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProjekcijeDodaj.Location = new System.Drawing.Point(456, 290);
            this.btnProjekcijeDodaj.Name = "btnProjekcijeDodaj";
            this.btnProjekcijeDodaj.Size = new System.Drawing.Size(80, 35);
            this.btnProjekcijeDodaj.TabIndex = 26;
            this.btnProjekcijeDodaj.Text = "Dodaj";
            this.btnProjekcijeDodaj.UseVisualStyleBackColor = true;
            this.btnProjekcijeDodaj.Click += new System.EventHandler(this.btnProjekcijeDodaj_Click);
            // 
            // btnProjekcijeAžuriraj
            // 
            this.btnProjekcijeAžuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProjekcijeAžuriraj.Location = new System.Drawing.Point(542, 290);
            this.btnProjekcijeAžuriraj.Name = "btnProjekcijeAžuriraj";
            this.btnProjekcijeAžuriraj.Size = new System.Drawing.Size(80, 35);
            this.btnProjekcijeAžuriraj.TabIndex = 27;
            this.btnProjekcijeAžuriraj.Text = "Ažuriraj";
            this.btnProjekcijeAžuriraj.UseVisualStyleBackColor = true;
            this.btnProjekcijeAžuriraj.Click += new System.EventHandler(this.btnProjekcijeAžuriraj_Click);
            // 
            // lblSveProjekcije
            // 
            this.lblSveProjekcije.AutoSize = true;
            this.lblSveProjekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSveProjekcije.Location = new System.Drawing.Point(10, 10);
            this.lblSveProjekcije.Name = "lblSveProjekcije";
            this.lblSveProjekcije.Size = new System.Drawing.Size(183, 18);
            this.lblSveProjekcije.TabIndex = 28;
            this.lblSveProjekcije.Text = "Pregled svih projekcija:";
            // 
            // FrmAdminProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 337);
            this.Controls.Add(this.lblSveProjekcije);
            this.Controls.Add(this.btnProjekcijeAžuriraj);
            this.Controls.Add(this.btnProjekcijeDodaj);
            this.Controls.Add(this.btnProjekcijeOsvjezi);
            this.Controls.Add(this.dgvSveProjekcije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminProjekcije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekcije";
            this.Load += new System.EventHandler(this.FrmAdminProjekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveProjekcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSveProjekcije;
        private System.Windows.Forms.Button btnProjekcijeOsvjezi;
        private System.Windows.Forms.Button btnProjekcijeDodaj;
        private System.Windows.Forms.Button btnProjekcijeAžuriraj;
        private System.Windows.Forms.Label lblSveProjekcije;
    }
}