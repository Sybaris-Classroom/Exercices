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
            // TODO : Le but de cet exercice est de coder (implémenter) chaque méthodes de cette classe afin que les tests unitaires passent au vert.
            // Pour cela, dans chaque méthode de cette classe, il faut écrire 1 requete Linq qui retourne ce qui est demandé dans la documentation de la méthode (C.F. summary).
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrouver la liste des licorne parmi les animaux
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> TrouverLesLicornesParmiLesAnimaux()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Transformer la liste de licorne en liste d'animaux
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Animal> LesLicornesSontDesAnimaux()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner la liste des animaux sans ceux qui font partie de la liste des licorne
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Animal> LesAnimauxQuiNontPasLaChanceDEtreDesLicornes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner la liste des licornes triees par age
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> LicorneLesPlusJeuneDabord()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner la liste des licornes triees par age puis en cas d'égalité par nom
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> LicorneLesPlusJeuneDabordPuisParOrdreAlphabetiqueDuNom()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner la liste des licornes qui ont 10 ans
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Licorne> CeuxQuiOnt10ansLevezLaMain()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner la liste de l'ensemble des caratères (personnalitées) de licorne
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> LesLicornesOntDuCaractere()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner le nombre de licorne pour chaque age
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<int, int>> PyramideDesAgesDesLicornes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner un dictionnaire qui associe à chaque age la ou les licornes associées
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, List<Licorne>> QuelleLicorneAMonAge()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner un lookup qui associe à chaque age la ou les licornes associées
        /// </summary>
        /// <returns></returns>
        public ILookup<int,Licorne> QuelleLicorneAMonAgeLookup()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourner pour chaque licorne sa liste de jouet
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<Licorne, List<Jouet>>> AChacunSonJouet()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Créer une licorne qui a la couleur de toutes concatennées ainsi que l'ensemble de leurs personnalités
        /// </summary>
        ///  <remarks>On peut utiliser la méthode Licorne.Fusion</remarks>
        /// <returns></returns>
        public Licorne MegaLicorne()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
