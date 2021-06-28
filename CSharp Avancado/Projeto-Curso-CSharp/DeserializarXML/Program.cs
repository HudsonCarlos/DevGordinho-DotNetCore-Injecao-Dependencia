using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            VariaveisGlobais.CAMINHO_PUBLIC = VariaveisGlobais.AplicaReplace(VariaveisGlobais.CAMINHO_EXECUTAVEL, @"DeserializarXML\bin\Debug", @"Biblioteca\public");

            StreamReader strean = new StreamReader(VariaveisGlobais.CAMINHO_PUBLIC + @"\SerializarXML.xml");

            if (Directory.Exists(VariaveisGlobais.CAMINHO_PUBLIC))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
                Usuario usuario = (Usuario)serializador.Deserialize(strean);

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
