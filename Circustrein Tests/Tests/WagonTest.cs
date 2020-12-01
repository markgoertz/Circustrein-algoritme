using Circustrein_algoritme;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Circustrein_Tests.MockData;

namespace Circustrein_Tests.Tests
{
    [TestClass]
    public class WagonTest
    {
        public List<Animal> Animals = new List<Animal>();
        readonly Wagon wagon = new Wagon();

        [TestMethod]
        public void SHOULD_CheckIfAnimalsFits_WHEN_WagonIsEmpty()
        {
            List<Animal> animals = wagon.Animals;
            animals.Add(new Animal(Animal.Sizes.small, true));

            //Act
            var result = wagon.TryAddAnimal(new Animal(Animal.Sizes.medium, false));

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SHOULDNOT_FitHerbivoreWithCarnivore_WHEN_TheseAnimalsHaveTheSameSize()
        {
            var Herbivore = MockData_Animal.HerbivoreLarge;
            var Carnivore = MockData_Animal.CarnivoreLarge;

            //Act
            wagon.TryAddAnimal(Carnivore);
            bool result = wagon.TryAddAnimal(Herbivore);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SHOULD_AddHerbivoreWithCarnivore_WHEN_ThereisWagonSpace_and_CarnivoreIsSmaller()
        {
            var Herbivore = MockData_Animal.HerbivoreLarge;
            var Carnivore = MockData_Animal.CarnivoreMedium;

            //Act
            wagon.TryAddAnimal(Carnivore);
            bool result = wagon.TryAddAnimal(Herbivore);

            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void SHOULD_AddHerbivoreWithHerbivore_WHEN_ThereIsWagonspaceAvialable()
        {            
            var Herbivore = MockData_Animal.HerbivoreLarge;
            
            wagon.TryAddAnimal(Herbivore);
            bool result = wagon.TryAddAnimal(Herbivore);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void SHOULD_GiveWagonSpaceZero_WHEN_WagonIsFull()
        {
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);

            Assert.AreEqual(0, wagon.WagonSpace);
        }


        [TestMethod]
        public void CheckIfWagonSpaceCanBelowZero()
        {
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);
            wagon.TryAddAnimal(MockData_Animal.Herbivoresmall);

            Assert.AreEqual(0, wagon.WagonSpace);
        }


        [TestMethod]
        public void CheckFor_NonBiggestCarnivore()
        {
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);

            Assert.AreEqual(Animal.Sizes.none, wagon.CheckForCarnivoreRisk());
        }


        [TestMethod]
        public void CheckFor_MediumBiggestCarnivore()
        {
            wagon.TryAddAnimal(MockData_Animal.CarnivoreMedium);
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);

            Assert.AreEqual(Animal.Sizes.medium, wagon.CheckForCarnivoreRisk());
        }


        [TestMethod]
        public void CheckForBiggestCarnivore()
        {
            wagon.TryAddAnimal(MockData_Animal.CarnivoreSmall);
            wagon.TryAddAnimal(MockData_Animal.CarnivoreMedium);

            wagon.TryAddAnimal(MockData_Animal.HerbivoreMedium);
            wagon.TryAddAnimal(MockData_Animal.HerbivoreMedium);
            wagon.TryAddAnimal(MockData_Animal.HerbivoreMedium);
            wagon.TryAddAnimal(MockData_Animal.HerbivoreLarge);
          
            Assert.AreEqual(Animal.Sizes.medium, wagon.CheckForCarnivoreRisk());
        }
    }
}
