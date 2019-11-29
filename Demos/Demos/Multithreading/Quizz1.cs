using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demos.Multithreading
{
    public class Quizz1
    {
        static void Code()
        {
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
        }
    }
}
