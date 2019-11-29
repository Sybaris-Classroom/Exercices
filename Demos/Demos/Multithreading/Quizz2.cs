using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demos.Multithreading
{
    public class Quizz2
    {
        static object objectLocker = new object();

        static void Code()
        {
            lock (objectLocker)
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread N°" +
                      Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(100);
                }
        }

        public static void Run()
        {
            Console.WriteLine("Main Thread = N°" +
               Thread.CurrentThread.ManagedThreadId);
            Thread t = new Thread(() => Code());
            t.Start();
            Code();
            Console.WriteLine("Appuyez sur une touche pour terminer");
            Console.ReadKey();
        }

    }
}
