using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca
{
    public class VariaveisGlobais
    {
        public static string CAMINHO_EXECUTAVEL = Environment.CurrentDirectory;

        public static string CAMINHO_PUBLIC;
        
        public static string AplicaReplace(string completa ,string old, string atual)
        {
            return completa.Replace(old, atual);
        }
    }
}
