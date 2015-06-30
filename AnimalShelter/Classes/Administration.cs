using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AnimalShelter.Classes
{
	public class Administration
	{
        private List<Animal> animals;

		public List<Animal> Animals 
        { 
            get 
            {
                return new List<Animal>(animals);
            }
        }

        public ChipNumberGenerator ChipNumberGenerator { get; private set; }

		public Administration ()
		{
			animals = new List<Animal> ();
            ChipNumberGenerator = new ChipNumberGenerator();
		}

		public bool Add (Animal animal)
		{
            //Short-circuiting ensures we won't allow a null animal to be added (nor dereferenced)
            if(animal == null || FindAnimal(animal.ChipRegistrationNumber) != null)
            {
                return false;
            }

            animals.Add(animal);
            return true;
		}

		public bool RemoveAnimal (int chipRegistrationNumber)
		{
            Animal animal = FindAnimal(chipRegistrationNumber);
		    if (animal == null)
		    {
		        return false;
		    }
		    animals.Remove(animal);
		    return true;
		}

		public Animal FindAnimal (int chipRegistrationNumber)
		{
            foreach (Animal a in animals)
            {
                if (a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return a;
                }
            }
            return null;
		}

        /// <summary>
        /// Saves all animals to a file with the given file name using serialisation.
        /// 
        /// Exceptions: ALL FileStream(string, fileMode) exceptions and ALL BinaryFormatter.Serialize(Stream, object) exceptions, ArgumentException/ArguemtnNullException if fileName is empty or null
        /// </summary>
        /// <param name="fileName">The file to write to.</param>
        public void Save(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }

            if (fileName.Equals(""))
            {
                throw new ArgumentException("fileName");
            }

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, animals);
            }
        }

        /// <summary>
        /// Loads all animals from a file with the given file name using deserialisation.
        /// All animals currently in the administration are removed.
        /// Exceptions: ALL FileStream(string, fileMode) exceptions and ALL BinaryFormatter.Deserialize(Stream) exceptions, ArgumentException/ArguemtnNullException if fileName is empty or null
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public void Load(string fileName)
        {
            if(fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }

            if (fileName.Equals(""))
            {
                throw new ArgumentException("fileName");
            }

            List<Animal> tempAnimals;

            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                tempAnimals = (List<Animal>)formatter.Deserialize(stream);
            }

            animals = tempAnimals;//Replace our animals reference, all the other animals will be removed by GC
        }

        /// <summary>
        /// Exports the info of all animals to a text file with the given file name.
        /// 
        /// Each line of the file contains the info about exactly one animal.
        /// Each line starts with the type of animal and a colon (e.g. 'Cat:' or 'Dog:')
        /// followed by the properties of the animal seperated by comma's.
        /// Exceptions: ALL StreamWriter(string, boolean) exceptions and ALL StreamWriter.Write exceptions, ArgumentException/ArguemtnNullException if fileName is empty or null
        /// </summary>
        /// <param name="fileName">The text file to write to.</param>
        public void Export(string fileName)
	    {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }

            if (fileName.Equals(""))
            {
                throw new ArgumentException("fileName");
            }

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                foreach (Animal animal in Animals)
                {
                    sw.Write(animal + Environment.NewLine);
                }
            }
        }

        public void SortAnimals()
        {
            animals.Sort();
        }
    }
}