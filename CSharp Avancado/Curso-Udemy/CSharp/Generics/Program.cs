using Generics.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };
            Casa casa = new Casa() { Cidade = "Brasília", Endereco = "QSQ 400" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria@gmail.com", Senha = "123456" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            //Console.WriteLine("Carro2: " + carro2.Marca + " - " + carro.Modelo);
            //Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa.Endereco);
            //Console.WriteLine("Usuario2: " + usuario2.Nome + " - " + usuario.Email);

            var s = "hudson";

            Console.WriteLine(s.Substring(0, 1).ToUpper() + s.Substring(1,s.Length - 1));

            Console.ReadKey();
        }
    }
}
