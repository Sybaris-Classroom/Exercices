using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public static class Nullable
    {
        public static void Run()
        {
            //int i = null; // Ne compile pas
            int? i = null;
            // Identique à écrire ceci : Nullable<int> i = null;
            if (i.HasValue) // ou (i != null)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("i vaut NULL");

            i = 5;
            //int j = i;  // Ne compile pas
            int j = (int)i; // Lève une exception si i == null
            int k = i ?? -1; // Si i est null initialize k à -1
        }
    }
}
