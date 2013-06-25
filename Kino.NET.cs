using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt
{
    /// <summary>
    /// Klasa za rad s različitim podacima
    /// </summary>
    public class Kino
    {
        /// <summary>
        /// Pretvara zapis cijene iz floata u float oblik sa točkom potreban za unos u SQLite bazu podataka
        /// </summary>
        /// <param name="cijenaFloat">Float zapis sa ,</param>
        /// <returns>String sa .</returns>
        public static string PretvoriCijenu(float cijenaFloat)
        {
            string cijenaString = cijenaFloat.ToString();
            if (cijenaString.Contains(","))
                cijenaString = cijenaString.Replace(",", ".");
            return cijenaString;
        }


        /// <summary>
        /// Sprema kupljene ulaznice u bazu podataka, ispisuje ulaznicu u obliku pdf-a
        /// </summary>
        /// <param name="odabranaSjedala">Lista odabranih sjedala</param>
        /// <param name="odabranaProjekcija">Objekt odabrana projekcija</param>
        /// <returns>Vraća listu ID-a unešenih ulaznica</returns>
        public static List<int> IzradiUlaznicu(List<int> odabranaSjedala, Projekcija odabranaProjekcija)
        {
            List<int> listaIdUlaznica = new List<int>();


            foreach (int sjedalo in odabranaSjedala)
            {
                listaIdUlaznica.Add(Ulaznice.UnesiUlaznicu(sjedalo, odabranaProjekcija.IdProjekcije));
            }

            return listaIdUlaznica;
        }

        /// <summary>
        /// Sprema račun u bazu podataka i ispisuje ga u obliku pdf-a
        /// </summary>
        /// <param name="OIB">OIB zaposlenika koji je izdao račun</param>
        /// <param name="idNacinaPlacanja">Gotovina ili kartica</param>
        /// <param name="listaArtikala">lista odabranih artikala (stavke računa)</param>
        /// <param name="listaKolicina">količina stavki</param>
        /// <param name="listaIdUlaznica">ID ulaznica</param>
        /// <param name="popust">popust (bez popusta, studenti, umirovljenici, moj ponedjeljak)</param>
        /// <param name="ukupnaCijenaUlaznica">Ukupna suma cijena odabranih artikala</param>
        /// <param name="ukupnaCijenaArtikala">Ukupna suma cijena odabranih ulaznica</param>
        public static void KreirajRacun(long OIB, int idNacinaPlacanja, List<Artikl> listaArtikala, List<int> listaKolicina, List<int> listaIdUlaznica, Popust popust, float ukupnaCijenaUlaznica, float ukupnaCijenaArtikala)
        {
            int IdRacun = Racun.UnesiRacun(OIB, idNacinaPlacanja);
            if (listaArtikala != null)
            {
                int brojElemenata = listaArtikala.Count;
                for (int i = 0; i < brojElemenata; i++)
                {
                    RacunArtikl.UnesiRacunArtikl(IdRacun, listaArtikala[i].IdArtikla, listaKolicina[i]);
                }
            }
            if (listaIdUlaznica != null)
            {
                foreach (int ID in listaIdUlaznica)
                {
                    RacunUlaznica.UnesiRacunUlaznica(IdRacun, ID, popust.IdPopusta);
                }

                //Poziva se report viewer UlaznicaIspis.cs za svaku kupljenu ulaznicu
                foreach (int idUlaznice in listaIdUlaznica)
                {
                    Izvjestaj.UlaznicaIspis ispisUlaznice = new Izvjestaj.UlaznicaIspis(idUlaznice);
                    ispisUlaznice.Show();
                }
            }
            ///Izvještaj - račun
            Izvjestaj.RacunIzvjestaj racun = new Izvjestaj.RacunIzvjestaj(IdRacun, ukupnaCijenaUlaznica, ukupnaCijenaArtikala);
            racun.Show();
        }

        /// <summary>
        /// Metoda koja kao parametar prima datum i vraća ga kao string u formatu potrebnom za upis Sqlite bp
        /// </summary>
        /// <param name="stariDatum"></param>
        /// <returns>Novi datum</returns>
        public static string PretvoriDatum(DateTime stariDatum)
        {
            string noviDatum = "";
            noviDatum = stariDatum.ToString("yyyy-MM-dd HH:mm:ss");
            return noviDatum;
        }


        /// <summary>
        /// Metoda koja za parametre prima količinu, cijenu i popust i računa ukupnu cijenu sa popustom
        /// </summary>
        /// <param name="kolicina">Količina proizvoda</param>
        /// <param name="cijena">Cijena proizvoda</param>
        /// <param name="popust">popust na proizvod</param>
        /// <returns>Lista sa [0] sumom, [1] postotkom, [2] ukupnom cijenom. Ukoliko unos nije valjan vraća listu sa vrijednostima -1</returns>
        public static List<decimal> IzracunajPopust(int kolicina, float cijena, float popust)
        {
            List<decimal> listaPopust = new List<decimal>();

            //U slučaju da je količina manja od 1, cijena manja od 0 i popust manji od 0 metoda vraća lista sa elementima -1
            if (kolicina < 1 || cijena <= 0 || popust < 0)
            {
                listaPopust.Add(-1);
                listaPopust.Add(-1);
                listaPopust.Add(-1);

                return listaPopust;
            }

            decimal suma = (decimal)(kolicina * cijena);
            decimal popustPostotak = (decimal)(popust * 100);
            decimal ukupno = (suma - (suma * (decimal)popust));

            Decimal.Round(suma, 2);
            Decimal.Round(popustPostotak, 2);
            Decimal.Round(ukupno, 2);

            listaPopust.Add(suma);
            listaPopust.Add(popustPostotak);
            listaPopust.Add(ukupno);

            return listaPopust;
        }

        /// <summary>
        /// Metoda koja provjerava jel korisnik sa korisničkim imenom i lozinkom postoji u bazi podataka 
        /// </summary>
        /// <param name="korisnickoIme">Korisničko ime</param>
        /// <param name="lozinka">Lozinka</param>
        /// <returns>IdUloge ako postoji korisnik sa korisničkim imenom i lozinkom, -1 ako ne postoji zaposlenik sa korisničkim imenom,-2 ako postoji korisnik, ali lozinka nije valjana</returns>
        public static int ProvjeriKorisnika(string korisnickoIme, string lozinka)
        {
            DateTime sada = new DateTime();
            List<Zaposlenici> listaKorisnika = Zaposlenici.DohvatiZaposlenike();

            foreach (Zaposlenici zaposlenik in listaKorisnika)
            {
                if (korisnickoIme == zaposlenik.KorIme)
                {
                    if (lozinka == zaposlenik.Lozinka)
                    {
                        //postoji zaposlenik sa tim korisnickim imenom i lozinkom
                        return zaposlenik.Uloga;
                    }
                    else
                    {   //postoji zaposlenik sa tim korisničkim imenom, ali lozinka nije valjana
                        return -2;
                    }
                }
            }
            //ne postoji zaposlenik sa tim korisničkim imenom
            return -1;
        }
    }
}
