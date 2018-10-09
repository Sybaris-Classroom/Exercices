using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public static class LogsDebugTrace
    {
        public static void Run(string[] args)
        {
            // Trace = Mode Debug & Release
            //Trace.Assert(args.Length==1, "Pas d'argument passé");
            // Trace = Mode Debug only
            Debug.Assert(args.Length == 1, "Pas d'argument passé");
            Trace.WriteLine("Texte");
            Trace.Flush();
        }
    }
}
