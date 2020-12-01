using Circustrein_algoritme;
using Circustrein_Tests.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein_Tests.Tests
{
    
    [TestClass]
    public class TrainTest
    { 
        readonly Train train = new Train();

        [TestMethod]
        public void SHOULD_NotAddWagon_WHEN_ThereAreNoAnimals()
        {
            List<Animal> animals = new List<Animal>(){};

            train.FillWagon(animals);
            
            Assert.AreEqual(0, train.GetWagons().Count);
        }

        [TestMethod]
        public void SHOULD_AddWagon_ForOneAnimal()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Animal.Sizes.large, false),
            };
            train.FillWagon(animals);
          
            Assert.AreEqual(1, train.GetWagons().Count);
        }

        [TestMethod]
        public void SHOULD_AddWagon_ForeachIndividual_Carnivore()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Animal.Sizes.large, true),
                new Animal(Animal.Sizes.small, true),
                new Animal(Animal.Sizes.medium, true),
                new Animal(Animal.Sizes.medium, true),
            };

            train.FillWagon(animals);
           
            Assert.AreEqual(4, train.GetWagons().Count);
        }


        [TestMethod]
        public void SHOULD_FillAllHerbivores_InOneWagon()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Animal.Sizes.large, false),
                new Animal(Animal.Sizes.small, false),
                new Animal(Animal.Sizes.small, false),
                new Animal(Animal.Sizes.medium, false),
            };

            train.FillWagon(animals);
            
            Assert.AreEqual(1, train.GetWagons().Count);
        }


        [TestMethod]
        public void SHOULD_Handle_Large_Numbers_Of_Animals()
        {
           List<Animal> animals = new List<Animal>();

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.Sizes.large, false));
            }

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.Sizes.large, true));
            }

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Animal.Sizes.medium, false));
            }

            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Animal.Sizes.medium, true));
            }

            for (int i = 0; i < 6; i++)
            {
                animals.Add(new Animal(Animal.Sizes.small, false));
            }

            for (int i = 0; i < 4; i++)
            {
                animals.Add(new Animal(Animal.Sizes.small, true));
            }

            train.FillWagon(animals);

            Assert.AreEqual(12, train.GetWagons().Count);
        }

    }
}