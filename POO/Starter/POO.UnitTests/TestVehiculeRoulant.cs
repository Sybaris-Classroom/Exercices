using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POO.UnitTests
{

    [TestClass]
    public class TestVehiculeRoulant
    {
        private Type GetVehiculeRoulantType()
        {
            var result = UtilsHelper.GetClassType(typeof(FrmVehicule).Assembly, "VehiculeRoulant");
            result.Should().NotBeNull("La classe VehiculeRoulant n'existe pas");
            return result;
        }

        [TestMethod]
        public void TestClassExists()
        {
            // Assert
            UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "VehiculeRoulant").Should().BeTrue("La classe n'existe pas");
        }

        [TestMethod]
        public void TestClassBaseType()
        {
            // Arrange
            var type = GetVehiculeRoulantType();
            // Assert
            type.BaseType.Name.Should().Be("VehiculeAMoteur", "La classe VehiculeRoulant doit hériter directement de la classe VehiculeAMoteur");
        }

        [TestMethod]
        public void TestPropertyPassagers()
        {
            // Arrange
            var type = GetVehiculeRoulantType();
            var propertyInfo = type.GetProperty("Passagers");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée Passagers non trouvé sur le classe VehiculeRoulant");
            propertyInfo.PropertyType.Should().Be(typeof(int), "La propriétée Passagers doit être de type int");
        }

        [TestMethod]
        public void TestPropertyCharge()
        {
            // Arrange
            var type = GetVehiculeRoulantType();
            var propertyInfo = type.GetProperty("Charge");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée Charge non trouvé sur le classe VehiculeRoulant");
            propertyInfo.PropertyType.Should().Be(typeof(int), "La propriétée VitesseMaxi doit être de type int");
        }

        [TestMethod]
        public void TestClasseAbstraite()
        {
            // Arrange
            var type = GetVehiculeRoulantType();
            // Assert
            type.IsAbstract.Should().Be(true, "La classe VehiculeRoulant doit être abstraite");
        }

        //[TestMethod]
        //public void TestValeurParDefaut()
        //{
        //    // Il n'est pas possible d'instancier une classe abstraite.
        //    // Du coup les tests des valeurs par défaut sont fait par la classe Moto
        //}


        [TestMethod]
        public void TestMethodeConsommation()
        {
            // Arrange
            var type = GetVehiculeRoulantType();
            var methodConsommation = type.GetMethod("Consommation");
            // Assert
            methodConsommation.Should().NotBeNull("La classe VehiculeRoulant doit posséder une méthode Consommation");
            methodConsommation.IsAbstract.Should().BeTrue("La méthode Consommation de la classe VehiculeRoulant doit être abstraite");
        }
    }
}
