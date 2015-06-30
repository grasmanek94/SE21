using AnimalShelter.Classes;
using System.IO;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelterTests
{
    [TestClass]
    public class AdministrationTest
    {
        [TestMethod]
        public void CreateAdministation()
        {
            Administration admin = new Administration();

            Assert.AreEqual(0, admin.Animals.Count);
        }

        [TestMethod]
        public void AddAnimalToList()
        {
            Administration admin = new Administration();

            Assert.AreEqual(0, admin.Animals.Count);

            Cat animal = new Cat(1, new SimpleDate(09, 07, 1993), "Cat", "something bad");

            Assert.AreEqual(true, admin.Add(animal));
            Assert.AreEqual(1, admin.Animals.Count);
            Assert.AreSame(animal, admin.Animals[0]);
        }


        [TestMethod]
        public void AddInvalidNull()
        {
            Administration admin = new Administration();

            Assert.AreEqual(false, admin.Add(null));
            Assert.AreEqual(0, admin.Animals.Count);
        }

        [TestMethod]
        public void AddInvalidClone()
        {
            Administration admin = new Administration();

            Dog animal = new Dog(1, new SimpleDate(22, 08, 1996), "Dog", new SimpleDate(22, 04, 2003));

            Assert.AreEqual(true, admin.Add(animal));
            Assert.AreEqual(false, admin.Add(animal));
            Assert.AreEqual(1, admin.Animals.Count);
        }

        [TestMethod]
        public void FindCatTestTrue()
        {
            Administration admin = new Administration();

            Cat a = new Cat(1, new SimpleDate(14, 12, 1990), "Kitty", "bla");
            admin.Add(a);

            Assert.AreEqual(a, admin.FindAnimal(a.ChipRegistrationNumber));
        }

        [TestMethod]
        public void FindDogTestTrue()
        {
            Administration admin = new Administration();

            Dog a = new Dog(1, new SimpleDate(14, 12, 1990), "Kitty", new SimpleDate(03, 03, 2013));
            admin.Add(a);

            Assert.AreEqual(a, admin.FindAnimal(a.ChipRegistrationNumber));
        }

        [TestMethod]
        public void FindAnimalNotExisting()
        {
            Administration admin = new Administration();

            Assert.AreEqual(null, admin.FindAnimal(0));
        }

        [TestMethod]
        public void RemoveCatTest()
        {
            Administration admin = new Administration();

            Cat a = new Cat(1, new SimpleDate(14, 12, 1990), "Kitty", "bla");
            admin.Add(a);

            Assert.AreEqual(1,admin.Animals.Count);
            Assert.AreEqual(true, admin.RemoveAnimal(a.ChipRegistrationNumber));
            Assert.AreEqual(0,admin.Animals.Count);
        }

        [TestMethod]
        public void RemoveCatTestFalse()
        {
            Administration admin = new Administration();

            Cat a = new Cat(1, new SimpleDate(14, 12, 1990), "Kitty", "bla");

            Assert.AreEqual(false, admin.RemoveAnimal(a.ChipRegistrationNumber));
            Assert.AreEqual(0, admin.Animals.Count);
        }

        [TestMethod]
        public void AnimalsCopyTest()
        {
            Administration admin = new Administration();

            Dog a = new Dog(1, new SimpleDate(14, 12, 1990), "Doggy", null);
            Cat b = new Cat(2, new SimpleDate(14, 12, 1990), "Kitty", null);

            admin.Add(a);
            admin.Add(b);

            Assert.AreEqual(2,admin.Animals.Count);
            Assert.AreEqual(true, admin.Animals.Contains(a));
            Assert.AreEqual(true, admin.Animals.Contains(b));
        }

        [TestMethod]
        public void SortTest()
        {
            Administration admin = new Administration();

            Cat a = new Cat(0, new SimpleDate(14, 12, 1990), "Kittyc", "bla");
            Cat b = new Cat(1, new SimpleDate(14, 12, 1990), "Kittyb", "bla");
            Cat c = new Cat(5, new SimpleDate(14, 12, 1990), "Kittya", "bla");
            Dog d = new Dog(10, new SimpleDate(14, 12, 1990), "Dog", null);

            Assert.AreEqual(0, admin.Animals.Count);

            admin.Add(c);
            admin.Add(d);
            admin.Add(b);
            admin.Add(a);

            Assert.AreEqual(4, admin.Animals.Count);

            Assert.AreSame(c, admin.Animals[0]);
            Assert.AreSame(d, admin.Animals[1]);
            Assert.AreSame(b, admin.Animals[2]);
            Assert.AreSame(a, admin.Animals[3]);

            admin.SortAnimals();
            
            Assert.AreSame(a, admin.Animals[0]);
            Assert.AreSame(b, admin.Animals[1]);
            Assert.AreSame(c, admin.Animals[2]);
            Assert.AreSame(d, admin.Animals[3]);

            Assert.AreEqual(4, admin.Animals.Count);
        }

        [TestMethod]
        public void TestExportFunctionality()
        {
            string filename = Path.GetTempFileName();

            Administration admin = new Administration();

            Dog a = new Dog(0, new SimpleDate(1, 2, 2013), "Ramzes", null);
            Cat b = new Cat(1, new SimpleDate(2, 3, 2014), "Hello Kitty", null);
            Dog c = new Dog(62345, new SimpleDate(11, 12, 2011), "Jannetje", new SimpleDate(4, 4, 2015));
            Cat d = new Cat(62346, new SimpleDate(1, 1, 2000), "KatjeXWithSWAG", "Heeft te veel SWAG");

            b.IsReserved = true;

            admin.Add(a);
            admin.Add(b);
            admin.Add(c);
            admin.Add(d);

            admin.Export(filename);

            string[] text = File.ReadAllLines(filename);

            Assert.AreEqual("Dog: 0, 01-02-2013, Ramzes, not reserved, €200.00, unknown", text[0], false);
            Assert.AreEqual("Cat: 1, 02-03-2014, Hello Kitty, reserved, €60.00, none", text[1], false);
            Assert.AreEqual("Dog: 62345, 11-12-2011, Jannetje, not reserved, €350.00, 04-04-2015", text[2], false);
            Assert.AreEqual("Cat: 62346, 01-01-2000, KatjeXWithSWAG, not reserved, €42.00, Heeft te veel SWAG", text[3], false);

            File.Delete(filename);
        }

        [TestMethod]
        public void TestSaveAndLoadFunctionality()
        {
            string filename = Path.GetTempFileName();

            Administration shelter_helmond = new Administration();
            Administration shelter_eindhoven = new Administration();

            Dog a = new Dog(0, new SimpleDate(1, 2, 2013), "Ramzes", null);
            Cat b = new Cat(1, new SimpleDate(2, 3, 2014), "Hello Kitty", null);
            Dog c = new Dog(62345, new SimpleDate(11, 12, 2011), "Jannetje", new SimpleDate(4, 4, 2015));
            Cat d = new Cat(62346, new SimpleDate(1, 1, 2000), "KatjeXWithSWAG", "Heeft te veel SWAG");

            b.IsReserved = true;

            shelter_helmond.Add(a);
            shelter_helmond.Add(b);
            shelter_helmond.Add(c);
            shelter_helmond.Add(d);

            shelter_helmond.Save(filename);

            shelter_eindhoven.Load(filename);

            Assert.AreEqual(4, shelter_eindhoven.Animals.Count);

            Assert.AreEqual("Dog: 0, 01-02-2013, Ramzes, not reserved, €200.00, unknown", shelter_eindhoven.Animals[0].ToString(), false);
            Assert.AreEqual("Cat: 1, 02-03-2014, Hello Kitty, reserved, €60.00, none", shelter_eindhoven.Animals[1].ToString(), false);
            Assert.AreEqual("Dog: 62345, 11-12-2011, Jannetje, not reserved, €350.00, 04-04-2015", shelter_eindhoven.Animals[2].ToString(), false);
            Assert.AreEqual("Cat: 62346, 01-01-2000, KatjeXWithSWAG, not reserved, €42.00, Heeft te veel SWAG", shelter_eindhoven.Animals[3].ToString(), false);

            File.Delete(filename);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAnimalExportNullFileName()
        {
            Administration admin = new Administration();

            admin.Export(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAnimalExportEmptyFileName()
        {
            Administration admin = new Administration();

            admin.Export("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAnimalSaveNullFileName()
        {
            Administration admin = new Administration();

            admin.Save(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAnimalSaveEmptyFileName()
        {
            Administration admin = new Administration();

            admin.Save("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAnimalLoadNullFileName()
        {
            Administration admin = new Administration();

            admin.Load(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAnimalLoadEmptyFileName()
        {
            Administration admin = new Administration();

            admin.Load("");
        }
    }
}