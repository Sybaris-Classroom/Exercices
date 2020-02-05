using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections.Run();
            //LogsDebugTrace.Run(args);
            //Delegates.Run();
            //DelegatesLogPerf.Run();
            //Nullable.Run();
            //YieldReturn.Run();
            //StringCompareTo.Run();
            //AppConfigSettings.Run();

            // Methode d'extension
            //Personne p = new Personne() { Nom = "Planas",Prenom = "Jean-Pierre" };
            //Console.WriteLine(p.NomPrenom);

            // Quizz : Try Catch Exceptions...
            //trycatch.QuizzAll.Run();
            ////new trycatch.Quizz1().Main();
            ////new trycatch.Quizz2().Main();
            ////new trycatch.Quizz3().Main();
            ////new trycatch.Quizz4().Main();
            ////new trycatch.Quizz5().Main();
            ////new trycatch.Quizz6().Main();
            ////new trycatch.Quizz7().Main();
            ////new trycatch.Quizz8().Main();

            // Quizz : Passage de paramètres
            //PassageDeParametres.QuizzAll.Run();
            ////PassageDeParametres.Quizz1.Run();
            ////PassageDeParametres.Quizz2.Run();
            ////PassageDeParametres.Quizz3.Run();
            ////PassageDeParametres.Quizz4.Run();
            PassageDeParametres.Quizz6.Run();

            // Quizz : Boxing
            //Boxing.RunAllSteps();

            // Quizz : Multithreading
            //Multithreading.Quizz1.Run();
            //Multithreading.Quizz2.Run();
            //Multithreading.Quizz3.Run();
            //Multithreading.Quizz4.Run();
            //Multithreading.Quizz5.Run();
            //Multithreading.Quizz6.Run();
            //Multithreading.Quizz7.Run();
            //Console.WriteLine("Quizz 8 prvoque un deadlock...");
            //Multithreading.Quizz8.Run();

            // Quizz : AsyncAwait
            //AsyncAwait.Quizz1.Run();
            //AsyncAwait.Quizz2.Run();
            //AsyncAwait.Quizz3.Run();
            //AsyncAwait.Quizz4.Run();
            //AsyncAwait.Quizz4Bis.Run();
            //AsyncAwait.Quizz5.Run();
            //For AsyncAwait.Quizz6 use Unit tests

            // Quizz : Linq
            //Linq.Quizz1.Run();
            //Linq.Quizz2.Run();
            //Linq.Quizz3.Run();
            //Linq.Quizz4et5.Run();
            //Linq.Quizz6.Run();
            //Linq.Quizz7.Run();
            //Linq.Quizz8.Run();
            //Linq.Quizz9.Run();
            //Linq.Quizz10.Run();

            Console.WriteLine("Appuyez sur une touche pour quitter le programme...");
            Console.ReadKey();
        }

    }
}
