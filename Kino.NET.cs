using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Kino
    {
        public static string PretvoriCijenu(float cijenaFloat)
        {
            string cijenaString = cijenaFloat.ToString();
            if (cijenaString.Contains(","))
                cijenaString = cijenaString.Replace(",", ".");
            return cijenaString;
        }
    }
}
