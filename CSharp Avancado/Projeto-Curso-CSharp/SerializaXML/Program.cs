using System;
using System.IO;
using Biblioteca;
using System.Xml.Serialization;

namespace SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer = serializador = new XmlSerializer(Usuario.GetType(Usuario));

            VariaveisGlobais.CAMINHO_PUBLIC = VariaveisGlobais.AplicaReplace(VariaveisGlobais.CAMINHO_EXECUTAVEL,@"SerializaXML\bin\Debug", @"Biblioteca\public");

            if (Directory.Exists(VariaveisGlobais.CAMINHO_PUBLIC))
            {
                StreamWriter strean = new StreamWriter(VariaveisGlobais.CAMINHO_PUBLIC + @"\SerializarXML.xml");

                serializador.Serialize(strean,usuario);

                Console.WriteLine("O arquivo foi criado");

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
