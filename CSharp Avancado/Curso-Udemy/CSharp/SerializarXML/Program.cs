using Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Hudosn da Silva Carlos", CPF = "08494285645", Email = "hudsonscarlos@outlook.com" };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            StreamWriter stream = new StreamWriter(@"C:\Users\Hudson\OneDrive\Cursos\CSharp\CSharp Avancado\Curso-Udemy\CSharp\SerializarXML\01_Serializar.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}
