using System;
using System.Threading;

namespace ThreadID
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticacao);
                t1.Start(i);
            }

            
            Console.ReadKey();
        }

        static void ThreadRepeticacao(object id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: " + id + " - Numero: " + i + "ID Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
