using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtension
    {

        public static string FirstToUpper(this String str)
        {
            string primeiraLetra = str.Substring(0,1);

            string segundaLetra = str.Substring(1);
            return primeiraLetra.ToUpper() + segundaLetra;
        }

    }
}
