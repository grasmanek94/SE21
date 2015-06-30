using System;
using System.Globalization;
using AnimalShelter.Interfaces;

namespace AnimalShelter.Classes
{
    /// <summary>
    /// Class representing an animal in the shelter.
    /// </summary>
    [Serializable]
    public abstract class Animal : ISellable, IComparable<Animal>
    {
        /// <summary>
        /// The chipnumber of the animal. Must be unique. Must be zero or greater than zero.
        /// </summary>
        public int ChipRegistrationNumber { get; private set; }

        /// <summary>
        /// Date of birth of the animal.
        /// </summary>
        public SimpleDate DateOfBirth { get; private set; }

        /// <summary>
        /// The name of the animal.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Is the animal reserved by a future owner yes or no.
        /// </summary>
        public bool IsReserved { get; set; }

        /// <summary>
        /// How much does the animal cost? In euro
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Creates an animal.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        protected Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth");
            }

            if (name.Length == 0)
            {
                throw new ArgumentException("name");
            }

            if (chipRegistrationNumber < 0)
            {
                throw new ArgumentOutOfRangeException("chipRegistrationNumber");
            }

            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            IsReserved = false;
        }

        /// <summary>
        /// Retrieve information about this animal
        /// 
        /// Note: Every class inherits (automatically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "<ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise. 
        /// </returns>
        public override string ToString()
        {
            string isReservedString = IsReserved ? "reserved" : "not reserved";

            string info = ChipRegistrationNumber
                          + ", " + DateOfBirth
                          + ", " + Name
                          + ", " + isReservedString
                          + ", €" + Price.ToString("F", CultureInfo.InvariantCulture);
            return info;
        }

        /// <summary>
        /// Provides the IComparable interface definitions
        /// </summary>
        public int CompareTo(Animal other)
        {
            if(other == null)
            {
                throw new ArgumentNullException("other");
            }

            return ChipRegistrationNumber.CompareTo(other.ChipRegistrationNumber);
        }
    }
}
