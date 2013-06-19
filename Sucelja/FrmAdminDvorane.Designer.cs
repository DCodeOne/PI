namespace PI_projekt.Sucelja
{
    partial class FrmAdminDvorane
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
            this.btnDvoranePovratak = new System.Windows.Forms.Button();
            this.btnDvoraneAzuriraj = new System.Windows.Forms.Button();
            this.btnDvoraneDodaj = new System.Windows.Forms.Button();
            this.btnDvoraneOsvjezi = new System.Windows.Forms.Button();
            this.dgvSveDvorane = new System.Windows.Forms.DataGridView();
            this.lblDvorane = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveDvorane)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDvoranePovratak
            // 
            this.btnDvoranePovratak.Location = new System.Drawing.Point(12, 398);
            this.btnDvoranePovratak.Name = "btnDvoranePovratak";
            this.btnDvoranePovratak.Size = new System.Drawing.Size(75, 23);
            this.btnDvoranePovratak.TabIndex = 0;
            this.btnDvoranePovratak.Text = "Povratak";
            this.btnDvoranePovratak.UseVisualStyleBackColor = true;
            this.btnDvoranePovratak.Click += new System.EventHandler(this.btnDvoranePovratak_Click);
            // 
            // btnDvoraneAzuriraj
            // 
            this.btnDvoraneAzuriraj.Location = new System.Drawing.Point(695, 398);
            this.btnDvoraneAzuriraj.Name = "btnDvoraneAzuriraj";
            this.btnDvoraneAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnDvoraneAzuriraj.TabIndex = 1;
            this.btnDvoraneAzuriraj.Text = "Ažuriraj";
            this.btnDvoraneAzuriraj.UseVisualStyleBackColor = true;
            this.btnDvoraneAzuriraj.Click += new System.EventHandler(this.btnDvoraneAzuriraj_Click);
            // 
            // btnDvoraneDodaj
            // 
            this.btnDvoraneDodaj.Location = new System.Drawing.Point(614, 398);
            this.btnDvoraneDodaj.Name = "btnDvoraneDodaj";
            this.btnDvoraneDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDvoraneDodaj.TabIndex = 2;
            this.btnDvoraneDodaj.Text = "Dodaj";
            this.btnDvoraneDodaj.UseVisualStyleBackColor = true;
            this.btnDvoraneDodaj.Click += new System.EventHandler(this.btnDvoraneDodaj_Click);
            // 
            // btnDvoraneOsvjezi
            // 
            this.btnDvoraneOsvjezi.Location = new System.Drawing.Point(533, 398);
            this.btnDvoraneOsvjezi.Name = "btnDvoraneOsvjezi";
            this.btnDvoraneOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnDvoraneOsvjezi.TabIndex = 3;
            this.btnDvoraneOsvjezi.Text = "Osvježi";
            this.btnDvoraneOsvjezi.UseVisualStyleBackColor = true;
            this.btnDvoraneOsvjezi.Click += new System.EventHandler(this.btnDvoraneOsvjezi_Click);
            // 
            // dgvSveDvorane
            // 
            this.dgvSveDvorane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveDvorane.Location = new System.Drawing.Point(13, 110);
            this.dgvSveDvorane.Name = "dgvSveDvorane";
            this.dgvSveDvorane.Size = new System.Drawing.Size(757, 282);
            this.dgvSveDvorane.TabIndex = 4;
            this.dgvSveDvorane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSveDvorane_CellClick);
            // 
            // lblDvorane
            // 
            this.lblDvorane.AutoSize = true;
            this.lblDvorane.Location = new System.Drawing.Point(9, 80);
            this.lblDvorane.Name = "lblDvorane";
            this.lblDvorane.Size = new System.Drawing.Size(71, 13);
            this.lblDvorane.TabIndex = 5;
            this.lblDvorane.Text = "Sve dvorane:";
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(58, 33);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(33, 13);
            this.userRole.TabIndex = 18;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(13, 33);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(38, 13);
            this.uloga.TabIndex = 17;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(112, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(74, 13);
            this.userName.TabIndex = 16;
            this.userName.Text = "korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prijavljeni ste kao:";
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(730, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(39, 13);
            this.Odjava.TabIndex = 14;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // FrmAdminDvorane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 440);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.lblDvorane);
            this.Controls.Add(this.dgvSveDvorane);
            this.Controls.Add(this.btnDvoraneOsvjezi);
            this.Controls.Add(this.btnDvoraneDodaj);
            this.Controls.Add(this.btnDvoraneAzuriraj);
            this.Controls.Add(this.btnDvoranePovratak);
            this.Name = "FrmAdminDvorane";
            this.Text = "Administrator Dvorane";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminDvorane_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdminDvorane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveDvorane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDvoranePovratak;
        private System.Windows.Forms.Button btnDvoraneAzuriraj;
        private System.Windows.Forms.Button btnDvoraneDodaj;
        private System.Windows.Forms.Button btnDvoraneOsvjezi;
        private System.Windows.Forms.DataGridView dgvSveDvorane;
        private System.Windows.Forms.Label lblDvorane;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Odjava;
    }
}