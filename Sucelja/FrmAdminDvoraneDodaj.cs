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
    public partial class FrmAdminDvoraneDodaj : Form
    {
        private Dvorana dvoranaAzuriraj = null;

        /// <summary>
        /// Konstruktor koji se poziva u slućaju dodavanja nove dvorane
        /// </summary>
        public FrmAdminDvoraneDodaj()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojeće dvorane
        /// </summary>
        /// <param name="odabraniArtikl"></param>
        public FrmAdminDvoraneDodaj(Dvorana odabranaDvorana)
        {
            InitializeComponent();
            dvoranaAzuriraj = odabranaDvorana;
        }

        /// <summary>
        /// Rukuje dogadajem pokretanja forme, ukoliko se radi o ažuriranju dvorane tada formu popunjava sa postojecim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminDvoraneDodaj_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtDodajDvoranuNaziv;
            if (dvoranaAzuriraj != null)
            {
                txtDodajDvoranuNaziv.Text = dvoranaAzuriraj.Naziv.ToString();
                txtDodajDvoranuBrSjedala.Text = dvoranaAzuriraj.BrojSjedala.ToString();
            }
        }

        /// <summary>
        /// Gumb Odustani zatvara formu bez da doda dvoranu u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Gumb Spremi dodaje zapis u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Dvorana novaDvorana = new Dvorana();
            novaDvorana.Naziv = txtDodajDvoranuNaziv.Text.ToString();
            if (novaDvorana.Naziv == "")
            {
                MessageBox.Show("Greška! Pogrešan unos podataka.");
            }
            else
            {
                try
                {
                    novaDvorana.BrojSjedala = int.Parse(txtDodajDvoranuBrSjedala.Text.ToString());
                    if (dvoranaAzuriraj != null)
                    {
                        novaDvorana.BrojDvorane = dvoranaAzuriraj.BrojDvorane;
                        Dvorana.AzurirajDvoranu(novaDvorana);
                    }
                    else
                    {
                        Dvorana.DodajDvoranu(novaDvorana);
                    }
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Greška! Pogrešan unos podataka.");
                }
            }
        }
    }
}
