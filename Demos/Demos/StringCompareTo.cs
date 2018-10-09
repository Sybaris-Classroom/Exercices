using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public static class StringCompareTo
    {
        public static void Run()
        {
            string s1 = "Jean";
            string s2 = "Paul";
            string s3 = "Jacques";
            string s4 = "Jean";
            Console.WriteLine("s1>s2 ?");
            Console.WriteLine($"\"{s1}\".CompareTo(\"{s2}\") = " + s1.CompareTo(s2));
            Console.WriteLine($"\"{s1}\".CompareTo(\"{s3}\") = " + s1.CompareTo(s3));
            Console.WriteLine($"\"{s1}\".CompareTo(\"{s4}\") = " + s1.CompareTo(s4));
        }
    }
}
