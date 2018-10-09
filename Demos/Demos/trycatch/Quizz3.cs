using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public class Quizz3
    {
        public void Method2()
        {
            Console.WriteLine("C");
            throw new Exception("Mon exception");
            Console.WriteLine("D");
        }

        public void Method1()
        {
            Console.WriteLine("B");
            try
            {
                Method2();
            }
            catch
            {
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
