using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{
    public class Quizz10
    {
        static string[] colors = { "green", "brown", "blue", "red" };

        public static void Run()
        {
            string s = "e";
            var query = colors.Where(c => c.Contains(s));
            s = "n";
            query = query.Where(c => c.Contains(s));
            Console.WriteLine(query.Count());
        }
    }
}
