using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalShelter.Classes;
using AnimalShelter.Enumerators;

namespace AnimalShelter.Forms
{
    public partial class ModifyAnimalForm : Form
    {
        private Animal animal;
        private AnimalType animalType;
        private AdministrationForm administrationForm;

        private void ShowCatFields()
        {
            inputBadHabits.Visible = true;
            inputLastWalkDate.Visible = false;
            labelDynamic.Text = "Bad Habits";
            inputAnimalType.SelectedItem = "Cat";
        }

        private void ShowDogFields()
        {
            inputBadHabits.Visible = false;
            inputLastWalkDate.Visible = true;
            labelDynamic.Text = "Last Walk Date";
            inputAnimalType.SelectedItem = "Dog";
        }

        public ModifyAnimalForm(Animal animal, AdministrationForm administrationForm)
        {
            if (animal == null)
            {
                throw new ArgumentNullException("animal");
            }

            if (administrationForm == null)
            {
                throw new ArgumentNullException("administrationForm");
            }

            InitializeComponent();

            this.animal = animal;
            this.administrationForm = administrationForm;

            Cat cat = animal as Cat;
            if(cat != null)
            {
                ShowCatFields();
                if (cat.BadHabits != null)
                {                   
                    inputBadHabits.Text = cat.BadHabits;
                }

                animalType = AnimalType.Cat;
            }
            else
            {
                Dog dog = animal as Dog;
                if(dog == null)
                {
                    //We don't know what kind of animal this is, so we cannot modify it.
                    throw new InvalidOperationException();
                }
                ShowDogFields();
                if (dog.LastWalkDate != null)
                {
                    inputLastWalkDate.Value =
                         new DateTime(dog.LastWalkDate.Year, dog.LastWalkDate.Month, dog.LastWalkDate.Day);
                }

                animalType = AnimalType.Dog;
            }

            inputName.Text = animal.Name;
            inputBirthDate.Value =
                new DateTime(animal.DateOfBirth.Year, animal.DateOfBirth.Month, animal.DateOfBirth.Day);
            checkbox_Reserved.Checked = animal.IsReserved;
        }

        private void modifyAnimalButton_Click(object sender, EventArgs e)
        {
            switch(animalType)
            {
                case AnimalType.Cat:
                {
                    Cat cat = animal as Cat;
                    //Equals already returns false if input is null, so no need to double check
                    if (!inputBadHabits.Text.Equals(cat.BadHabits))
                    {
                        cat.BadHabits = inputBadHabits.Text;
                    }
                }
                break;

                case AnimalType.Dog:
                {
                    Dog dog = animal as Dog;

                    if (dog.LastWalkDate.Day != inputLastWalkDate.Value.Day ||
                        dog.LastWalkDate.Month != inputLastWalkDate.Value.Month ||
                        dog.LastWalkDate.Year != inputLastWalkDate.Value.Year)
                    {
                        if (inputLastWalkDate.Value > DateTime.Now)
                        {
                            MessageBox.Show("LastWalkDate is in future, please use a time machine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        dog.LastWalkDate =
                            new SimpleDate(inputLastWalkDate.Value.Day, inputLastWalkDate.Value.Month, inputLastWalkDate.Value.Year);
                    }
                }
                break;
            }
 
            //check if reservation has changed
            if (checkbox_Reserved.Checked != animal.IsReserved)
            {
                animal.IsReserved = checkbox_Reserved.Checked;
                administrationForm.PerformReserveUpdate(animal);
            }

            this.Close();
        }
    }
}
