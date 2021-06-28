using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Biblioteca;

namespace Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            VariaveisGlobais.CAMINHO_PUBLIC = VariaveisGlobais.AplicaReplace(VariaveisGlobais.CAMINHO_EXECUTAVEL, @"Generics\bin\Debug", @"Biblioteca\public");
            StreamWriter sw = new StreamWriter(VariaveisGlobais.CAMINHO_PUBLIC + @"\" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objDeserializado = serializador.Serialize(obj);

            sw.Write(objDeserializado);
            sw.Close();
        }

        public static T Deserializar<T>()
        {
            VariaveisGlobais.CAMINHO_PUBLIC = VariaveisGlobais.AplicaReplace(VariaveisGlobais.CAMINHO_EXECUTAVEL, @"Generics\bin\Debug", @"Biblioteca\public");
            StreamReader sr = new StreamReader(VariaveisGlobais.CAMINHO_PUBLIC + @"\" + typeof(T).Name + ".txt");
            string Conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T) serializador.Deserialize(Conteudo, typeof(T));

            return obj;
        }
    }
}
