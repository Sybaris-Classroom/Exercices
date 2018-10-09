using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public class Quizz2
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
            Method2();
            Console.WriteLine("E");
        }

        public void Main()
        {
            Console.WriteLine("A");
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("F");
            Console.ReadKey();
        }
    }
}
