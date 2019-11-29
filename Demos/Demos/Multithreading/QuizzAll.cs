using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Multithreading
{
    public class QuizzAll
    {
        public static void Run()
        {
            Console.WriteLine("Quizz1");
            Multithreading.Quizz1.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz2");
            Multithreading.Quizz2.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz3");
            Multithreading.Quizz3.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz4");
            Multithreading.Quizz4.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz5");
            Multithreading.Quizz5.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz6");
            Multithreading.Quizz6.Run();
            Console.WriteLine("******************");

            Console.WriteLine("Quizz7 à lancer séparément");
            Console.WriteLine("******************");

            Console.WriteLine("Quizz8 à lancer séparément (Attention deadlock)");
            Console.WriteLine("******************");
        }
    }
}
