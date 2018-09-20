using CommandLineParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExec
{
    /// <summary>
    /// This class is here only to wrap a logger, to switch easly on Console or Log file
    /// </summary>
    public class LogWrapper : ILogWrapper
    {
        public void Debug(string message)
        {
            ConsoleColorAction(ConsoleColor.DarkGray,
                    () => Console.WriteLine(message)
                );
        }

        public void Error(string message)
        {
            ConsoleColorAction(ConsoleColor.Red,
                    () => Console.WriteLine(message)
                );
        }

        public void Error(Exception ex, string message)
        {
            ConsoleColorAction(ConsoleColor.Red,
                        () =>
                        {
                            Console.Error.WriteLine("EXCEPTION : " + ex.Message);
                            Console.Error.WriteLine(ex.ToString());
                            Console.Error.WriteLine(message);
                        }
                    );
        }

        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Warn(string message)
        {
            ConsoleColorAction(ConsoleColor.Yellow,
                    () => Console.WriteLine(message)
                );
        }

        public void ConsoleColorAction(ConsoleColor aConsoleColor, Action aAction)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                aAction();
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }

}
