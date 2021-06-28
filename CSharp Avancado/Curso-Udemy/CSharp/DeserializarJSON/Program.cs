using Biblioteca;
using System;
using System.IO;
using System.Web.Script.Serialization;

namespace DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\Hudson\OneDrive\Cursos\CSharp\CSharp Avancado\Curso-Udemy\CSharp\SerializarJSON\03_SerializarJSON.json");
            string linhaDoArquivo = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuarioSerializado = (Usuario)serializador.Deserialize(linhaDoArquivo, typeof(Usuario));

            Console.WriteLine(string.Format("Nome: {0}, CPF: {1}, Email: {2}", usuarioSerializado.Nome, usuarioSerializado.CPF, usuarioSerializado.Email));
            Console.ReadKey();
        }
    }
}
