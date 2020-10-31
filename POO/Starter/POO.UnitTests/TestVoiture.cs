using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POO.UnitTests
{

    [TestClass]
    public class TestVoiture
    {

        private Type GetVoitureType()
        {
            var result = UtilsHelper.GetClassType(typeof(FrmVehicule).Assembly, "Voiture");
            result.Should().NotBeNull("La classe Voiture n'existe pas");
            return result;
        }

        [TestMethod]
        public void TestClassExists()
        {
            // Assert
            UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "Voiture").Should().BeTrue("La classe n'existe pas");
            // Idem que
            //Assert.IsTrue(UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "Voiture"));
        }

        [TestMethod]
        public void TestClassBaseType()
        {
            // Arrange
            var type = GetVoitureType();
            // Assert
            type.BaseType.Name.Should().Be("VehiculeRoulant", "La classe Voiture doit hériter directement de la classe VehiculeRoulant");
        }

        [TestMethod]
        public void TestPropertyAirbag()
        {
            // Arrange
            var type = GetVoitureType();
            var propertyInfo = type.GetProperty("Airbag");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée Airbag non trouvé sur le classe Voiture");
            propertyInfo.PropertyType.Should().Be(typeof(bool), "La propriétée Airbag doit être de type bool");
        }

        [TestMethod]
        public void TestValeurParDefaut()
        {
            // Arrange
            var type = GetVoitureType();
            var Voiture = Activator.CreateInstance(type, true);
            var propertyInfoDistance = type.GetProperty("Airbag");
            // Act
            bool distance = (bool)propertyInfoDistance.GetValue(Voiture);
            // Assert
            distance.Should().Be(true, "La valeur par défaut de Airbag doit être de true");
        }

        [TestMethod]
        public void TestMethodeConsommation()
        {
            // Arrange
            var type = GetVoitureType();
            var methodConsommation = type.GetMethod("Consommation");
            var voiture = Activator.CreateInstance(type, true);
            var propertyInfoDistance = type.GetProperty("Distance");
            var propertyInfoPassagers = type.GetProperty("Passagers");
            const int DATA_DISTANCE_VALIDE = 500;
            const int DATA_PASSAGERS_VALIDE = 3;
            propertyInfoDistance.SetValue(voiture, DATA_DISTANCE_VALIDE);
            propertyInfoPassagers.SetValue(voiture, DATA_PASSAGERS_VALIDE);
            // Act
            var result = (float)methodConsommation.Invoke(voiture, null);
            // Assert
            const float EXPECTED_RESULT = 26.5f; //(5 + 0.1f * DATA_PASSAGERS_VALIDE) * DATA_DISTANCE_VALIDE / 100;
            result.Should().Be(EXPECTED_RESULT, "La valeur retournée par la méthode Consommation de la classe Moto est incorrecte");
        }
    }
}
