namespace PI_projekt.Ulaznica
{
    partial class ulaznica
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
            this.potvrda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // potvrda
            // 
            this.potvrda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.potvrda.Location = new System.Drawing.Point(299, 260);
            this.potvrda.Name = "potvrda";
            this.potvrda.Size = new System.Drawing.Size(75, 23);
            this.potvrda.TabIndex = 0;
            this.potvrda.Text = "OK";
            this.potvrda.UseVisualStyleBackColor = true;
            // 
            // ulaznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 331);
            this.Controls.Add(this.potvrda);
            this.Name = "ulaznica";
            this.Text = "Ulaznica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button potvrda;
    }
}