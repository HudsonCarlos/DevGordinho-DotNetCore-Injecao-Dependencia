using System.IO;
using System.Web.Script.Serialization;

namespace Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Hudson\OneDrive\Cursos\CSharp\CSharp Avancado\Curso-Udemy\CSharp\Generics\05_" + obj .GetType().Name + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Hudson\OneDrive\Cursos\CSharp\CSharp Avancado\Curso-Udemy\CSharp\Generics\05_" + typeof(T).Name + ".txt");
            string Conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T)serializador.Deserialize(Conteudo, typeof(T));


            return obj;
        }
    }
}
