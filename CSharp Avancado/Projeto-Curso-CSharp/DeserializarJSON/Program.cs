using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Biblioteca;
using System.IO;

namespace DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            //VariaveisGlobais.CAMINHO_PUBLIC = VariaveisGlobais.AplicaReplace(VariaveisGlobais.CAMINHO_EXECUTAVEL, @"DeserializarXML\bin\Debug", @"Biblioteca\public");
            VariaveisGlobais.CAMINHO_PUBLIC = VariaveisGlobais.AplicaReplace(VariaveisGlobais.CAMINHO_EXECUTAVEL, @"DeserializarJSON\bin\Debug", @"Biblioteca\public");

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            if (Directory.Exists(VariaveisGlobais.CAMINHO_PUBLIC))
            {
                StreamReader stream = new StreamReader(VariaveisGlobais.CAMINHO_PUBLIC + @"\SerializarJSON.json");
                string linhasArquivo = stream.ReadToEnd();

                usuario = (Usuario) serializador.Deserialize(linhasArquivo, typeof(Usuario));

                Console.WriteLine("O arquivo foi deserializado");
                Console.WriteLine("Nome usuario: {0}, CPF: {1}, Email: {2} ", usuario.Nome, usuario.CPF, usuario.Email);

                //Process.Start("Explorer.exe",VariaveisGlobais.CAMINHO_PUBLIC);
            }
            else
            {
                Console.WriteLine("O caminho da pasta public não existe");
            }

            Console.ReadKey();

        }
    }
}
