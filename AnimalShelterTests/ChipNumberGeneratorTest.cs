using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter.Classes;

namespace AnimalShelterTests
{
    [TestClass]
    public class ChipNumberGeneratorTest
    {
        [TestMethod]
        public void DefaultGeneratorTest()
        {
            ChipNumberGenerator chipNumberGenerator = new ChipNumberGenerator();

            Assert.AreEqual(0, chipNumberGenerator.Generate());
            Assert.AreEqual(1, chipNumberGenerator.Generate());
            Assert.AreEqual(2, chipNumberGenerator.Generate());
            Assert.AreEqual(3, chipNumberGenerator.Generate());
            Assert.AreEqual(4, chipNumberGenerator.Generate());
            Assert.AreEqual(5, chipNumberGenerator.Generate());
           
        }

        [TestMethod]
        public void CustomGeneratorTest()
        {
            ChipNumberGenerator chipNumberGenerator = new ChipNumberGenerator(10);

            Assert.AreEqual(11, chipNumberGenerator.Generate());
            Assert.AreEqual(12, chipNumberGenerator.Generate());
            Assert.AreEqual(13, chipNumberGenerator.Generate());
            Assert.AreEqual(14, chipNumberGenerator.Generate());
            Assert.AreEqual(15, chipNumberGenerator.Generate());
            Assert.AreEqual(16, chipNumberGenerator.Generate());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CustomGeneratorWithNegativeNumbersTest()
        {
            ChipNumberGenerator chipNumberGenerator = new ChipNumberGenerator(-3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CustomGeneratorWithInt3Max()
        {
            ChipNumberGenerator chipNumberGenerator = new ChipNumberGenerator(Int32.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CustomGeneratorInvalidOperation()
        {
            ChipNumberGenerator chipNumberGenerator = new ChipNumberGenerator(Int32.MaxValue-1);
            chipNumberGenerator.Generate();
            chipNumberGenerator.Generate();
        }
    }
}
