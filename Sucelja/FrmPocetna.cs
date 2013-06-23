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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private bool pomOdjava = false;

       private void Prijava_Click(object sender, EventArgs e)
        {
            bool kor_ime = false;
            List<Zaposlenici> listaKorisnika = Zaposlenici.DohvatiZaposlenike();
            foreach (Zaposlenici zaposlenik in listaKorisnika)
            {
                if (KorIme.Text == zaposlenik.KorIme)
                {
                    kor_ime = true;
                    SpremnikPodataka.Zaposlenik = KorIme.Text;
                    if (Pass.Text == zaposlenik.Lozinka)
                    {
                        if (zaposlenik.Uloga == 2)
                        {
                            SpremnikPodataka.Uloga = "administrator";
                            FrmAdmin admin = new FrmAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        else if (zaposlenik.Uloga == 1)
                        {
                            SpremnikPodataka.Uloga = "prodavač";
                            FrmProdavac prodavac = new FrmProdavac();
                            prodavac.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        string message_2 = "Unijeli ste neispravnu lozinku.";
                        string caption_2 = "Greška!";
                        DialogResult result_2;

                        // Displays the MessageBox.
                        result_2 = MessageBox.Show(this, message_2, caption_2);
                    }
                }
            }
            if (!kor_ime)
            {
                string message_1 = "Unijeli ste nepostojeće korisničko ime.";
                string caption_1 = "Greška!";
                DialogResult result_1;

                // Displays the MessageBox.
                result_1 = MessageBox.Show(this, message_1, caption_1);
            }
        }

       private void KorIme_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               Prijava_Click(sender, e);
           }
       }

       private void Pass_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               Prijava_Click(sender, e);
           }
       }

        public static class SpremnikPodataka
        {
            public static String Zaposlenik;
            public static String Uloga;
        }

        
        private void Ponisti_Click(object sender, EventArgs e)
        {
            KorIme.Clear();
            Pass.Clear();
        }

        /// <summary>
        ///funkcija za izlaz iz aplikacije 
        /// </summary>
        int izlaz = 0;
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            izlaz = 1;
            izlazak();
        }
        private void izlazak()
        {
            if (izlaz == 1)
            {
                string message = "Želite li ugasiti aplikaciju?";
                string caption = "Gašenje aplikacije";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                  Application.Exit();
                }
            }
        }  
      
         private void FrmPocetna_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava) {
                Application.Exit();
            }
        }
    }
}
