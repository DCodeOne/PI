using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Sucelja
{
    public partial class FrmAdminProjekcije : Form
    {
        public FrmAdminProjekcije()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }

        private bool pomOdjava = false;

        private void btnProjekcijePovratak_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Close();
        }

        private void btnProjekcijeDodaj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminProjekcijeDodaj formaDodaj = new FrmAdminProjekcijeDodaj();
            formaDodaj.Show();
            this.Close(); ;
        }

        /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
        /// </summary>
        int odjavljivanje = 0;
        private void Odjava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            odjavljivanje = 1;
            odjava();
        }
        private void odjava()
        {
            if (odjavljivanje == 1)
            {
                string message = "Želite li se odjaviti iz sustava?";
                string caption = "Odjava iz sustava";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    pomOdjava = true;
                    PI_projekt.Sucelja.FrmPocetna pocetna = new PI_projekt.Sucelja.FrmPocetna();
                    pocetna.Show();
                    this.Close();
                }
            }
        }
        private void FrmAdminProjekcije_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdmin admin = new FrmAdmin();
                admin.Show();
            }

        }
    }
}