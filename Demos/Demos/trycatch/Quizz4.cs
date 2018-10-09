using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.trycatch
{
    public class Quizz4
    {

        public class BaseException : Exception { }
        public class ChildException : BaseException { }

        public void Main()
        {
            Console.WriteLine("A");
            try
            {
                Console.WriteLine("B");
                throw new ChildException();
                Console.WriteLine("C");
            }
            catch (BaseException)
            {
                Console.WriteLine("D");
            }
            // Décommenter ceci pour montrer que cela ne compile pas : 
            // Error CS0160  A previous catch clause already catches all exceptions of this or of a super type('Quizz4.BaseException')            
            //catch (ChildException)
            //{
            //    Console.WriteLine("E");
            //}
            catch (Exception)
            {
                Console.WriteLine("F");
            }
            Console.WriteLine("G");
            Console.ReadKey();
        }
    }
}
