using System;
using System.Threading;

namespace ThreadMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread Sleep
            Console.WriteLine("Início do nosso programa.");
            Thread.Sleep(3000);
            Console.WriteLine("Término do nosso programa.");


            //Thread Join
            Thread t1 = new Thread(ThreadRepeticacao);
            t1.Start();
            t1.Join(); //Aguarda o término da primeira thread para em seguida executar a outra.

            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");

            Console.ReadKey();
        }

        static void ThreadRepeticacao(object id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: " + id + " - Numero: " + i + " ID Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
