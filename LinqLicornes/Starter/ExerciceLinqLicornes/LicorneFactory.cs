using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLinqLicornes
{
    public static class LicorneFactory
    {
        public static List<Licorne> InvocationLicornes()
        {
            var res = new List<Licorne>();
            var licorne1 = new Licorne() { Name = "Twilight Sparkle", Couleur = "Violet", Age = 10, ListePeronnalites = new List<string>() { "Studieuse", "Heroique" } };
            var licorne2 = new Licorne() { Name = "Rarity", Couleur = "Blanc", Age = 12, ListePeronnalites = new List<string>() { "Précieuse" } };
            var licorne3 = new Licorne() { Name = "Fluttershy", Couleur = "Jaune", Age = 10, ListePeronnalites = new List<string>() { "Timide", "Gentille" } };
            var licorne4 = new Licorne() { Name = "Pinkie Pie", Couleur = "Rose", Age = 11, ListePeronnalites = new List<string>() { "Gloutonne" } };
            var licorne5 = new Licorne() { Name = "Rainbow Dash", Couleur = "Bleu", Age = 11, ListePeronnalites = new List<string>() { "Rapide", "Moqueuse" } };
            var licorne6 = new Licorne() { Name = "AppleJack", Couleur = "Marron", Age = 15, ListePeronnalites = new List<string>() { "Forte", "Travailleuse" } };
            res.Add(licorne1);
            res.Add(licorne2);
            res.Add(licorne3);
            res.Add(licorne4);
            res.Add(licorne5);
            res.Add(licorne6);
            return res;
        }

        public static List<Animal> InvocationAnimaux()
        {
            var res = new List<Animal>();
            var animal = new Animal() { Name = "Herisson" };
            res.Add(animal);
            res.AddRange(InvocationLicornes().Skip(1));
            animal = new Animal() { Name = "Chat" };
            res.Add(animal);
            return res;
        }

        public static List<Jouet> CreerDesJouets()
        {
            var res = new List<Jouet>();
            res.Add(new Jouet() { NomJouet = "Velo", NomProprietaire = "Rainbow Dash" });
            res.Add(new Jouet() { NomJouet = "Livre", NomProprietaire = "Twilight Sparkle" });
            res.Add(new Jouet() { NomJouet = "Doudou", NomProprietaire = "Fluttershy" });
            res.Add(new Jouet() { NomJouet = "Bonbon", NomProprietaire = "Pinkie Pie" });
            res.Add(new Jouet() { NomJouet = "Gateau", NomProprietaire = "Pinkie Pie" });
            res.Add(new Jouet() { NomJouet = "Chocolat", NomProprietaire = "Pinkie Pie" });
            res.Add(new Jouet() { NomJouet = "Pelle", NomProprietaire = "AppleJack" });
            res.Add(new Jouet() { NomJouet = "Collier", NomProprietaire = "Rarity" });
            res.Add(new Jouet() { NomJouet = "Bracelet", NomProprietaire = "Rarity" });
            res.Add(new Jouet() { NomJouet = "Bottes", NomProprietaire = "AppleJack" });
            return res;
        }

        //public static List<double> 
    }
}
