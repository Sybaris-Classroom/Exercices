using ClassLibraryCpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCs
{
    public class EmployeCs : EmployeCpp
    {
        public string Prenom;

        public void CodeCs()
        {
            int result = CodeCpp();
            Console.WriteLine("Mon code Cs");
            Console.WriteLine("resultat = "+ result);
        }
    }
}
