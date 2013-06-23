using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Zaposlenici
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje zaposlenika.
        /// </summary>
        public Zaposlenici()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Zaposlenike.</param>
        public Zaposlenici(DbDataReader dr)
        {
            if (dr != null)
            {
                OIB = long.Parse(dr["OIB"].ToString());
                Ime = dr["ime"].ToString();
                Prezime = dr["prezime"].ToString();
                Adresa = dr["adresa"].ToString();
                Kontakt = dr["kontakt"].ToString();
                Email = dr["email"].ToString();
                KorIme = dr["kor_ime"].ToString();
                Lozinka = dr["lozinka"].ToString();
                Uloga = int.Parse(dr["uloga"].ToString());
            }

        }

        #endregion

        #region Private Fields

        private long oib;
        private string ime;
        private string prezime;
        private string adresa;
        private string kontakt;
        private string email;
        private string kor_ime;
        private string lozinka;
        private int uloga;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator zaposlenika.
        /// </summary>
        public long OIB
        {
            get
            {
                return oib;
            }
          set
            {
                if (oib != value)
                {
                    oib = value;
                }
            }
        }

        /// <summary>
        /// Ime zaposlenika.
        /// </summary>
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (ime != value)
                {
                    ime = value;
                }
            }
        }

        /// <summary>
        /// Prezime zaposlenika.
        /// </summary>
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (prezime != value)
                {
                    prezime = value;
                }
            }
        }

        /// <summary>
        /// Adresa zaposlenika.
        /// </summary>
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                if (adresa != value)
                {
                    adresa = value;
                }
            }
        }

        /// <summary>
        /// Kontakt zaposlenika.
        /// </summary>
        public string Kontakt
        {
            get
            {
                return kontakt;
            }
            set
            {
                if (kontakt != value)
                {
                    kontakt = value;
                }
            }
        }

        /// <summary>
        /// Email zaposlenika.
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
                }
            }
        }

        /// <summary>
        /// Korisničko ime zaposlenika.
        /// </summary>
        public string KorIme
        {
            get
            {
                return kor_ime;
            }
            set
            {
                if (kor_ime != value)
                {
                    kor_ime = value;
                }
            }
        }

        /// <summary>
        ///Lozinka zaposlenika.
        /// </summary>
        public string Lozinka
        {
            get
            {
                return lozinka;
            }
            set
            {
                if (lozinka != value)
                {
                    lozinka = value;
                }
            }
        }

        /// <summary>
        ///uloga zaposlenika.
        /// </summary>
        public int Uloga
        {
            get
            {
                return uloga;
            }
            set
            {
                if (uloga != value)
                {
                    uloga = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista zaposlenika.</returns>
        public static List<Zaposlenici> DohvatiZaposlenike()
        {
            List<Zaposlenici> lista = new List<Zaposlenici>();
            string sqlUpit = "SELECT * FROM Zaposlenik";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zaposlenici zaposlenik = new Zaposlenici(dr);
                lista.Add(zaposlenik);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

         public static Zaposlenici DohvatiZaposlenika2(string korIme)
        {
            Zaposlenici zaposlenik = new Zaposlenici();
            string sqlUpit = "SELECT * FROM Zaposlenik WHERE kor_ime='" + korIme + "';";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                zaposlenik = new Zaposlenici(dr);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return zaposlenik;
        }

        public static Zaposlenici DohvatiZaposlenika(long oib)
        {
            Zaposlenici zaposlenik = new Zaposlenici();
            string sqlUpit = "SELECT * FROM Zaposlenik WHERE oib='" + oib + "';";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                zaposlenik = new Zaposlenici(dr);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return zaposlenik;
        }

        /// <summary>
        /// Dodaje novog zaposlenika u bazu podataka
        /// </summary>
        /// <param name="noviZaposlenik">Objekt klase Zaposlenici s podacima</param>
        /// <returns>Vraća broj zahvaćeni redova, int</returns>
        public static int DodajZaposlenika(Zaposlenici noviZaposlenik)
        {

            string sqlUpit = "INSERT INTO Zaposlenik ('OIB', 'ime', 'prezime', 'adresa', 'kontakt', 'email', 'kor_ime', 'lozinka', 'uloga') VALUES ('" + noviZaposlenik.OIB + "','" + noviZaposlenik.Ime + "', '" + noviZaposlenik.Prezime + "', '"
            + noviZaposlenik.Adresa + "', '" + noviZaposlenik.Kontakt + "', '" + noviZaposlenik.Email + "', '" + noviZaposlenik.KorIme + "', '"
            + noviZaposlenik.Lozinka + "', '" + noviZaposlenik.Uloga + "');";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit);

            return izvrsenUpit;
        }

        /// <summary>
        /// Ažurira zaposlenika u bazi podataka
        /// </summary>
        /// <param name="zaposlenik">Objekt klase Zaposlenici sa novim podacima</param>
        /// <returns>Vraća broj zahvaćeni redova</returns>
        public static int AzurirajZaposlenika(Zaposlenici zaposlenik)
        {
            string sqlUpit = "UPDATE Zaposlenik SET ime='" + zaposlenik.Ime + "', prezime='" + zaposlenik.Prezime + "', adresa= '"
            + zaposlenik.Adresa + "', kontakt='" + zaposlenik.Kontakt + "', email='" + zaposlenik.Email + "', kor_ime='" + zaposlenik.KorIme + "', lozinka='"
            + zaposlenik.Lozinka + "', uloga='" + zaposlenik.Uloga + "' WHERE OIB=" + zaposlenik.OIB + ";";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit);
            return izvrsenUpit;
            
        }

        #endregion
    }
}
