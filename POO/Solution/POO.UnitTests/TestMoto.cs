using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POO.UnitTests
{

    [TestClass]
    public class TestMoto
    {

        private Type GetMotoType()
        {
            var result = UtilsHelper.GetClassType(typeof(FrmVehicule).Assembly, "Moto");
            result.Should().NotBeNull("La classe Moto n'existe pas");
            return result;
        }

        [TestMethod]
        public void TestClassExists()
        {
            // Assert
            UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "Moto").Should().BeTrue("La classe n'existe pas");
            // Idem que
            //Assert.IsTrue(UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "Moto"));
        }

        [TestMethod]
        public void TestClassBaseType()
        {
            // Arrange
            var type = GetMotoType();
            // Assert
            type.BaseType.Name.Should().Be("VehiculeRoulant", "La classe Moto doit hériter directement de la classe VehiculeRoulant");
        }

        [TestMethod]
        public void TestPropertyCross()
        {
            // Arrange
            var type = GetMotoType();
            var propertyInfo = type.GetProperty("Cross");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée Cross non trouvé sur le classe Moto");
            propertyInfo.PropertyType.Should().Be(typeof(bool), "La propriétée Cross doit être de type bool");
        }

        [TestMethod]
        public void TestValeurParDefaut()
        {
            // Arrange
            var type = GetMotoType();
            var moto = Activator.CreateInstance(type, true);
            var propertyInfoDistance = type.GetProperty("Cross");
            // Act
            bool distance = (bool)propertyInfoDistance.GetValue(moto);
            // Assert
            distance.Should().Be(false, "La valeur par défaut de Cross doit être de false");
        }


        [TestMethod]
        public void TestValeurParDefautDeLaClasseVehiculeRoulant()
        {
            // Il n'est pas possible d'instancier une classe abstraite.
            // Du coup les tests des valeurs par défaut seront fait par la classe Moto
            //// Arrange
            var type = GetMotoType();
            var moto = Activator.CreateInstance(type, true);
            var propertyInfoDistance = type.GetProperty("Distance");
            var propertyInfoVitesseMaxi = type.GetProperty("VitesseMaxi");
            var propertyInfoVitesseMini = type.GetProperty("VitesseMini");
            var propertyInfoPassagers = type.GetProperty("Passagers");
            var propertyInfoCharge = type.GetProperty("Charge");
            // Act
            int distance = (int)propertyInfoDistance.GetValue(moto);
            float vistesseMaxi = (float)propertyInfoVitesseMaxi.GetValue(moto);
            float vistesseMini = (float)propertyInfoVitesseMini.GetValue(moto);
            int passagers = (int)propertyInfoPassagers.GetValue(moto);
            int charge = (int)propertyInfoCharge.GetValue(moto);
            // Assert
            distance.Should().Be(1000, "La valeur par défaut de distance doit être de 1000");
            vistesseMaxi.Should().Be(180.0f, "La valeur par défaut de VitesseMaxi doit être de 180");
            vistesseMini.Should().Be(90.0f, "La valeur par défaut de VitesseMini doit être de 90");
            passagers.Should().Be(4, "La valeur par défaut de Passagers doit être de 4");
            charge.Should().Be(0, "La valeur par défaut de Charge doit être de 0 car elle ne doit pas être initialisée");
        }

        [TestMethod]
        public void TestMethodeConsommation()
        {
            // Arrange
            var type = GetMotoType();
            var methodConsommation = type.GetMethod("Consommation");
            var moto = Activator.CreateInstance(type, true);
            var propertyInfoDistance = type.GetProperty("Distance");
            const int DATA_DISTANCE_VALIDE = 500;
            propertyInfoDistance.SetValue(moto, DATA_DISTANCE_VALIDE);
            // Act
            var result = (float)methodConsommation.Invoke(moto, null);
            // Assert
            float EXPECTED_RESULT = 15.0f; //3* DATA_DISTANCE_VALIDE/100
            result.Should().Be(EXPECTED_RESULT, "La valeur retournée par la méthode Consommation de la classe Moto est incorrecte");
        }
    }
}
