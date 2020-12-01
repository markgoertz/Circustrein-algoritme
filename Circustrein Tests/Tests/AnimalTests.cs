using Circustrein_algoritme;
using Circustrein_Tests.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein_Tests.Tests
{
    [TestClass]
    public class AnimalTests    
    {
        [TestMethod]
        public void SucceedToStringTest()
        {
            var expected = MockData_Animal.HerbivoreMedium.ToString();
            var result = new Animal(Animal.Sizes.medium, false).ToString();
            Assert.AreEqual(expected, result.ToString());
        }
        [TestMethod]
        public void FailedToStringTest()
        {
            var expected = MockData_Animal.CarnivoreLarge.ToString();
            var result = new Animal(Animal.Sizes.small, false).ToString();

            Assert.AreNotEqual(expected, result);
        }
    }
}
