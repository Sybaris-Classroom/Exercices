using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace PersonReader.CSV.Tests
{
    [TestClass]
    public class CSVReaderTests
    {
        // TODO 7-3 : Décommenter toutes les lignes de ce fichier avec le commentaire Property Injection.
        //            Explication : la classe CSVReader a un comportement par défaut qui est de charger un fichier (C.F. propriété FileLoader & constructeur de CSVReader)
        //                          mais ce comportement peut être surchargé et remplacé en fournissant un nouveau ICSVFileLoader avec le comportement voulu
        // TODO 7-4 : Exécuter les tests unitaires et vérifier qu'ils sont vert.

        [TestMethod]
        public void GetPeople_WithEmptyFile_ReturnsEmptyList()
        {
            var repository = new CSVReader();

            repository.FileLoader = new FakeFileLoader("Empty"); //Property Injection

            var result = repository.GetPeople();

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void GetPeople_WithGoodRecords_ReturnsGoodRecords()
        {
            var repository = new CSVReader();
            repository.FileLoader = new FakeFileLoader("Good"); //Property Injection

            var result = repository.GetPeople();

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetPeople_WithBadRecords_ReturnsGoodRecords()
        {
            var repository = new CSVReader();
            repository.FileLoader = new FakeFileLoader("Mixed");//Property Injection

            var result = repository.GetPeople();

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetPeople_WithOnlyBadRecord_ReturnsEmptyList()
        {
            var repository = new CSVReader();
            repository.FileLoader = new FakeFileLoader("Bad");//Property Injection

            var result = repository.GetPeople();

            Assert.AreEqual(0, result.Count());
        }
    }
}
