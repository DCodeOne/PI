using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class FilmZanrovi
    {

        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje žanra za film
        /// </summary>
        public FilmZanrovi()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za film-Zanr.</param>
        public FilmZanrovi(DbDataReader dr)
        {
            if (dr != null)
            {
                IdZanra = int.Parse(dr["id_zanra"].ToString());
                IdFilma = int.Parse(dr["id_filma"].ToString());

            }

        }

        #endregion

        #region Private Fields

        private int id_zanra;
        private int id_filma;


        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator žanra
        /// </summary>
        public int IdZanra
        {
            get
            {
                return id_zanra;
            }
            private set
            {
                if (id_zanra != value)
                {
                    id_zanra = value;
                }
            }
        }

        /// <summary>
        /// Jedinstveni identifikator filma
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
        public static int UnesiZanrove(int idFilma, List<int> listaZanrova)
        {
            int brojUmetanja=0;
            foreach (int zanr in listaZanrova)
            {
                string sqlUpit = "INSERT INTO film_zanr ('id_zanra','id_filma') VALUES ('" + zanr.ToString() + "','" + idFilma + "');";
                brojUmetanja += DB.Instance.IzvrsiUpit(sqlUpit);
            }
            
            return brojUmetanja;
        
        }

        public static int AzurirajZanrove(int idFilma, List<int> idZanrova)
        {
            int zahvaceno = 0;
            //obrišemo sve vrsteProjekcije za određenu projekciju
            string sqlUpit1 = "DELETE FROM film_zanr WHERE id_filma=" + idFilma + ";";
            DB.Instance.IzvrsiUpit(sqlUpit1);

            //dodajemo Ažuriranje vrste projekcija za projekciju
            foreach (int idZanra in idZanrova)
            {
                string sqlUpit = "INSERT INTO film_zanr ('id_filma','id_zanra') VALUES ('"
                + idFilma + "','" + idZanra + "');";
                zahvaceno += DB.Instance.IzvrsiUpit(sqlUpit);
            }
            return zahvaceno;
        }

        
        #endregion
    }


}
