using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POO.UnitTests
{

    [TestClass]
    public class TestVehiculeAMoteur
    {

        private Type GetVehiculeAMoteurType()
        {
            var result = UtilsHelper.GetClassType(typeof(FrmVehicule).Assembly, "VehiculeAMoteur");
            result.Should().NotBeNull("La classe VehiculeAMoteur n'existe pas");
            return result;
        }

        [TestMethod]
        public void TestClassExists()
        {
            // Assert
            UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "VehiculeAMoteur").Should().BeTrue("La classe n'existe pas");
            // Idem que
            //Assert.IsTrue(UtilsHelper.ClassExists(typeof(FrmVehicule).Assembly, "VehiculeAMoteur"));
        }

        [TestMethod]
        public void TestClassBaseType()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            // Assert
            type.BaseType.Should().Be((typeof(object)), "La classe VehiculeAMoteur doit hériter directement de la classe object");
        }

        [TestMethod]
        public void TestPropertyDistance()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var propertyInfo = type.GetProperty("Distance");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée Distance non trouvé sur le classe VehiculeAMoteur");
            propertyInfo.PropertyType.Should().Be(typeof(int), "La propriétée Distance doit être de type int");
        }

        [TestMethod]
        public void TestPropertyVitesseMaxi()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var propertyInfo = type.GetProperty("VitesseMaxi");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée VitesseMaxi non trouvé sur le classe VehiculeAMoteur");
            propertyInfo.PropertyType.Should().Be(typeof(float), "La propriétée VitesseMaxi doit être de type float");
        }

        [TestMethod]
        public void TestPropertyVitesseMini()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var propertyInfo = type.GetProperty("VitesseMini");
            // Assert
            propertyInfo.Should().NotBeNull(because: "Propriétée VitesseMini non trouvé sur le classe VehiculeAMoteur");
            propertyInfo.PropertyType.Should().Be(typeof(float), "La propriétée VitesseMini doit être de type float");
        }

        [TestMethod]
        public void TestPropertyDistanceException()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var propertyInfo = type.GetProperty("Distance");
            var vehiculeAMoteur = Activator.CreateInstance(type,true);
            // Act
            Action actNegatif = (() => propertyInfo.SetValue(vehiculeAMoteur, -1));
            Action actExageree = (() => propertyInfo.SetValue(vehiculeAMoteur, 10000));
            // Assert
            actNegatif.Should().Throw<Exception>("Une valeur négative de Distance ne doit pas être acceptée");
            actExageree.Should().Throw<Exception>("Une valeur exagérée (>2000) de Distance ne doit pas être acceptée");
        }

        [TestMethod]
        public void TestPropertyDistanceSetOk()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var propertyInfo = type.GetProperty("Distance");
            var vehiculeAMoteur = Activator.CreateInstance(type, true);
            const int DATA_DISTANCE_VALIDE = 500;
            // Act
            propertyInfo.SetValue(vehiculeAMoteur, DATA_DISTANCE_VALIDE);
            // Assert
            int distance = (int)propertyInfo.GetValue(vehiculeAMoteur);
            distance.Should().Be(DATA_DISTANCE_VALIDE, "La valeur Distance est invalide");
        }

        [TestMethod]
        public void TestValeurParDefaut()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var vehiculeAMoteur = Activator.CreateInstance(type, true);
            var propertyInfoDistance = type.GetProperty("Distance");
            var propertyInfoVitesseMaxi = type.GetProperty("VitesseMaxi");
            var propertyInfoVitesseMini = type.GetProperty("VitesseMini");
            // Act
            int distance = (int)propertyInfoDistance.GetValue(vehiculeAMoteur);
            float vistesseMaxi = (float)propertyInfoVitesseMaxi.GetValue(vehiculeAMoteur);
            float vistesseMini = (float)propertyInfoVitesseMini.GetValue(vehiculeAMoteur);
            // Assert
            distance.Should().Be(1000, "La valeur par défaut de distance doit être de 1000");
            vistesseMaxi.Should().Be(180.0f, "La valeur par défaut de VitesseMaxi doit être de 180");
            vistesseMini.Should().Be(90.0f, "La valeur par défaut de VitesseMini doit être de 90");
        }

        [TestMethod]
        public void Test2Constructeurs()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var constructors = type.GetConstructors(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
            // Assert
            constructors.Count().Should().Be(2, "Cette classe doit avoir 2 constructeurs");
        }

        [TestMethod]
        public void TestConstructeurAvecParametres()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var constructors = type.GetConstructors(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
            Type[] types = new Type[3] { typeof(int), typeof(float), typeof(float) };
            var constructorWithParams = type.GetConstructor(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public, null, types, null);
            var propertyInfoDistance = type.GetProperty("Distance");
            var propertyInfoVitesseMaxi = type.GetProperty("VitesseMaxi");
            var propertyInfoVitesseMini = type.GetProperty("VitesseMini");
            const int DATA_DISTANCE = 123;
            const float DATA_VITESSE_MAXI = 789.0f;
            const float DATA_VITESSE_MINI = 456.0f;
            // Act
            var parameters = new object[3] { DATA_DISTANCE, DATA_VITESSE_MAXI, DATA_VITESSE_MINI };
            var vehiculeAMoteur = constructorWithParams.Invoke(parameters);
            int distance = (int)propertyInfoDistance.GetValue(vehiculeAMoteur);
            float vistesseMaxi = (float)propertyInfoVitesseMaxi.GetValue(vehiculeAMoteur);
            float vistesseMini = (float)propertyInfoVitesseMini.GetValue(vehiculeAMoteur);
            // Assert
            constructorWithParams.Should().NotBeNull("Cette classe doit avoir un constructeur paramétré");
            distance.Should().Be(DATA_DISTANCE, "Le constructeur paramétré doit fixer la valeur de la propriété Distance");
            vistesseMaxi.Should().Be(DATA_VITESSE_MAXI, "Le constructeur paramétré doit fixer la valeur de la propriété VitesseMaxi");
            vistesseMini.Should().Be(DATA_VITESSE_MINI, "Le constructeur paramétré doit fixer la valeur de la propriété VitesseMini");
        }

        [TestMethod]
        public void TestConstructeurSansParametres()
        {
            // Arrange
            var type = GetVehiculeAMoteurType();
            var constructor = type.GetConstructor(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public, null, new Type[0] { }, null);
            // Act
            var vehiculeAMoteur = constructor.Invoke(null);
            // Assert
            vehiculeAMoteur.Should().NotBeNull();
        }

    }
}
