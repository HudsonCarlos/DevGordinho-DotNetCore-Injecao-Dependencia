using System;
using System.Web.Script.Serialization;
using System.IO;
using Biblioteca;
using System.Diagnostics;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializador = serializador.Serialize(usuario);

            VariaveisGlobais.CAMINHO_PUBLIC = VariaveisGlobais.AplicaReplace(VariaveisGlobais.CAMINHO_EXECUTAVEL, @"SerializarJSON\bin\Debug", @"Biblioteca\public");

            if(Directory.Exists(VariaveisGlobais.CAMINHO_PUBLIC))
            {
                StreamWriter strean = new StreamWriter(VariaveisGlobais.CAMINHO_PUBLIC + @"\SerializarJSON.json");

                strean.WriteLine(objSerializador);
                strean.Close();

                Console.WriteLine("O arquivo foi criado");

                Process.Start("Explorer.exe",VariaveisGlobais.CAMINHO_PUBLIC);
            }
            else
            {
                Console.WriteLine("O caminho da pasta public não existe");
            }

            Console.ReadKey();
        }
    }
}
