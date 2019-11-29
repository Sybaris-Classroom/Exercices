using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demos.Multithreading
{
    public class Quizz6
    {
        static object A = new object();

        static void MethodA()
        {
            Console.WriteLine("A1");
            lock (A)
            {
                Console.WriteLine("A2");
                Thread.Sleep(1000);
                lock (A)
                {
                    Console.WriteLine("A3");
                }
            }
        }

        static void MethodB()
        {
            Console.WriteLine("B1");
            lock (A)
            {
                Console.WriteLine("B2");
                Thread.Sleep(1000);
                lock (A)
                {
                    Console.WriteLine("B3");
                }
            }
        }

        public static void Run()
        {
            Task.Run((Action)MethodA);
            Task.Run((Action)MethodB);
        }

    }
}
