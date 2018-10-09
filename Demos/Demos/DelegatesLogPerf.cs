using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demos
{
    public static class DelegatesLogPerf
    {
        public static void Run()
        {
            Console.WriteLine("Exemple avec la méthode de Log");

            MaMethodeCompliquee();
            MaMethodeCompliquee2();
        }

        static public void Log(string aMethodName, Action aDelegate)
        {   // Dans le cas où on veut récupérer le nom de la méthode depuis la call stack
            /*
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            MethodBase methodBase = stackFrame.GetMethod();
            string aMethodName = methodBase.Name;
            */
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("{1} Start Method ({0})", aMethodName, DateTime.Now.ToString("hh:mm:ss"));
            stopwatch.Start();
            aDelegate();
            stopwatch.Stop();
            long ms = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("{1} End Method ({0}) - Perf = {2} ms", aMethodName, DateTime.Now.ToString("hh:mm:ss"), ms);
        }

        static public void MaMethodeCompliquee()
        {
            Log(/*"MaMethodeCompliquee", */
                nameof(MaMethodeCompliquee)  // Plus pratique car erreur de compilation si renommée
                , () =>
                {
                    Console.WriteLine("Code compliquee 1");
                    Thread.Sleep(50);
                });
        }

        static public void MaMethodeCompliquee2()
        {
            Log("MaMethodeCompliquee2", () =>
            {
                Console.WriteLine("Code compliquee 2");
            });
        }
    }
}
