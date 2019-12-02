using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demos.AsyncAwait
{
    public class Quizz1
    {

        public static void Log()
        {
            Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}");
        }

        public async static void Run()
        {
            Log();
            await Task.Delay(100);
            Log();
            Console.WriteLine("Appuyez sur une touche pour terminer");
            Console.ReadKey();
        }
    }
}
