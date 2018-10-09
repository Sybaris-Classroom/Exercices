using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public static class Boxing
    {
        private static void Step1()
        {
            // 1°/ : Tout est object :
            Console.WriteLine(3.ToString());

            // 2°/ : example de boxing & unboxing
            // https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/types/boxing-and-unboxing
            int i = 1;
            object o = i; // boxing
            int j = (int)o; // unboxing
        }

        private static void Step2()
        {
            // 3°/ Rappel affectation avec un type référence :
            object o1 = new Personne() { Prenom = "Jean", Age = 10 };
            object o2 = new Personne() { Prenom = "Pierre", Age = 30 };
            Console.WriteLine("o1 = " + o1);
            Console.WriteLine("o2 = " + o2);
            Console.WriteLine("(o1 == o2) = " + (o1 == o2));
            Console.WriteLine("Affectation o1 = o2 et o1.Age = 50");
            o1 = o2;
            ((Personne)o1).Age = 50;
            Console.WriteLine("o1 = " + o1);
            Console.WriteLine("o2 = " + o2); // o2 pointe vers le même objet que o1
            Console.WriteLine("(o1 == o2) = " + (o1 == o2));
        }

        private static void Step3()
        {
            // Type affectation avec un valeur (boxing)
            object o1 = 1; // boxing
            object o2 = 2; // boxing
            Console.WriteLine("o1 = " + o1);
            Console.WriteLine("o2 = " + o2);
            Console.WriteLine("(o1 == o2) = " + (o1 == o2));
            Console.WriteLine("Affectation o1 = o2 et o2 = 3");
            o1 = o2;
            o2 = 3; // boxing
            Console.WriteLine("o1 = " + o1);
            Console.WriteLine("o2 = " + o2);
            Console.WriteLine("(o1 == o2) = " + (o1 == o2)); //o1 & o2 pointent vers 2 objets differents
        }

        private static void Step4()
        {
            // Comparaison avant boxing et après boxing
            // https://stackoverflow.com/questions/2111857/why-do-we-need-boxing-and-unboxing-in-c
            int i = 2;
            int j = 3;
            i = j;
            object o1 = i;
            object o2 = j;
            Console.WriteLine("(i == j) = " + (i == j));
            Console.WriteLine("(o1 == o2) = " + (o1 == o2)); // Compare la référence entre 2 objets
            Console.WriteLine("(o1.Equals(o2)) = " + (o1.Equals(o2))); // Compare la valeur entre 2 objets
        }

        private static void Step5()
        {
            // Cas particulier des chaines de caractères
            // http://www.dotnetdojo.com/comparer-deux-objets-en-csharp/
            string s1 = "123";
            string s2 = new string(new char[] { '1', '2', '3' }); // pour éviter les optimisations du compilateur, création d'une deuxième chaine d'une autre manière 
            object o1 = s1;
            object o2 = s2;
            Console.WriteLine("(s1 == s2) = " + (s1 == s2)); // Operateur == surchargé pour comparer le contenu, et non pas la référence
            Console.WriteLine("(s1.Equals(s2)) = " + (s1.Equals(s2)));
            Console.WriteLine("(o1 == o2) = " + (o1 == o2)); // Compare la référence entre 2 objets
            Console.WriteLine("(o1.Equals(o2)) = " + (o1.Equals(o2)));
        }

        public static void RunAllSteps()
        {
            Console.WriteLine("Step1");
            Step1();
            Console.WriteLine("******************");

            Console.WriteLine("Step2");
            Step2();
            Console.WriteLine("******************");

            Console.WriteLine("Step3");
            Step3();
            Console.WriteLine("******************");

            Console.WriteLine("Step4");
            Step4();
            Console.WriteLine("******************");

            Console.WriteLine("Step5");
            Step5();
            Console.WriteLine("******************");
        }

    }
}
