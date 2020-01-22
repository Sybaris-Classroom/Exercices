using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonReader.Service;
using System.Linq;

namespace PeopleViewer.Presentation.Tests
{
    [TestClass]
    public class PeopleViewModelTests
    {
        private IRepository GetFakeRepository()
        {
            // TODO 6-4 : Instancer FakeRepository et le retourner. Cette instance de repository sera utiliser par les tests
            return new FakeRepository();
        }

        // TODO 6-5 : Exécuter les tests unitaires et vérifier qu'ils sont vert (Lire et comprendre le code des tests unitaires ci dessous...)
        [TestMethod]
        public void RefreshPeople_OnExecute_PeopleIsPopulated()
        {
            // Arrange
            var repository = GetFakeRepository();
            var vm = new PeopleViewModel(repository); // Constructor Injection of a Fake Repository

            // Act
            vm.RefreshPeople();

            // Assert
            Assert.IsNotNull(vm.People);
            Assert.AreEqual(2, vm.People.Count());
        }

        [TestMethod]
        public void ClearPeople_OnExecute_PeopleIsEmpty()
        {
            // Arrange
            var repository = GetFakeRepository();
            var vm = new PeopleViewModel(repository); // Constructor Injection of a Fake Repository
            vm.RefreshPeople();
            Assert.AreEqual(2, vm.People.Count(), "Invalid Arrangement");

            // Act
            vm.ClearPeople();

            // Assert
            Assert.AreEqual(0, vm.People.Count());
        }
    }
}
