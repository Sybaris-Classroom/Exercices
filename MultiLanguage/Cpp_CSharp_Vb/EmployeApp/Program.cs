using ClassLibraryCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeCs emp = new EmployeCs();
            emp.Nom = "Planas";
            emp.Prenom = "Jean-Pierre";
            emp.Age = 42;
            Console.WriteLine("Employe = " + emp.Nom + " " + emp.Prenom + " (" + emp.Age + ")");

            emp.CodeCs();
            Console.ReadKey();
        }
    }
}
