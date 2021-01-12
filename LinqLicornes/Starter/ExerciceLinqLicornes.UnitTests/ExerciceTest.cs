using ExerciceLinqLicornes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciceLinqLicornes.UnitTests
{
    [TestClass]
    public class ExerciceTest
    {
        public ExerciceLinq Exercice { get; set; }
        [TestInitialize]
        public void Init()
        {
            Exercice = new ExerciceLinq();
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void GetNomLicorne()
        {
            var res = Exercice.GetNomLicorne();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.Select(x => x.Name);
            // Version déclarative
            //var expected = from licorne in Exercice.ListeLicorne
            //               select licorne.Name;
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void TrouverLesLicornesParmiLesAnimaux()
        {
            var res = Exercice.TrouverLesLicornesParmiLesAnimaux();
            // Version méthode d'extension
            var expected = Exercice.ListeAnimaux.OfType<Licorne>();
            // Version déclarative
            //var expected = from animal in Exercice.ListeAnimaux
            //               where animal is Licorne
            //               select animal;
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LesLicornesSontDesAnimaux()
        {
            IEnumerable<Animal> res = Exercice.LesLicornesSontDesAnimaux();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne;
            // Pas de version déclarative...
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LesAnimauxQuiNontPasLaChanceDEtreDesLicornes()
        {
            IEnumerable<Animal> res = Exercice.LesAnimauxQuiNontPasLaChanceDEtreDesLicornes();
            // Version méthode d'extension
            var expected = Exercice.ListeAnimaux.Except(Exercice.ListeLicorne);
            // Pas de version déclarative...
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LicorneLesPlusJeuneDabord()
        {
            IEnumerable<Animal> res = Exercice.LicorneLesPlusJeuneDabord();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.OrderBy(x => x.Age);
            // Version déclarative
            //var expected = from licorne in Exercice.ListeLicorne
            //               orderby licorne.Age
            //               select licorne;
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LicorneLesPlusJeuneDabordPuisParOrdreAlphabetiqueDuNom()
        {
            IEnumerable<Animal> res = Exercice.LicorneLesPlusJeuneDabordPuisParOrdreAlphabetiqueDuNom();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.OrderBy(x => x.Age).ThenBy(x => x.Name);
            // Version déclarative
            //var expected = from licorne in Exercice.ListeLicorne
            //               orderby licorne.Age, licorne.Name
            //               select licorne;
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void CeuxQuiOnt10ansLevezLaMain()
        {
            var res = Exercice.CeuxQuiOnt10ansLevezLaMain();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.Where(x => x.Age == 10);
            // Version déclarative
            //var expected = from licorne in Exercice.ListeLicorne
            //               where licorne.Age == 10
            //               select licorne;
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LesLicornesOntDuCaractere()
        {
            var res = Exercice.LesLicornesOntDuCaractere();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.SelectMany(x => x.ListePersonnalites);
            // Pas de version déclarative...
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void PyramideDesAgesDesLicornes()
        {
            var res = Exercice.PyramideDesAgesDesLicornes();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.GroupBy(x => x.Age, (x, y) => new Tuple<int, int>(x, y.Count()));
            // Version déclarative
            //var expected = from licorne in Exercice.ListeLicorne
            //               group licorne by licorne.Age into newGroup
            //               select new Tuple<int, int>(newGroup.Key, newGroup.Count());
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Item1 == b.Item1 && a.Item2 == b.Item2).All(x => x));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void QuelleLicorneAMonAge()
        {
            var res = Exercice.QuelleLicorneAMonAge();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.GroupBy(x => x.Age).ToDictionary(x => x.Key, x => x.ToList());
            // Version déclarative
            //var expected = (from licorne in Exercice.ListeLicorne
            //                group licorne by licorne.Age into newGroup
            //                select newGroup).ToDictionary(x => x.Key, x => x.ToList());
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Key == b.Key && a.Value.SequenceEqual(b.Value)).All(x => x));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void QuelleLicorneAMonAgeLookup()
        {
            var res = Exercice.QuelleLicorneAMonAgeLookup();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.ToLookup(x => x.Age);
            // Version déclarative
            //var expected = from licorne in Exercice.ListeLicorne
            //               group licorne by licorne.Age into newGroup
            //               select newGroup;
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Key == b.Key && a.SequenceEqual(b)).All(x => x));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void AChacunSonJouet()
        {
            var res = Exercice.AChacunSonJouet();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.GroupJoin(Exercice.ListeJouet, x => x.Name, y => y.NomProprietaire, (x, y) => new Tuple<Licorne, List<Jouet>>(x, y.ToList()));
            // Version déclarative
            //var expected = from licorne in Exercice.ListeLicorne
            //               join jouet in Exercice.ListeJouet on licorne.Name equals jouet.NomProprietaire into jouetsDeLaLicorne
            //               select new Tuple<Licorne, List<Jouet>>(licorne, jouetsDeLaLicorne.ToList());
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Item1 == b.Item1 && a.Item2.SequenceEqual(b.Item2)).All(x => x));
        }

        [TestMethod]
        [TestCategory("Un peu avancé")]
        public void MegaLicorne()
        {
            var res = Exercice.MegaLicorne();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.Aggregate((l1, l2) => Licorne.Fusiiioooon(l1, l2));
            // Pas de version déclarative...
            Assert.IsTrue(res.Couleur == expected.Couleur);
            Assert.IsTrue(res.ListePeronnalites.SequenceEqual(expected.ListePersonnalites));
        }

        [TestMethod]
        [TestCategory("Un peu plus avancé")]
        public void DesBebesLicornes()
        {
            var res = Exercice.DesBebesLicornes();
            // Version méthode d'extension
            var expected = Exercice.ListeLicorne.Take(3).Zip(Exercice.ListeLicorne.Skip(3), (l1, l2) => Licorne.FaireUnBebe(l1, l2));
            // Pas de version déclarative...
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Select(x => x.Couleur).SequenceEqual(expected.Select(x => x.Couleur)));
        }


    }
}

