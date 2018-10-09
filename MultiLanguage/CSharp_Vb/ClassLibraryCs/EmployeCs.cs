using ClassLibraryVB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCs
{
    public class EmployeCs : EmployeVB
    {
        public string Prenom;

        public void CodeCs()
        {
            CodeVB();
            Console.WriteLine("Mon code Cs");
        }
    }
}
