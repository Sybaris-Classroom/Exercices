using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    // Pour l'utlisation du designer settings : https://msdn.microsoft.com/en-us/library/aa730869(v=vs.80).aspx
    // Pour aller plus loin : https://nico-pyright.developpez.com/tutoriel/vc2005/configurationsectioncsharp/
    public static class AppConfigSettings
    {
        public static void Run()
        {
            string nom = Properties.Settings.Default.Nom;
            string prenom = ConfigurationManager.AppSettings["prenom"];
            Console.WriteLine("Je m'appelle {0} {1}", prenom, nom);
        }
    }
}
