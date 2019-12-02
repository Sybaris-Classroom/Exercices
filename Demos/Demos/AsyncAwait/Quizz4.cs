using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demos.AsyncAwait
{
    public class Quizz4
    {

        public static void Log()
        {
            Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}");
        }

        public async  static void Run()
        {
            Console.WriteLine("SynchronizationContext = "
          + ((SynchronizationContext.Current == null) ? "NULL" : "EXISTS"));

            Log();
            await Task.Delay(100);
            Log();
        }

    }
}
