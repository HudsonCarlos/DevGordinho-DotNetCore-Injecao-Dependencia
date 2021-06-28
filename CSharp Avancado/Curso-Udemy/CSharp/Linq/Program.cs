using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };
            List<int> l = new List<int> { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            var listaFiltrada01 = lista.Where(x => x > 10).OrderBy(a => a).Select(a => a);
            var listaFiltrada02 = l.Where(x => x > 10).OrderBy(a => a).Select(a => a);
            var listaFiltrada03 = from a in l where a > 10 orderby a select a;

            foreach (var item in listaFiltrada01)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (var item in listaFiltrada02)
            {
                
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (var item in listaFiltrada03)
            {

                Console.Write(item + ", ");
            }

            Console.ReadKey(); 
        }
    }
}
