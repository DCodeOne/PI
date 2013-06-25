using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    /// <summary>
    /// Klasa za rad s načinima plaćanja
    /// </summary>
    class NaciniPlacanja
    {

        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje načina placanja
        /// </summary>
        public NaciniPlacanja()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za način plaćanja.</param>
        public NaciniPlacanja(DbDataReader dr)
        {
            if (dr != null)
            {
                IdNacinaPlacanja = int.Parse(dr["id_nacina_placanja"].ToString());
                Naziv = dr["naziv"].ToString();

            }

        }

        #endregion

        #region Private Fields

        private int id_nacina_placanja;
        private string naziv;


        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator načina plaćanja
        /// </summary>
        public int IdNacinaPlacanja
        {
            get
            {
                return id_nacina_placanja;
            }
            private set
            {
                if (id_nacina_placanja != value)
                {
                    id_nacina_placanja = value;
                }
            }
        }

       
        /// <summary>
        /// Naziv načina plaćanja
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


        #endregion

        #region Methods

        /// <summary>
        /// Metoda koja dohvaća sve načine plaćanja 
        /// </summary>
        /// <returns>Lista načina plaćanja</returns>
        public static List<NaciniPlacanja> DohvatiNacinePlacanja()
        {
            List<NaciniPlacanja> lista = new List<NaciniPlacanja>();
            string sqlUpit = "SELECT * FROM Nacin_Placanja";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                NaciniPlacanja nacin_placanja = new NaciniPlacanja(dr);
                lista.Add(nacin_placanja);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        #endregion
    }
}
