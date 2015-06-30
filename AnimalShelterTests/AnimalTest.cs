using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;
using AnimalShelter.Classes;
using System.Collections.Generic;

namespace AnimalShelterTests
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void TestIComparableInterfaceByValue()    
        {
            Animal animalone = new Dog(0, new SimpleDate(1, 1, 2000), "doggy", null);
            Animal animaltwo = new Cat(1, new SimpleDate(1, 1, 2000), "kitty", null);

            Assert.AreEqual(-1, animalone.CompareTo(animaltwo));
            Assert.AreEqual(0, animalone.CompareTo(animalone));
            Assert.AreEqual(0, animaltwo.CompareTo(animaltwo));
            Assert.AreEqual(1, animaltwo.CompareTo(animalone));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIComparableInterfaceByException()
        {
            Animal animalone = new Dog(0, new SimpleDate(1, 1, 2000), "doggy", null);

            animalone.CompareTo(null);
        }

        [TestMethod]
        public void TestIComparableInterfaceByListSort()
        {
            Animal animalone = new Dog(0, new SimpleDate(1, 1, 2000), "doggy", null);
            Animal animaltwo = new Cat(1, new SimpleDate(1, 1, 2000), "kitty", null);
            Animal animalthree = new Cat(2, new SimpleDate(1, 1, 2000), "kitty", null);

            List<Animal> animals = new List<Animal>();

            animals.Add(animalthree);
            animals.Add(animalone);
            animals.Add(animaltwo);

            animals.Sort();

            Assert.AreSame(animalone, animals[0]);
            Assert.AreSame(animaltwo, animals[1]);
            Assert.AreSame(animalthree, animals[2]);
        }

        [TestMethod]
        public void TestAnimalToStringReserved()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", null);

            cat.IsReserved = true;

            Assert.AreEqual(true, cat.IsReserved);
            Assert.AreEqual("Cat: 591, 31-01-1993, Jan, reserved, €60.00, none", cat.ToString());
        }

        [TestMethod]
        public void TestAnimalToStringNotReserved()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "Jan", null);

            Assert.AreEqual(false, cat.IsReserved);
            Assert.AreEqual("Cat: 591, 31-01-1993, Jan, not reserved, €60.00, none", cat.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAnimalNegativeChipNumber()
        {
            Cat cat = new Cat(-1, new SimpleDate(31, 01, 1993), "Jan", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNoName()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), "", "Something");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNameIsNull()
        {
            Cat cat = new Cat(591, new SimpleDate(31, 01, 1993), null, "Something");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestBirthdayNull()
        {
            Cat cat = new Cat(591, null, "name", "Something");
        }
    }
}
