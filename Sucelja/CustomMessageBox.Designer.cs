namespace PI_projekt.Sucelja
{
    partial class CustomMessageBox
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
            this.btnUredu = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(72, 116);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(122, 30);
            this.btnUredu.TabIndex = 3;
            this.btnUredu.Text = "Uredu!";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click_1);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(17, 19);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(11, 17);
            this.lblPoruka.TabIndex = 2;
            this.lblPoruka.Text = "!";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(104, 96);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 17);
            this.lblTimer.TabIndex = 4;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 160);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.lblPoruka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CustomMessageBox";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUredu;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Label lblTimer;
    }
}