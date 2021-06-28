using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInq_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "Leonardo" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Maria Maria" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "Joseph" });

            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor amado" });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Bem amado" });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Um espião em Washington" });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "A Vida na terra" });

            //var listajoin = from livro in listaLivro join autor in listaAutor on livro.autor.id equals autor.id seletc livro;

            //foreach (var item in ListaJoin)
            //{
            //    Console.WriteLine("Livro: " + item.Titulo + " - Autor: " + item.Nome);
            //}
        }
    }
}
