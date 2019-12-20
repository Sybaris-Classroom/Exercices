using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Linq
{
    public class Quizz7
    {
        private static IEnumerable<string> GetValues()
        {
            Console.WriteLine("Appel de GetValues");
            yield return "Jean";
            yield return "Pierre";
        }

        public static void Run()
        {
            var q = GetValues().ToList();
            Console.WriteLine("Affichage des données:");
            foreach (var s in q)
                Console.WriteLine(s);
        }
    }
}
