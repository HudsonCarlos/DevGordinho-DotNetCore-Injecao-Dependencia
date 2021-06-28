using Biblioteca;
using System.IO;
using System.Web.Script.Serialization;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Gabriela Neves", CPF = "000000000000", Email = "gabriela@teste.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string usuarioSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\Users\Hudson\OneDrive\Cursos\CSharp\CSharp Avancado\Curso-Udemy\CSharp\SerializarJSON\03_SerializarJSON.json");
            sw.WriteLine(usuarioSerializado);
            sw.Close();
        }
    }
}
