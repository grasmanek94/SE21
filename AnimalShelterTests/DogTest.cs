using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;
using AnimalShelter.Classes;

namespace AnimalShelterTests
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void DogConstructorTest()
        {
            Dog dog = new Dog(5, new SimpleDate(09, 04, 1920), "Doggy", new SimpleDate(1, 3, 2000));

            Assert.AreEqual(5, dog.ChipRegistrationNumber);
            Assert.AreEqual(false, dog.IsReserved);
            Assert.AreEqual("Doggy", dog.Name);
            Assert.AreEqual("09-04-1920", dog.DateOfBirth.ToString());
            Assert.AreEqual("01-03-2000", dog.LastWalkDate.ToString());
        }

        [TestMethod]
        public void DogConstructorTestWithNullWalkDate()
        {
            Dog dog = new Dog(5, new SimpleDate(1, 1, 1930), "Doggy", null);

            Assert.AreEqual(5, dog.ChipRegistrationNumber);
            Assert.AreEqual("Doggy", dog.Name);
            Assert.AreEqual("01-01-1930", dog.DateOfBirth.ToString());
            Assert.AreEqual(null, dog.LastWalkDate);
        }

        [TestMethod]
        public void DogToStringTestWithNullWalkDate()
        {
            Dog dog = new Dog(5, new SimpleDate(9, 4, 1920), "Doggy", null);

            Assert.AreEqual("Dog: 5, 09-04-1920, Doggy, not reserved, €200.00, unknown", dog.ToString());
        }

        [TestMethod]
        public void DogToStringTestWithNonNullWalkDate()
        {
            Dog dog = new Dog(5, new SimpleDate(9, 4, 1920), "Doggy", new SimpleDate(1, 3, 2000));

            Assert.AreEqual("Dog: 5, 09-04-1920, Doggy, not reserved, €200.00, 01-03-2000", dog.ToString());
        }

        [TestMethod]
        public void DogPriceTestChip999999()
        {
            Dog dog = new Dog(999999, new SimpleDate(1, 1, 1930), "Doggy", null);

            Assert.AreEqual(350.00M, dog.Price);
        }

        [TestMethod]
        public void DogPriceTestChip50001()
        {
            Dog dog = new Dog(50001, new SimpleDate(1, 1, 1930), "Doggy", null);

            Assert.AreEqual(350.00M, dog.Price);
        }

        [TestMethod]
        public void DogPriceTestChip50000()
        {
            Dog dog = new Dog(50000, new SimpleDate(01, 01, 1930), "Doggy", null);

            Assert.AreEqual(350.00M, dog.Price);
        }

        [TestMethod]
        public void DogPriceTestChip49999()
        {
            Dog dog = new Dog(49999, new SimpleDate(01, 01, 1930), "Doggy", null);

            Assert.AreEqual(200.00M, dog.Price);
        }

        [TestMethod]
        public void DogPriceTestChip0()
        {
            Dog dog = new Dog(0, new SimpleDate(01, 01, 1930), "Doggy", null);

            Assert.AreEqual(200.00M, dog.Price);
        }
    }
}
