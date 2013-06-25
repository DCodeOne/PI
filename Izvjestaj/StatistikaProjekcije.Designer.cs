namespace PI_projekt.Izvjestaj
{
    partial class StatistikaProjekcije
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistikaProjekcije));
            this.projekcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDBDataSet = new PI_projekt.KinoDBDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.projekcijaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ProjekcijaTableAdapter();
            this.filmTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.FilmTableAdapter();
            this.lblOdaberiFilm = new System.Windows.Forms.Label();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projekcijaBindingSource
            // 
            this.projekcijaBindingSource.DataMember = "Projekcija";
            this.projekcijaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // kinoDBDataSet
            // 
            this.kinoDBDataSet.DataSetName = "KinoDBDataSet";
            this.kinoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "Projekcija";
            reportDataSource1.Value = this.projekcijaBindingSource;
            reportDataSource2.Name = "Film";
            reportDataSource2.Value = this.filmBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_projekt.Izvjestaj.rptProjekcije.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(694, 353);
            this.reportViewer1.TabIndex = 0;
            // 
            // projekcijaTableAdapter
            // 
            this.projekcijaTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // lblOdaberiFilm
            // 
            this.lblOdaberiFilm.AutoSize = true;
            this.lblOdaberiFilm.Location = new System.Drawing.Point(12, 11);
            this.lblOdaberiFilm.Name = "lblOdaberiFilm";
            this.lblOdaberiFilm.Size = new System.Drawing.Size(74, 13);
            this.lblOdaberiFilm.TabIndex = 1;
            this.lblOdaberiFilm.Text = "Odaberite film:";
            // 
            // cbFilm
            // 
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(92, 6);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(198, 21);
            this.cbFilm.TabIndex = 2;
            this.cbFilm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StatistikaProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 386);
            this.Controls.Add(this.cbFilm);
            this.Controls.Add(this.lblOdaberiFilm);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatistikaProjekcije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika projekcije";
            this.Load += new System.EventHandler(this.StatistikaProjekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource projekcijaBindingSource;
        private KinoDBDataSet kinoDBDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private KinoDBDataSetTableAdapters.ProjekcijaTableAdapter projekcijaTableAdapter;
        private KinoDBDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.Label lblOdaberiFilm;
        private System.Windows.Forms.ComboBox cbFilm;
    }
}