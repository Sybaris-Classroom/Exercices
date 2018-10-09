using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public static class Collections
    {
        public static void Run()
        {
            // Les tableaux
            int[] tableau = new int[5]; // Taille fixée à la construction
            tableau[0] = 50; // Tableau indexé par 0
            //tableau[5] = 50; // Erreur au runtime (IndexOutOfRangeException)
            for (int i = 0; i < tableau.Length; i++)
                tableau[i] = i;
            // Autre type d'initialisation de tableau :
            int[] tableau2 = new int[5] { 2, 4, 6, 8, 10 };

            // ArrayList
            ArrayList arrayList = new ArrayList(); // Liste qui peut être non homogène
            arrayList.Add("Jean");
            arrayList.Add(50);
            arrayList.Add(true);
            Console.WriteLine("ArrayList");
            foreach (var item in arrayList)
                Console.WriteLine(item);

            // IEnumerable
            IEnumerable ie = arrayList;
            Console.WriteLine("IEnumerable avec ForEach");
            foreach (var item in ie)
                Console.WriteLine(item);

            Console.WriteLine("IEnumerable à la main");
            IEnumerator e = ie.GetEnumerator();
            while (e.MoveNext())
                Console.WriteLine(e.Current);

            // Liste generique
            List<string> liste = new List<string>();
            liste.Add("Pierre");
            liste.Add("Paul");
            liste.Add("Jacques");
            //liste.Add(1); erreur de compilation

            // Dictionnaires
            Dictionary<int, Personne> dico = new Dictionary<int, Personne>();
            dico.Add(1, new Personne() { Prenom = "Jean" });
            dico.Add(2, new Personne() { Prenom = "Pierre" });
            dico.Add(3, new Personne() { Prenom = "Pierre" });
            //dico.Add(1, new Personne() { Prenom = "Paul" }); // Erreur : Un argument avec la même clé a déjà été ajouté.
        }
    }
}
