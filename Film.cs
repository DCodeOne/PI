using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
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
            }

        }

        #endregion

        #region Private Fields

        private int vrijeme_trajanja;
        private int id_filma;
        private string naziv;
        
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
            private set
            {
                if (id_filma != value)
                {
                    id_filma = value;
                }
            }
        }

        /// <summary>
        /// trajanja filma u minutama
        /// </summary>
        public int VrijemeTrajanja
        {
            get
            {
                return vrijeme_trajanja;
            }
            private set
            {
                if (vrijeme_trajanja != value)
                {
                    vrijeme_trajanja = value;
                }
            }
        }
        public string Naziv
        {
            get
            {
                return naziv;
            }
            private set
            {
                if (naziv != value)
                {
                    naziv = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća sve filmove
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
        /// Dohvaća listu filmova koji imaju aktualne projekcije
        /// </summary>
        /// <returns>Broj zahvaćenih redova</returns>
        public static List<Film> DohvatiAktualneFilmove()
        {
            List<Film> lista = new List<Film>();
            DateTime sada = DateTime.Now;
            sada.AddMinutes(15);

            string sqlUpit = "SELECT DISTINCT Film.* FROM Projekcija LEFT JOIN Film ON Projekcija.id_filma=Film.Id_filma WHERE projekcija.datum=" + sada.ToString() + ";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Film film = new Film(dr);
                lista.Add(film);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        
        }

        
        #endregion
    }


}

    