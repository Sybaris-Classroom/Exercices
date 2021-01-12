using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLinqLicornes
{
    public class ExerciceLinq
    {
        public List<Licorne> ListeLicorne { get; set; }
        public List<Animal> ListeAnimaux { get; set; }
        public List<Jouet> ListeJouet { get; set; }

        public ExerciceLinq()
        {
            ListeLicorne = LicorneFactory.InvocationLicornes();
            ListeAnimaux = LicorneFactory.InvocationAnimaux();
            ListeJouet = LicorneFactory.CreerDesJouets();
        }

        /// <summary>
        /// Retourne les noms de la liste de licorne
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetNomLicorne()
        {
            // Version méthode d'extension
            return ListeLicorne.Select(l => l.Name);
            // Version déclarative
            //return from licorne in ListeLicorne
            //       select licorne.Name;
        }

        /// <summary>
        /// Retrouver la liste des licorne parmi les animaux
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> TrouverLesLicornesParmiLesAnimaux()
        {
            // Version méthode d'extension
            return ListeAnimaux.OfType<Licorne>();
            // Version déclarative
            //return from animal in ListeAnimaux
            //       where animal is Licorne
            //       select animal as Licorne;
        }

        /// <summary>
        /// Transformer la liste de licorne en liste d'animaux
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Animal> LesLicornesSontDesAnimaux()
        {
            // Version méthode d'extension
            return ListeLicorne.Cast<Animal>();
            // Pas de version déclarative...
        }

        /// <summary>
        /// Retourner la liste des animaux sans ceux qui font partie de la liste des licorne
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Animal> LesAnimauxQuiNontPasLaChanceDEtreDesLicornes()
        {
            // Version méthode d'extension
            return ListeAnimaux.Except(ListeLicorne);
            // Pas de version déclarative...
        }

        /// <summary>
        /// Retourner la liste des licornes triees par age
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> LicorneLesPlusJeuneDabord()
        {
            // Version méthode d'extension
            return ListeLicorne.OrderBy(l => l.Age);
            // Version déclarative
            //return from licorne in ListeLicorne
            //       orderby licorne.Age
            //       select licorne;
        }

        /// <summary>
        /// Retourner la liste des licornes triees par age puis en cas d'égalité par nom
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> LicorneLesPlusJeuneDabordPuisParOrdreAlphabetiqueDuNom()
        {
            // Version méthode d'extension
            return ListeLicorne.OrderBy(l => l.Age).ThenBy(l => l.Name);
            // Version déclarative
            //return from licorne in ListeLicorne
            //       orderby licorne.Age, licorne.Name
            //       select licorne;
        }

        /// <summary>
        /// Retourner la liste des licornes qui ont 10 ans
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> CeuxQuiOnt10ansLevezLaMain()
        {
            // Version méthode d'extension
            return ListeLicorne.Where(l => l.Age == 10);
            // Version déclarative
            //return from licorne in ListeLicorne
            //       where licorne.Age == 10
            //       select licorne;
        }

        /// <summary>
        /// Retourner la liste de l'ensemble des caratères (personnalitées) de licorne
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> LesLicornesOntDuCaractere()
        {
            // Version méthode d'extension
            return ListeLicorne.SelectMany(l => l.ListePersonnalites);
            // Pas de version déclarative...
        }

        /// <summary>
        /// Retourner le nombre de licorne pour chaque age
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<int, int>> PyramideDesAgesDesLicornes()
        {
            // Version méthode d'extension
            return ListeLicorne.GroupBy(l => l.Age, (x, y) => new Tuple<int, int>(x, y.Count()));
            // Version déclarative
            //return from licorne in ListeLicorne
            //       group licorne by licorne.Age into newGroup
            //       select new Tuple<int, int>(newGroup.Key, newGroup.Count());
        }

        /// <summary>
        /// Retourner un dictionnaire qui associe à chaque age la ou les licornes associées
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, List<Licorne>> QuelleLicorneAMonAge()
        {
            // Version méthode d'extension
            return ListeLicorne.GroupBy(l => l.Age).ToDictionary(x => x.Key, x => x.ToList());
            // Version déclarative
            //return (from licorne in ListeLicorne
            //        group licorne by licorne.Age into newGroup
            //        select newGroup).ToDictionary(x => x.Key, x => x.ToList());
        }

        /// <summary>
        /// Retourner un lookup qui associe à chaque age la ou les licornes associées
        /// </summary>
        /// <returns></returns>
        public ILookup<int, Licorne> QuelleLicorneAMonAgeLookup()
        {
            // Version méthode d'extension
            return ListeLicorne.ToLookup(l => l.Age);
            // Pas de version déclarative...
        }

        /// <summary>
        /// Retourner pour chaque licorne sa liste de jouet
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<Licorne, List<Jouet>>> AChacunSonJouet()
        {
            // Version méthode d'extension
            return ListeLicorne.Select(l => new Tuple<Licorne, List<Jouet>>(l, ListeJouet.Where(j => j.NomProprietaire == l.Name).ToList()));
            // Version déclarative
            //return from licorne in ListeLicorne
            //       join jouet in ListeJouet on licorne.Name equals jouet.NomProprietaire into jouetsDeLaLicorne
            //       select new Tuple<Licorne, List<Jouet>>(licorne, jouetsDeLaLicorne.ToList());
        }

        /// <summary>
        /// Créer une licorne qui a la couleur de toutes concatennées ainsi que l'ensemble de leurs personnalités
        /// </summary>
        ///  <remarks>On peut utiliser la méthode Licorne.Fusion</remarks>
        /// <returns></returns>
        public Licorne MegaLicorne()
        {
            // Version méthode d'extension
            return ListeLicorne.Aggregate((l1, l2) => Licorne.Fusiiioooon(l1, l2));
            // Pas de version déclarative...
        }

        /// <summary>
        /// Les 3 premières licornes ont des bébés avec les 3 suivantes
        /// Et leur enfant a la couleur accolée des deux
        /// Exemple Licorne1 ("Bleu") a un enfant avec Licorne4 ("Rose")
        /// L'enfant doit être de couleur "BleuRose"
        /// </summary>
        /// <remarks>On peut utiliser la méthode Licorne.FaireUnBebe</remarks>
        public IEnumerable<Licorne> DesBebesLicornes()
        {
            // Version méthode d'extension
            return ListeLicorne.Take(3).Zip(ListeLicorne.Skip(3), (l1, l2) => Licorne.FaireUnBebe(l1, l2));
            // Pas de version déclarative...
        }
    }
}
