using Circustrein_algoritme;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein_Tests.MockData
{
    public class MockData_Animal
    {
        public static Animal AnimalwithoutSize = new Animal(Animal.Sizes.none, false);

        public static Animal Herbivoresmall = new Animal(Animal.Sizes.small, false);
        public static Animal HerbivoreMedium = new Animal(Animal.Sizes.medium, false);
        public static Animal HerbivoreLarge = new Animal(Animal.Sizes.large, false);

        public static Animal CarnivoreSmall = new Animal(Animal.Sizes.small, true);
        public static Animal CarnivoreMedium = new Animal(Animal.Sizes.medium, true);
        public static Animal CarnivoreLarge = new Animal(Animal.Sizes.large, true);
    }
}
