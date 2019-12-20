using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{
    public class Quizz8
    {
        static string[] colors = { "green", "brown", "blue", "red" };

        public static void Run()
        {
            var list = new List<string>(colors);
            IEnumerable<string> query = list.Where(c => c.Length == 3);
            list.Remove("red");

            Console.WriteLine(query.Count());
        }
    }
}
