using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{
    public class Quizz4
    {

        static string[] colors = { "green", "brown", "blue", "red" };

        public static void Run()
        {
            var query =     from c in colors
                            where c.Length == colors.Max(c2 => c2.Length)
                            select c;

            foreach (var element in query)
                Console.WriteLine(element);
        }
    }
}
