using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public static class YieldReturn
    {
        static IEnumerable<int> Suite1()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
        }

        static IEnumerable<int> Suite2()
        {
            int result = 1;
            for (int i = 0; i < 5; i++)
            {
                yield return result;
                result = result * 2;
            }
        }

        public static void Run()
        {
            Console.WriteLine("Suite 1");
            foreach (var item in Suite1())
                Console.WriteLine(item);

            Console.WriteLine("Suite 2");
            foreach (var item in Suite2())
                Console.WriteLine(item);
        }
    }
}
