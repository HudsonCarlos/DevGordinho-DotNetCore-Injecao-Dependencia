using System;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRepeticacao);
            t1.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main: " + i);
            }
        }

        static void ThreadRepeticacao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Numero: " + i);
            }
        }
    }
}
