using System;
using System.Threading;

namespace ThreadSafe
{
    class Program
    {
        static int rede = 0;
        static object variavelDeControle = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Data inicial: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticacao);
                t1.IsBackground = true;
                t1.Start();
            }

            Console.ReadKey();
        }

        static void ThreadRepeticacao()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine("Numero: " + i);
                    rede++;
                };
            }

            

            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}
