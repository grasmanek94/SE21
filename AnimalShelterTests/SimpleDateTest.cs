using System;
using AnimalShelter;
using AnimalShelter.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelterTests
{
    [TestClass]
    public class SimpleDateTest
    {
        [TestMethod]
        public void StoreDate()
        {
            SimpleDate date = new SimpleDate(1, 2, 1993);
            Assert.AreEqual(date.Day, 1);
            Assert.AreEqual(date.Month, 2);
            Assert.AreEqual(date.Year, 1993);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StoreIncorrectDayDate()
        {
            new SimpleDate(32, 2, 1993);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StoreIncorrecMonthDate()
        {
            new SimpleDate(2, 22, 1993);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StoreIncorrecYearDate()
        {
           new SimpleDate(2, 3, -500);
        }

        [TestMethod]
        public void GetDateString()
        {
            SimpleDate date = new SimpleDate(9, 7, 1993);
            Assert.AreEqual(date.ToString(), "09-07-1993");
        }

        [TestMethod]
        public void GetDaysDifference()
        {
            SimpleDate date = new SimpleDate(31, 01, 1993);
            SimpleDate date2 = new SimpleDate(09, 07, 1994);

            Assert.AreEqual(date.DaysDifference(date2), 524);
        }

        [TestMethod]
        public void GetDaysDifferenceWithLeapYear()
        {
            SimpleDate date = new SimpleDate(31, 01, 1993);
            SimpleDate date2 = new SimpleDate(09, 07, 1998);

            Assert.AreEqual(date.DaysDifference(date2), 1985);
        }

        [TestMethod]
        public void GetDaysDifferenceRevesed()
        {
            SimpleDate date = new SimpleDate(31, 01, 1993);
            SimpleDate date2 = new SimpleDate(09, 07, 1998);

            Assert.AreEqual(date2.DaysDifference(date), -1985);
        }

        [TestMethod]
        public void GetDaysDifferenceZero()
        {
            SimpleDate date = new SimpleDate(31, 01, 1993);
            SimpleDate date2 = new SimpleDate(31, 01, 1993);

            Assert.AreEqual(date2.DaysDifference(date), 0);
        }
    }
}
