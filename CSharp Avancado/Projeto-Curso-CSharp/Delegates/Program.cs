using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.Lib;

namespace Delegates
{
    class Program
    {
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            //var result1 = Soma(10, 20);

            //var result2 = Subtrair(20, 10);

            Calcula calc1 = new Calcula(Soma);

            int result1 = calc1(10,20);

            Calcula calc2 = new Calcula(Subtrair);

            int result2 = calc2(20, 10);

            Console.WriteLine("Soma: " + result1);
            Console.WriteLine("Subtração: " + result2);

            Console.WriteLine("-");

            Foto foto = new Foto { Nome = "foto.jpg", TamanhoX = 1920, TamanhoY = 1080 };

            //FotoProcessador.Processador(foto);

            Console.WriteLine("-");


            //Tela - Cadastro de Usuario: Thumb (Ftoto de Perfil).
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processador(foto);

            //Tela - Cadastro de Produtos: Colorir + TamanhoMed.
            Foto foto2 = new Foto { Nome = "foto2.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamanhoMedio;
            FotoProcessador.Processador(foto2 );

            //Cadastro de Albuns do Usuario - Retro: Preto e branco.
            Foto foto3 = new Foto { Nome = "foto3.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processador(foto2);


            Console.ReadKey();
        }


        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
