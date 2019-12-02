using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{
    public class Quizz2
    {
        static string[] colors = { "green", "brown", "blue", "red" };

        public static void Run()
        {
            Console.WriteLine(colors.OrderBy(c => c.Length).Single());
        }
    }
}
