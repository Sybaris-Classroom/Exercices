using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public class Quizz8
    {
        public void Method1()
        {
            try
            {
                Console.WriteLine("B");
                return;
                Console.WriteLine("C");
            }
            finally
            {
                Console.WriteLine("D");
            }
            Console.WriteLine("E");
        }

        public void Main()
        {
            Console.WriteLine("A");
            Method1();
            Console.WriteLine("F");
            Console.ReadKey();
        }
    }
}
