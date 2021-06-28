using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Lib
{
    public class FotoProcessador
    {
        public delegate void fotoFiltroHandler(Foto foto);

        public static fotoFiltroHandler filtros; 

        public static void Processador(Foto foto)
        {
            filtros(foto);
            /*
            var filtros = new FotoFiltro();
            filtros.Colorir(foto);
            filtros.PretoBranco(foto);
            filtros.GerarThumb(foto);
            filtros.RedimensionarTamanhoMedio(foto);
            */



        }
        
         
    }
}
