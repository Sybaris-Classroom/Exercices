using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{
    public class Quizz3
    {
        static string[] colors = { "green", "brown", "blue", "red" };
        public static void Run()
        {
            var query =   from c in colors
                          where c.Length > 3
                          orderby c.Length
                          select c;

            // Same as : 
            //IEnumerable<string> query = colors
            //          .Where(c => c.Length > 3)
            //          .OrderBy(c => c.Length);

            Console.WriteLine("query is IEnumerable<string> = " + (query is IEnumerable<string>).ToString());
        }
    }
}
