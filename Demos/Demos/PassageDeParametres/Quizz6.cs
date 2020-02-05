using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.PassageDeParametres
{
    public static class Quizz6
    {
        public static void Run()
        {
            string nom = "Jean";
            Console.WriteLine("1 - nom : " + nom);
            Methode(nom);
            Console.WriteLine("4 - nom : " + nom);
        }

        static void Methode(string argNom)
        {
            Console.WriteLine("2 - argNom : " + argNom);
            argNom = "Pierre";  // idem à argNom = new String("Pierre") 
            Console.WriteLine("3 - argNom : " + argNom);
        }

    }
}
