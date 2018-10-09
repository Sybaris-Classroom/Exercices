using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public static class QuizzAll
    {
        public static void Run()
        {
            Console.WriteLine("Quizz1");
            new trycatch.Quizz1().Main();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz2");
            new trycatch.Quizz2().Main();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz3");
            new trycatch.Quizz3().Main();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz4");
            new trycatch.Quizz4().Main();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz5");
            new trycatch.Quizz5().Main();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz6");
            new trycatch.Quizz6().Main();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz7");
            new trycatch.Quizz7().Main();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz8");
            new trycatch.Quizz8().Main();
            Console.WriteLine("******************");

        }
    }
}
