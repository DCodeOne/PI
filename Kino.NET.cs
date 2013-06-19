using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Kino
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
        /// Sprema kupljene ulaznice u bazu podataka, ispisuje ulaznicu u obliku pdf.a
        /// </summary>
        /// <param name="odabranaSjedala">Lista odabranih sjedala</param>
        /// <param name="odabranaProjekcija">Objekt odabrana projekcija</param>
        /// <returns>Vraća listu ID-a unešenih ulaznica</returns>
        public static List<int> IzradiUlaznicu(List<int> odabranaSjedala, Projekcija odabranaProjekcija)
        {
            List<int> listaIdUlaznica = new List<int>();
            int idUlaznice = 0;

            foreach (int sjedalo in odabranaSjedala)
            {   
                listaIdUlaznica.Add(Ulaznice.UnesiUlaznicu(sjedalo, odabranaProjekcija.IdProjekcije));
            }

            return listaIdUlaznica;
        }


    }
}
