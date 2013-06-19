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
    public partial class FrmAdminDvorane : Form
    {
        //objekt klase artikl u kojeg se sprema artikl za uredivanje
        Dvorana detaljiDvorana = null;
        int BrojDvorane = -1;

        /// <summary>
        /// Metoda koja osvježava popis dvorana u dgvSveDvorane objektu
        /// </summary>
        private void OsvjeziDvorane()
        {
            List<Dvorana> listaDvorana = Dvorana.DohvatiDvorane();
            dgvSveDvorane.DataSource = listaDvorana;
        }

        public FrmAdminDvorane()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }

        private bool pomOdjava = false;

        private void FrmAdminDvorane_Load(object sender, EventArgs e)
        {
            OsvjeziDvorane();
        }

        private void btnDvoraneOsvjezi_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            OsvjeziDvorane();
        }

        /// <summary>
        /// Prilikom klika na odredenu celiju dohvaca se id pojedine dvorane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSveDvorane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pomOdjava = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSveDvorane.Rows[e.RowIndex];
                //postavljamo broj dvorane artikla u varijablu BrojDvorane
                BrojDvorane = int.Parse(red.Cells["BrojDvorane"].Value.ToString());
            }
        }

        private void btnDvoranePovratak_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Close();
        }

        /// <summary>
        /// Klikom na gumb dodaj otvara se forma za dodavanje nove dvorane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvoraneDodaj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminDvoraneDodaj formaDodaj = new FrmAdminDvoraneDodaj();
            formaDodaj.Show();
            this.Close(); ;
        }

        /// <summary>
        /// Na klik ažuriraj provjerava je li odabrana dvorana u cbSveDvorane i ako je odabrana poziva formu za dodavanje/ažuriranje dvorana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvoraneAzuriraj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            //ako je odabrana dvorana u dgvSveDvorane
            if (BrojDvorane > -1)
            {
                detaljiDvorana = Dvorana.DohvatiDvoranu(BrojDvorane);
                FrmAdminDvoraneDodaj formaAzuriraj = new FrmAdminDvoraneDodaj(detaljiDvorana);
                formaAzuriraj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Molimo vas odaberite dvoranu!");
            }
        }

        /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeduje funkciji koja ce ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slucaju klika na yes, korisnik se odjavljuje i vraca na pocetnu stranicu (login)
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
        private void FrmAdminDvorane_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdmin admin = new FrmAdmin();
                admin.Show();
            }
        }
    }
}
