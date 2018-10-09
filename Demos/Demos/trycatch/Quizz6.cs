using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public class Quizz6
    {
        public void Method2()
        {
            throw new Exception("Mon exception");
        }

        public void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw; // vs throw ex;
            }
            Console.WriteLine("A");
        }

        public void Main()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("B");
            Console.ReadKey();
        }
    }
}
