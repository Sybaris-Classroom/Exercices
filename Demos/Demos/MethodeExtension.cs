using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public static class MethodeExtension // Doit être static pour une méthode d'extension
    {
        public static string NomPrenom(this Personne personne)
        {
            return personne.Nom + " "+ personne.Prenom;
        }
    }
}
