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

       /// <summary>
       /// Event koji aktivira provjeru zaposlenika pritiskom na tipku Prijava
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void Prijava_Click(object sender, EventArgs e)
        {
                int provjeraZaposlenika= Kino.ProvjeriKorisnika( KorIme.Text, Pass.Text);
                SpremnikPodataka.Zaposlenik = KorIme.Text;

                    if (provjeraZaposlenika==2)
                    {     
                            SpremnikPodataka.Uloga = "administrator";
                            FrmAdmin admin = new FrmAdmin();
                            admin.Show();
                            this.Hide();
                        
                    }
                    else if(provjeraZaposlenika == 1)
                    {
                            SpremnikPodataka.Uloga = "prodavač";
                            FrmProdavac prodavac = new FrmProdavac();
                            prodavac.Show();
                            this.Hide();
                        
                    }
                    else if(provjeraZaposlenika == -2)
                    {
                        string message_2 = "Unijeli ste neispravnu lozinku.";
                        string caption_2 = "Greška!";
                        DialogResult result_2;
                        KorIme.Text = "";
                        Pass.Text = "";

                        //Prikaz poruke o odjavi (Message Box)
                        result_2 = MessageBox.Show(this, message_2, caption_2);
                    }
                    else if (provjeraZaposlenika==-1)
                    {
                        string message_1 = "Unijeli ste nepostojeće korisničko ime.";
                        string caption_1 = "Greška!";
                        DialogResult result_1;
                        KorIme.Text = "";
                        Pass.Text = "";
                        // Displays the MessageBox.
                        result_1 = MessageBox.Show(this, message_1, caption_1);
                    }
        }

       /// <summary>
       /// Pritiskom na Enter, Event koji aktivira provjeru zaposlenika pritiskom na tipku Prijava
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void KorIme_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               Prijava_Click(sender, e);
           }
       }
        /// <summary>
        /// Pritiskom na Enter, Event koji aktivira provjeru zaposlenika pritiskom na tipku Prijava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        
        /// <summary>
        /// Event koji poništava unesene vrijednosti (korisničko ime i lozinku) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ponisti_Click(object sender, EventArgs e)
        {
            KorIme.Clear();
            Pass.Clear();
        }

        
        int izlaz = 0;

        /// <summary>
        /// Event koji zatvara otvorenu formu kada korisnik klikne na tipku Izlaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            izlaz = 1;
            izlazak();
        }

        /// <summary>
        /// Metoda koja služi za izlaz iz aplikacije
        /// </summary>
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
      
        /// <summary>
        /// Metoda za zatvaranje trenutno otvorene forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void FrmPocetna_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava) {
                Application.Exit();
            }
        }

        /// <summary>
        /// Metoda koja učitava početnu formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
 
        private void FrmPocetna_Load(object sender, EventArgs e)
         {
             this.ActiveControl = KorIme;
         }
    }
}
