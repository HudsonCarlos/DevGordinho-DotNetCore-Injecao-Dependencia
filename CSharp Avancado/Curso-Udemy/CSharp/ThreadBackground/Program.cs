using System;
using System.Threading;

namespace ThreadBackground
{
    class Program
    {
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
                Console.WriteLine("Numero: " + i);
            }

            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}
