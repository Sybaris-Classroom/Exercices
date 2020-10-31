using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POO.UnitTests
{

    [TestClass]
    public class TestCamion
    {

        private Type GetCamionType()
        {
            var result = UtilsHelper.GetClassType(typeof(FrmVehicule).Assembly, "Camion");
            result.Should().NotBeNull("La classe Camion n'existe pas");
            return result;
        }

        [TestMethod]
        public void TestClassExists()
        {
            // Assert
            UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "Camion").Should().BeTrue("La classe n'existe pas");
            // Idem que
            //Assert.IsTrue(UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "Camion"));
        }

        [TestMethod]
        public void TestClassBaseType()
        {
            // Arrange
            var type = GetCamionType();
            // Assert
            type.BaseType.Name.Should().Be("VehiculeRoulant", "La classe Camion doit hériter directement de la classe VehiculeRoulant");
        }

        [TestMethod]
        public void TestPropertyTIR()
        {
            // Arrange
            var type = GetCamionType();
            var propertyInfo = type.GetProperty("TIR");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée TIR non trouvé sur le classe Camion");
            propertyInfo.PropertyType.Should().Be(typeof(bool), "La propriétée TIR doit être de type bool");
        }

        [TestMethod]
        public void TestValeurParDefaut()
        {
            // Arrange
            var type = GetCamionType();
            var camion = Activator.CreateInstance(type, true);
            var propertyInfoTir = type.GetProperty("TIR");
            var propertyInfoVitesseMaxi = type.GetProperty("VitesseMaxi");
            // Act
            bool tir = (bool)propertyInfoTir.GetValue(camion);
            var vitesseMaxi = (float)propertyInfoVitesseMaxi.GetValue(camion);
            // Assert
            tir.Should().Be(false, "La valeur par défaut de TIR doit être de false");
            const float CAMION_VITESSE_MAXI = 110.0f;
            vitesseMaxi.Should().Be(CAMION_VITESSE_MAXI, "La valeur par défaut de VitesseMaxi pour les camions incorrecte");
        }

        [TestMethod]
        public void TestConstructeurSansParametres()
        {
            // Arrange
            var type = GetCamionType();
            var constructor = type.GetConstructor(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public, null, new Type[0] { }, null);
            var propertyInfoTIR = type.GetProperty("TIR");
            // Act
            var camion = constructor.Invoke(null);
            // Assert
            camion.Should().NotBeNull("La classe camion doit avoir un constructeur sans parametre");
            bool TIR = (bool)propertyInfoTIR.GetValue(camion);
            TIR.Should().BeFalse("La valeur par défaut de la propriété TIR doit être false");
        }

        [TestMethod]
        public void Test1Constructeur()
        {
            // Arrange
            var type = GetCamionType();
            var constructors = type.GetConstructors(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
            // Assert
            constructors.Count().Should().Be(1, "Cette classe doit avoir 1 seul constructeur");
        }

        [TestMethod]
        public void TestMethodeConsommation()
        {
            // Arrange
            var type = GetCamionType();
            var methodConsommation = type.GetMethod("Consommation");
            var voiture = Activator.CreateInstance(type, true);
            var propertyInfoDistance = type.GetProperty("Distance");
            var propertyInfoCharge = type.GetProperty("Charge");
            const int DATA_DISTANCE_VALIDE = 500;
            const int DATA_CHARGE_VALIDE = 3000;
            propertyInfoDistance.SetValue(voiture, DATA_DISTANCE_VALIDE);
            propertyInfoCharge.SetValue(voiture, DATA_CHARGE_VALIDE);
            // Act
            var result = (float)methodConsommation.Invoke(voiture, null);
            // Assert
            const float EXPECTED_RESULT = 75.0f; //(12 + DATA_CHARGE_VALIDE / 1000) * DATA_DISTANCE_VALIDE / 100;
            result.Should().Be(EXPECTED_RESULT, "La valeur retournée par la méthode Consommation de la classe Moto est incorrecte");
        }
    }
}
