using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public class Personne
    {
        public string Nom;
        public string Prenom;
        public int Age;
        public override string ToString()
        {
            return Prenom+" "+Nom+" ("+Age+")";
        }
    }
}
