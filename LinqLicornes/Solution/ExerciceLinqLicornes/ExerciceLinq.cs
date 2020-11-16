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
            return ListeLicorne.Select(l => l.Name);
        }

        /// <summary>
        /// Retrouver la liste des licorne parmi les animaux
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> TrouverLesLicornesParmiLesAnimaux()
        {
            return ListeAnimaux.OfType<Licorne>();
        }

        /// <summary>
        /// Transformer la liste de licorne en liste d'animaux
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Animal> LesLicornesSontDesAnimaux()
        {
            return ListeLicorne.Cast<Animal>();
        }

        /// <summary>
        /// Retourner la liste des animaux sans ceux qui font partie de la liste des licorne
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Animal> LesAnimauxQuiNontPasLaChanceDEtreDesLicornes()
        {
            return ListeAnimaux.Except(ListeLicorne);
        }

        /// <summary>
        /// Retourner la liste des licornes triees par age
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> LicorneLesPlusJeuneDabord()
        {
            return ListeLicorne.OrderBy<Licorne, int>(l => l.Age);
        }

        /// <summary>
        /// Retourner la liste des licornes triees par age puis en cas d'égalité par nom
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> LicorneLesPlusJeuneDabordMaislesAAussi()
        {
            return ListeLicorne.OrderBy<Licorne, int>(l => l.Age).ThenBy(l => l.Name);
        }

        /// <summary>
        /// Retourner la liste des licornes qui ont 10 ans
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> CeuxQuiOnt10ansLevezLaMain()
        {
            return ListeLicorne.Where(l => l.Age == 10);
        }

        /// <summary>
        /// Retourner la liste de l'ensemble des caratères (personnalitées) de licorne
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> LesLicornesOntDuCaractere()
        {
            return ListeLicorne.SelectMany(l => l.ListePeronnalites);
        }

        /// <summary>
        /// Retourner le nombre de licorne pour chaque age
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<int, int>> PyramideDesAgesDesLicornes()
        {
            return ListeLicorne.GroupBy(l => l.Age, (x, y) => new Tuple<int, int>(x, y.Count()));
        }

        /// <summary>
        /// Retourner un dictionnaire qui associe à chaque age la ou les licornes associées
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, List<Licorne>> QuelleLicorneAMonAge()
        {
            return ListeLicorne.GroupBy(l => l.Age).ToDictionary(x => x.Key, x => x.ToList());
        }

        /// <summary>
        /// Retourner un lookup qui associe à chaque age la ou les licornes associées
        /// </summary>
        /// <returns></returns>
        public ILookup<int,Licorne> QuelleLicorneAMonAgeLookup()
        {
            return ListeLicorne.ToLookup(l => l.Age);
        }

        /// <summary>
        /// Retourner pour chaque licorne sa liste de jouet
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<Licorne, List<Jouet>>> AChacunSonJouet()
        {
            return ListeLicorne.Select(l => new Tuple<Licorne, List<Jouet>>(l, ListeJouet.Where(j => j.NomProprietaire == l.Name).ToList()));
        }

        /// <summary>
        /// Créer une licorne qui a la couleur de toutes concatennées ainsi que l'ensemble de leurs personnalités
        /// </summary>
        ///  <remarks>On peut utiliser la méthode Licorne.Fusion</remarks>
        /// <returns></returns>
        public Licorne MegaLicorne()
        {
            return ListeLicorne.Aggregate((l1, l2) => Licorne.Fusiiioooon(l1, l2));
            
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
            return ListeLicorne.Take(3).Zip(ListeLicorne.Skip(3), (l1,l2) => Licorne.FaireUnBebe(l1,l2));
        }
    }
}
