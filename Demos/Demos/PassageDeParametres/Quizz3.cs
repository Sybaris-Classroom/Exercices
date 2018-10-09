using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.PassageDeParametres
{
    public static class Quizz3
    {
        struct Person
        {
            public int Age;
        }

        public static void Run()
        {
            Person p = new Person();
            p.Age = 18;
            Console.WriteLine("1 - p.Age : " + p.Age);
            Methode(p);
            Console.WriteLine("4 - p.Age : " + p.Age);
        }

        static void Methode(Person aPers)
        {
            Console.WriteLine("2 - aPers.Age : " + aPers.Age);
            aPers.Age = 20;
            Console.WriteLine("3 - aPers.Age : " + aPers.Age);
        }

    }
}
