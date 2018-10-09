using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.PassageDeParametres
{
    public static class Quizz1
    {
        public static void Run()
        {
            int age = 18;
            Console.WriteLine("1 - age : " + age);
            Methode(age);
            Console.WriteLine("4 - age : " + age);
        }

        static void Methode(int aAge)
        {
            Console.WriteLine("2 - aAge : " + aAge);
            aAge = 20;
            Console.WriteLine("3 - aAge : " + aAge);
        }
    }
}
