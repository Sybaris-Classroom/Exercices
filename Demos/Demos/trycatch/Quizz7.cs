using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public class Quizz7
    {
        public void Main()
        {
            Console.WriteLine("A");
            try
            {
                Console.WriteLine("B");
                throw new Exception("Mon exception");
                Console.WriteLine("C");
            }
            finally
            {
                Console.WriteLine("D");
            }
            Console.WriteLine("E");
            Console.ReadKey();
        }
    }
}
