using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{

    public class Quizz1
    {
        // from http://www.albahari.com/nutshell/linqquiz.aspx
        // other interesting url : https://www.csharp-examples.net/linq-aggregation-methods/

        static string[] colors = { "green", "brown", "blue", "red" };

        public static void Run()
        {
            Console.WriteLine(colors.Max(c => c.Length));
        }
    }
}
