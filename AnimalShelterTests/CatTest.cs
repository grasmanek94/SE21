using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;
using AnimalShelter.Classes;

namespace AnimalShelterTests
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void CatConstructorTest()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", "is strange");

            Assert.AreEqual(591, cat.ChipRegistrationNumber);
            Assert.AreEqual("Jan", cat.Name);
            Assert.AreEqual("31-01-1993", cat.DateOfBirth.ToString());
            Assert.AreEqual("is strange", cat.BadHabits);
            Assert.AreEqual(false, cat.IsReserved);
        }

        [TestMethod]
        public void CatConstructorTestWitNullBadHabits()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", null);

            Assert.AreEqual(null, cat.BadHabits);
        }

        [TestMethod]
        public void CatPriceTestWithBadHabits()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", "123456789");

            Assert.AreEqual(51, cat.Price);
        }

        [TestMethod]
        public void CatPriceTestBadHabbitsNull()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Kitty", null);

            Assert.AreEqual(60, cat.Price);
        }

        [TestMethod]
        public void CatPriceTestBadHabbits_20euro_a()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "BadKitty", "Lorem ipsum dolor sit amet, consectetur a");

            Assert.AreEqual(20, cat.Price);
        }

        [TestMethod]
        public void CatPriceTestBadHabbits_20euro()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "BadKitty", "Lorem ipsum dolor sit amet, consectetur ");

            Assert.AreEqual(20, cat.Price);
        }

        [TestMethod]
        public void CatPriceTestBadHabbits_21euro()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "BadKitty", "Lorem ipsum dolor sit amet, consectetur");

            Assert.AreEqual(21, cat.Price);
        }

        [TestMethod]
        public void CatPriceTestBadHabbits_60euro()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "GoodKitty", "");

            Assert.AreEqual(60, cat.Price);
        }

        [TestMethod]
        public void CatPriceTestBadHabbits_59euro()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "GoodKitty", "a");

            Assert.AreEqual(59, cat.Price);
        }

        [TestMethod]
        public void CatToStringTestNotReservedAndBadHabbitsNull()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", null);

            Assert.AreEqual("Cat: 591, 31-01-1993, Jan, not reserved, €60.00, none", cat.ToString());
        }

        [TestMethod]
        public void CatToStringTestReservedAndBadHabbitsNull()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", null);

            cat.IsReserved = true;

            Assert.AreEqual("Cat: 591, 31-01-1993, Jan, reserved, €60.00, none", cat.ToString());
        }

        [TestMethod]
        public void CatToStringTestReservedAndBadHabbitsNotNull()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", "");

            cat.IsReserved = true;

            Assert.AreEqual("Cat: 591, 31-01-1993, Jan, reserved, €60.00, none", cat.ToString());
        }

        [TestMethod]
        public void CatToStringTestReservedAndHasBadHabbits()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", "has bad habbits");

            cat.IsReserved = true;

            Assert.AreEqual("Cat: 591, 31-01-1993, Jan, reserved, €45.00, has bad habbits", cat.ToString());
        }
    }
}
