using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.PassageDeParametres
{
    public static class QuizzAll
    {
        public static void Run()
        {
            Console.WriteLine("Quizz1");
            PassageDeParametres.Quizz1.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz2");
            PassageDeParametres.Quizz2.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz3");
            PassageDeParametres.Quizz3.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz4");
            PassageDeParametres.Quizz4.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz6");
            PassageDeParametres.Quizz4.Run();
            Console.WriteLine("******************");
        }
    }
}
