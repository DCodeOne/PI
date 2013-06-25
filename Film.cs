using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    /// <summary>
    /// Klasa za rad s filmovima
    /// </summary>
    class Film
    {
       #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje  filma
        /// </summary>
        public Film()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za film-Zanr.</param>
        public Film(DbDataReader dr)
        {
            if (dr != null)
            {
                IdFilma= int.Parse(dr["id_filma"].ToString());
                Naziv = dr["naziv"].ToString();
                VrijemeTrajanja = int.Parse(dr["vrijeme_trajanja"].ToString());
                Redatelj = dr["redatelj"].ToString();
                Godina = int.Parse(dr["godina"].ToString());
                Glumci = dr["glumci"].ToString();
                Sinopsis = dr["sinopsis"].ToString();
            }

        }

        #endregion

        #region Private Fields

        private int vrijeme_trajanja;
        private int id_filma;
        private string naziv;
        private string redatelj;
        private int godina;
        private string glumci;
        private string sinopsis;
        
        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator žanra
        /// </summary>
        public int IdFilma
        {
            get
            {
                return id_filma;
            }
            set
            {
                if (id_filma != value)
                {
                    id_filma = value;
                }
            }
        }

        /// <summary>
        /// Trajanja filma u minutama
        /// </summary>
        public int VrijemeTrajanja
        {
            get
            {
                return vrijeme_trajanja;
            }
            set
            {
                if (vrijeme_trajanja != value)
                {
                    vrijeme_trajanja = value;
                }
            }
        }

        /// <summary>
        /// Naziv filma
        /// </summary>
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                if (naziv != value)
                {
                    naziv = value;
                }
            }
        }

        /// <summary>
        /// Redatelj filma
        /// </summary>
        public string Redatelj {
            get {
                return redatelj;
            }
            set {
                if (redatelj != value) {
                    redatelj = value;
                }
            }
        }

        /// <summary>
        /// Godina kad je film izdan
        /// </summary>
        public int Godina {
            get {
                return godina;
            }
            set {
                if (godina != value) {
                    godina = value;
                }
            }
        }

        /// <summary>
        /// Glavni glumci
        /// </summary>
        public string Glumci {
            get {
                return glumci;
            }
            set {
                if (glumci != value) {
                    glumci = value;
                }
            }
        }

        /// <summary>
        /// Sinopsis
        /// </summary>
        public string Sinopsis
        {
            get
            {
                return sinopsis;
            }
            set
            {
                if (sinopsis != value)
                {
                    sinopsis = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Metoda koja dohvaća sve filmove iz baze i vrća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista filmova</returns>
        public static List<Film> DohvatiFilmove()
        {
            List<Film> lista = new List<Film>();
            string sqlUpit = "SELECT * FROM Film";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Film film = new Film(dr);
                lista.Add(film);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }


        /// <summary>
        /// Metoda koja dohvaća listu filmova koji imaju aktualne projekcije
        /// </summary>
        /// <returns>Broj zahvaćenih redova</returns>
        public static List<Film> DohvatiAktualneFilmove()
        {
            List<Film> lista = new List<Film>();
            DateTime sada = DateTime.Now;
            sada.AddMinutes(15);

            string sqlUpit = "SELECT DISTINCT Film.* FROM Projekcija LEFT JOIN Film ON Projekcija.id_filma=Film.Id_filma WHERE projekcija.datum >= '" + sada.ToString("yyyy-MM-dd HH:mm:ss") + "';";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Film film = new Film(dr);
                lista.Add(film);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        
        }

        /// <summary>
        /// Metoda koja dohvaća film prema određenom ID-u
        /// </summary>
        /// <param name="IdFilma"></param>
        /// <returns>Vraća objekt određen ID-om iz baze, ukoliko postoji, a ukoliko ne postoji, vraća null</returns>
        public static Film DohvatiFilm(int IdFilma) {
            Film film = new Film();
            string sqlUpit = "SELECT * FROM Film WHERE id_filma = "+IdFilma+";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read()) {
                film = new Film(dr);
            }
            dr.Close();
            return film;
        }

        /// <summary>
        /// Metoda oja dodaje novi film u bazu
        /// </summary>
        /// <param name="noviFilm">Objekt klase film</param>
        /// <returns>Vraća id dodanog filma</returns>
        public static int DodajFilm(Film noviFilm)
        {

            string sqlUpit = "INSERT INTO Film ('naziv','vrijeme_trajanja', 'redatelj', 'godina', 'glumci', 'sinopsis') VALUES ('"
                            + noviFilm.Naziv + "','" + noviFilm.VrijemeTrajanja + "', '" + noviFilm.Redatelj + "', '" + noviFilm.Godina + "', '" + noviFilm.Glumci + "', '" + noviFilm.Sinopsis + "' );";
            int IdFilma = DB.Instance.IzvrsiUpitID(sqlUpit);
            return IdFilma;
        }

        /// <summary>
        /// Metoda koja ažurira film u bazi podakaka
        /// </summary>
        /// <param name="odabraniFilm">Objekt klase Film</param>
        /// <returns>Broj zahvaćenih redova</returns>
        public static int AzurirajFilm(Film odabraniFilm) {
            string sqlUpit = "UPDATE Film SET naziv = '" + odabraniFilm.Naziv + "', vrijeme_trajanja = '" + odabraniFilm.VrijemeTrajanja + "', redatelj = '" + odabraniFilm.Redatelj + "', godina = '" + odabraniFilm.Godina + "', glumci = '" + odabraniFilm.Glumci + "', sinopsis = '" + odabraniFilm.Sinopsis + "' WHERE id_filma = '"+ odabraniFilm.IdFilma +"';";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit);
            return izvrsenUpit;
        }

        /// <summary>
        /// Metoda koja provjerava jel Film ima upisane projekcije. Ukoliko nema briše sve žanrove i film iz baze podataka.
        /// </summary>
        /// <param name="idFilma">Id Filma</param>
        /// <returns>Broj zahvaćenih redaka, -1 ako nije moguće obrisat film</returns>
        public static int ObrisiFilm(int idFilma)
        {
            Racun racun = new Racun();
            string sqlUpit = "SELECT * FROM Projekcija WHERE id_filma='" + idFilma + "';";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                dr.Close();
                return -1;
            }
            dr.Close();  //Zatvaranje DataReader objekta.

            string sqlUpit2 = "DELETE FROM film_zanr  WHERE id_filma=" + idFilma + ";";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit2);

            string sqlUpit3 = "DELETE FROM Film  WHERE id_filma=" + idFilma + ";";
            izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit3);

            return izvrsenUpit;
        }        
        #endregion
    }
}

    