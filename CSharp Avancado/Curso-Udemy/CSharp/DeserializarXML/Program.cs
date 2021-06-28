using Biblioteca;
using System;
using System.IO;
using System.Xml.Serialization;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\Hudson\OneDrive\Cursos\CSharp\CSharp Avancado\Curso-Udemy\CSharp\SerializarXML\01_Serializar.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario) serializador.Deserialize(stream);

            Console.WriteLine(string.Format("Nome: {0}, Cpf: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email));

            Console.ReadKey();
        }
    }
}
