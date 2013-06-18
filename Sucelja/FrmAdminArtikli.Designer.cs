namespace PI_projekt.Sucelja
{
    partial class FrmAdminArtikli
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
            this.dgvSviArtikli = new System.Windows.Forms.DataGridView();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.btnOsvjeziArtikle = new System.Windows.Forms.Button();
            this.btnAzurirajArtikl = new System.Windows.Forms.Button();
            this.lblSviArtikli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviArtikli
            // 
            this.dgvSviArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviArtikli.Location = new System.Drawing.Point(12, 42);
            this.dgvSviArtikli.Name = "dgvSviArtikli";
            this.dgvSviArtikli.RowTemplate.Height = 24;
            this.dgvSviArtikli.Size = new System.Drawing.Size(881, 291);
            this.dgvSviArtikli.TabIndex = 0;
            this.dgvSviArtikli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviArtikli_CellClick);
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(648, 358);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(95, 36);
            this.btnDodajArtikl.TabIndex = 1;
            this.btnDodajArtikl.Text = "Dodaj";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // btnOsvjeziArtikle
            // 
            this.btnOsvjeziArtikle.Location = new System.Drawing.Point(545, 358);
            this.btnOsvjeziArtikle.Name = "btnOsvjeziArtikle";
            this.btnOsvjeziArtikle.Size = new System.Drawing.Size(97, 36);
            this.btnOsvjeziArtikle.TabIndex = 2;
            this.btnOsvjeziArtikle.Text = "Osvježi";
            this.btnOsvjeziArtikle.UseVisualStyleBackColor = true;
            this.btnOsvjeziArtikle.Click += new System.EventHandler(this.btnOsvjeziArtikle_Click);
            // 
            // btnAzurirajArtikl
            // 
            this.btnAzurirajArtikl.Location = new System.Drawing.Point(749, 357);
            this.btnAzurirajArtikl.Name = "btnAzurirajArtikl";
            this.btnAzurirajArtikl.Size = new System.Drawing.Size(102, 37);
            this.btnAzurirajArtikl.TabIndex = 3;
            this.btnAzurirajArtikl.Text = "Ažuriraj";
            this.btnAzurirajArtikl.UseVisualStyleBackColor = true;
            this.btnAzurirajArtikl.Click += new System.EventHandler(this.btnAzurirajArtikl_Click);
            // 
            // lblSviArtikli
            // 
            this.lblSviArtikli.AutoSize = true;
            this.lblSviArtikli.Location = new System.Drawing.Point(24, 16);
            this.lblSviArtikli.Name = "lblSviArtikli";
            this.lblSviArtikli.Size = new System.Drawing.Size(68, 17);
            this.lblSviArtikli.TabIndex = 5;
            this.lblSviArtikli.Text = "Svi artikli:";
            // 
            // FrmAdminArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 417);
            this.Controls.Add(this.lblSviArtikli);
            this.Controls.Add(this.btnAzurirajArtikl);
            this.Controls.Add(this.btnOsvjeziArtikle);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.dgvSviArtikli);
            this.Name = "FrmAdminArtikli";
            this.Text = "Administrator Artikli";
            this.Load += new System.EventHandler(this.FrmAdminArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviArtikli;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Button btnOsvjeziArtikle;
        private System.Windows.Forms.Button btnAzurirajArtikl;
        private System.Windows.Forms.Label lblSviArtikli;
    }
}