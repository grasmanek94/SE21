using System;

namespace AnimalShelter.Classes
{
    [Serializable]
    public class Cat : Animal
    {
        /// <summary>
        /// Description of the bad habits that the cat has (e.g. "Scratches the couch").
        /// or null if the cat has no bad habits.
        /// </summary>
        public string BadHabits { get; set; }

        /// <summary>
        /// How much does the animal cost? In euro
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (BadHabits == null)
                {
                    return 60.0M;
                }
                return Math.Max(20.0M, 60.0M - BadHabits.Length);
            }
        }

        /// <summary>
        /// Creates a cat.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        /// <param name="badHabits">The bad habbits of the cat (e.g. "scratches the couch")
        ///                         or null if none.</param>
        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth,
                    string name, string badHabits)
            : base(chipRegistrationNumber, dateOfBirth, name)
        {
            BadHabits = badHabits;
        }

        /// <summary>
        /// Retrieve information about this cat
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Cat: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <Price>, <BadHabits>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 BadHabits will be "none" if the cat has no bad habits, or the bad habits string otherwise.
        /// </returns>
        public override string ToString()
        {
            string toAppend = !string.IsNullOrEmpty(BadHabits) ? BadHabits : "none";
            return "Cat: " + base.ToString() + ", " + toAppend;
        }
    }
}
