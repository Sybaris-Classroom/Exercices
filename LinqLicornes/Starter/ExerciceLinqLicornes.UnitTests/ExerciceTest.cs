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
            var expected = Exercice.ListeLicorne.Select(x => x.Name);
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void TrouverLesLicornesParmiLesAnimaux()
        {
            var res = Exercice.TrouverLesLicornesParmiLesAnimaux();
            var expected = Exercice.ListeAnimaux.OfType<Licorne>();
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LesLicornesSontDesAnimaux()
        {
            IEnumerable<Animal> res = Exercice.LesLicornesSontDesAnimaux();
            var expected = Exercice.ListeLicorne;
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LesAnimauxQuiNontPasLaChanceDEtreDesLicornes()
        {
            IEnumerable<Animal> res = Exercice.LesAnimauxQuiNontPasLaChanceDEtreDesLicornes();
            var expected = Exercice.ListeAnimaux.Except(Exercice.ListeLicorne);
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LicorneLesPlusJeuneDabord()
        {
            IEnumerable<Animal> res = Exercice.LicorneLesPlusJeuneDabord();
            var expected = Exercice.ListeLicorne.OrderBy(x => x.Age);
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LicorneLesPlusJeuneDabordMaislesAAussi()
        {
            IEnumerable<Animal> res = Exercice.LicorneLesPlusJeuneDabordMaislesAAussi();
            var expected = Exercice.ListeLicorne.OrderBy(x => x.Age).ThenBy(x=>x.Name);
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void CeuxQuiOnt10ansLevezLaMain()
        {
            var res = Exercice.CeuxQuiOnt10ansLevezLaMain();
            var expected = Exercice.ListeLicorne.Where(x => x.Age == 10);
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Débutant")]
        public void LesLicornesOntDuCaractere()
        {
            var res = Exercice.LesLicornesOntDuCaractere();
            var expected = Exercice.ListeLicorne.SelectMany(x => x.ListePeronnalites);
            Assert.IsTrue(res.SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void PyramideDesAgesDesLicornes()
        {
            var res = Exercice.PyramideDesAgesDesLicornes();
            var expected = Exercice.ListeLicorne.GroupBy(x => x.Age, (x, y) => new Tuple<int, int>(x, y.Count()));
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Item1 == b.Item1 && a.Item2 == b.Item2).All(x => x));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void QuelleLicorneAMonAge()
        {
            var res = Exercice.QuelleLicorneAMonAge();
            var expected = Exercice.ListeLicorne.GroupBy(x => x.Age).ToDictionary(x => x.Key, x => x.ToList());
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Key == b.Key && a.Value.SequenceEqual(b.Value)).All(x => x));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void QuelleLicorneAMonAgeLookup()
        {
            var res = Exercice.QuelleLicorneAMonAgeLookup();
            var expected = Exercice.ListeLicorne.ToLookup(x => x.Age);
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Key == b.Key && a.SequenceEqual(b)).All(x => x));
        }

        [TestMethod]
        [TestCategory("Moyen")]
        public void AChacunSonJouet()
        {
            var res = Exercice.AChacunSonJouet();
            var expected = Exercice.ListeLicorne.GroupJoin(Exercice.ListeJouet, x => x.Name, y => y.NomProprietaire, (x, y) => new Tuple<Licorne, List<Jouet>>(x, y.ToList()));
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Zip(expected, (a, b) => a.Item1 == b.Item1 && a.Item2.SequenceEqual(b.Item2)).All(x => x));
        }

        [TestMethod]
        [TestCategory("Un peu avancé")]
        public void MegaLicorne()
        {
            var res = Exercice.MegaLicorne();
            var expected = Exercice.ListeLicorne.Aggregate((l1, l2) => Licorne.Fusiiioooon(l1, l2));
            Assert.IsTrue(res.Couleur == expected.Couleur);
            Assert.IsTrue(res.ListePeronnalites.SequenceEqual(expected.ListePeronnalites));
        }

        [TestMethod]
        [TestCategory("Un peu plus avancé")]
        public void DesBebesLicornes()
        {
            var res = Exercice.DesBebesLicornes();
            var expected = Exercice.ListeLicorne.Take(3).Zip(Exercice.ListeLicorne.Skip(3), (l1, l2) => Licorne.FaireUnBebe(l1,l2));
            Assert.IsTrue(res.Count() == expected.Count());
            Assert.IsTrue(res.Select(x=>x.Couleur).SequenceEqual(expected.Select(x=>x.Couleur)));
        }

       
    }
}
