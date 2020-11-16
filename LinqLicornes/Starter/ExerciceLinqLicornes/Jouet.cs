using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLinqLicornes
{
    public class Jouet
    {
        public string NomProprietaire { get; set; }
        public string NomJouet { get; set; }

        public override string ToString()
        {
            return NomJouet;
        }
    }
}
