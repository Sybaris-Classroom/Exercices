using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{
    public class Quizz9
    {
        static string[] colors = { "green", "brown", "blue", "red" };

        public static void Run()
        {
            var query = colors.Where(c => c.Contains("e"));
            query = query.Where(c => c.Contains("n"));

            Console.WriteLine(query.Count());
        }
    }
}
