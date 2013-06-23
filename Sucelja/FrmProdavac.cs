using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_projekt.Artikli;
using PI_projekt.Ulaznica;

namespace PI_projekt.Sucelja
{
    public partial class FrmProdavac : Form
    {
        public FrmProdavac()
        {
            InitializeComponent();
            ssUsername.Text = Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
        }
        
        private void miOpcijeOdjava_MouseUp(object sender, MouseEventArgs e)
        {
            FrmPocetna pocetna = new FrmPocetna();
            this.Close();
            pocetna.Show();            
        }

        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void miSifarniciUlaznica_MouseUp(object sender, MouseEventArgs e)
        {
            Ulaznica.FrmUlaznica Odabir = new Ulaznica.FrmUlaznica();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog();
        }

        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Artikli.FrmArtikli Odabir = new Artikli.FrmArtikli();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog();
        } 
    }
}
