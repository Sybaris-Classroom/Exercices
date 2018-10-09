using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public class Quizz5
    {

        public class BaseException : Exception { }
        public class ChildException : BaseException { }

        public void Main()
        {
            Console.WriteLine("A");
            try
            {
                Console.WriteLine("B");
                throw new BaseException();
                Console.WriteLine("C");
            }
            catch (ChildException)
            {
                Console.WriteLine("D");
            }
            catch (BaseException)
            {
                Console.WriteLine("E");
            }
            catch (Exception)
            {
                Console.WriteLine("F");
            }
            Console.WriteLine("G");
            Console.ReadKey();
        }
    }
}
