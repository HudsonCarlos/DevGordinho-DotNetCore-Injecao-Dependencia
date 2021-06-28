using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ e LAMBDA
            //LAMBDA = (entrada) => (expressao) 
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            var listaFiltrada1 = lista.Where(a => a > 10).Select(a => a);
            var listaFiltrada2 = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            var listaFiltrada3 = from x in lista where x > 10 orderby x select x;

            Console.WriteLine("-------------------------------------------------------------------");

            foreach (var item in listaFiltrada1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-");

            foreach (var item in listaFiltrada2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-");

            foreach (var item in listaFiltrada3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            //LIKE
            List<Usuario> lista2 = new List<Usuario>();
            lista2.Add(new Usuario() { Nome = "Jose", Email = "jose@gmail.com" });
            lista2.Add(new Usuario() { Nome = "Maria", Email = "maria@hotmail.com" });
            lista2.Add(new Usuario() { Nome = "João", Email = "joao@ig.com" });
            lista2.Add(new Usuario() { Nome = "Felipe", Email = "felipe@gmail.com" });
            lista2.Add(new Usuario() { Nome = "Elias", Email = "elias@gmail.com" });

            var listaFiltrada = lista2.Where(x => x.Email.Contains("@gmail.com")).OrderBy(x => x.Nome).Select(x => x);

            foreach (var item in lista2)
            {
                Console.WriteLine("Nome: " + item.Nome + "Email: " + item.Email);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            List<Livro> listaLivro = new List<Livro>();
            List<Autor> listaAutor = new List<Autor>();

            listaAutor.Add( new Autor() { Id = 1, Nome = "Leonardo" });
            listaAutor.Add( new Autor() { Id = 2, Nome = "Maria" });
            listaAutor.Add( new Autor() { Id = 3, Nome = "Joseph" });

            listaLivro.Add( new Livro() { Id = 1, AutorId = 2, AnoPublicacao = "1988", Titulo = "Livro 01" });
            listaLivro.Add( new Livro() { Id = 2, AutorId = 2, AnoPublicacao = "1989", Titulo = "Livro 02" });
            listaLivro.Add( new Livro() { Id = 3, AutorId = 3, AnoPublicacao = "1990", Titulo = "Livro 03" });
            listaLivro.Add( new Livro() { Id = 4, AutorId = 1, AnoPublicacao = "1991", Titulo = "Livro 04" });



            var listaJoin = from livro in listaLivro join autor in listaAutor on livro.AutorId equals autor.Id select new { livro, autor };

            foreach (var item in listaJoin)
            {
                Console.WriteLine("Livro: " + item.livro.Titulo + " - " + "Autor: " + item.autor.Nome);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            //GROUP - DISTINCT

            int[] listaNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            var listaFiltrada5 = listaNum.Distinct().OrderBy(a=>a).Select(a=>a);

            foreach (var item in listaFiltrada5)
            {
                Console.WriteLine("Numeros: " + item);
            }

            Console.WriteLine(" - ");

            var listaFiltrada6 = listaNum.OrderBy(a=>a).GroupBy(a => a).Select(a => a);

            foreach (var item in listaFiltrada6)
            {
                Console.WriteLine("Numeros: " + item.Key);
            }

            Console.ReadKey();

        }
    }
}
