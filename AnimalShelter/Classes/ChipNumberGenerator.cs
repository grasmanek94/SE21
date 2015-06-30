using System;

namespace AnimalShelter.Classes
{
    public class ChipNumberGenerator
    {
        private int currentId;

        /// <summary>
        /// Create the ChipnumberGenerator, if no parameter is given, the first number will be 0
        /// </summary>
        public ChipNumberGenerator()
        {
            currentId = 0;
        }
        /// <summary>
        /// Create the ChipnumberGenerator, the parameter will be the first parameter in the sequence.
        /// </summary>
        /// <param name="highestId">The number to start the sequence with. Must be greater than or 0, else an ArgumentOutOfRangeException will be thrown</param>
        public ChipNumberGenerator(int highestId)
        {
            if (highestId < 0 || highestId == int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("highestId");
            }
            currentId = highestId + 1;
        }

        /// <summary>
        /// Give the next number in the sequence
        /// </summary>
        /// <returns>The next number in the sequence</returns>
        public int Generate()
        {
            if (currentId == int.MaxValue)
            {
                throw new InvalidOperationException();
            }
            return currentId++;
        }
    }
}
