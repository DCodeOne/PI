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
        /// Dohvaća sve žanrove za određeni film i vraća ih u obliku liste
        /// </summary>
        /// <returns>Lista žanrova za određeni film</returns>
        public static List<Zanrovi> DohvatiZanrove(int idFilma)
        {
            List<Zanrovi> lista = new List<Zanrovi>();
            string sqlUpit = "SELECT zanr.* FROM zanr LEFT JOIN film_zanr ON zanr.id_zanra=film_zanr.id_zanra WHERE film_zanr.id_filma="+ idFilma+";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zanrovi zanr = new Zanrovi(dr);
                lista.Add(zanr);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }


        /// <summary>
        /// Unosi sve žanrove za određeni film u tablicu film_zanr
        /// </summary>
        /// <param name="idFilma">Id filma za kojeg se uose žanrovi</param>
        /// <param name="listaZanrova">Lista objekata Zanrovi koja sadrži sve žanrove za film</param>
        /// <returns>Broj zahvaćenih redova</returns>
        public static int UnesiZanrove(int idFilma, List<Zanrovi> listaZanrova)
        {
            int brojUmetanja=0;
            foreach (Zanrovi zanr in listaZanrova)
            {
                string sqlUpit = "INSERT INTO film_zanr ('id_zanra','id_filma') VALUES ('" + zanr.IdZanra + "','" + idFilma + "');";
                brojUmetanja += DB.Instance.IzvrsiUpit(sqlUpit);
            }
            
            return brojUmetanja;
        
        }

        
        #endregion
    }


}

    