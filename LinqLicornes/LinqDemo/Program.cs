using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new List<Licorne>();
            liste.Add(new Licorne());
            liste.Add(new Licorne());
            liste.Add(new Licorne());
            liste.Add(new Licorne());
            liste.Add(new Licorne());
            var requeteLinq = liste.Take(2).Select(x => x.CouleurCriniere = "Rose");
            foreach (var licorn in liste)
            {
                Console.WriteLine(licorn.CouleurCriniere);
            }
            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadKey();
        }
    }

    public class Licorne
    {
        public string CouleurCriniere { get; set; }

        public Licorne()
        {
            CouleurCriniere = "Blanc";
        }
    }

    // Démo :
    // 1°/ Quizz : qu'affiche ce programme ?
    // 2°/ Lancer le programme
    //     Afficher/Vérifier le résultat
    // 3°/ Poser un point d'arret sur la ligne do forearch
    //     Evaluer requeteLinq, et évaluer en debug les résultats.
    // 4°/ Vérifier le résultat affiché, et montrer que le résultat est différent de précédemment...

}
