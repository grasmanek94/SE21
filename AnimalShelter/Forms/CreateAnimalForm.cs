using System;
using System.Windows.Forms;
using AnimalShelter.Classes;
using AnimalShelter.Enumerators;

namespace AnimalShelter.Forms
{
    public partial class CreateAnimalForm : Form
    {
        private Administration administration;
        private AdministrationForm administrationForm;

        private AnimalType animalType;

        public CreateAnimalForm(Administration administration, AdministrationForm administrationForm)
        {
            if (administration == null)
            {
                throw new ArgumentNullException("administration");
            }

            if (administrationForm == null)
            {
                throw new ArgumentNullException("administrationForm");
            }

            InitializeComponent();

            this.administration = administration;
            this.administrationForm = administrationForm;
        }

        private void ShowCatFields()
        {
            inputBadHabits.Visible = true;
            inputLastWalkDate.Visible = false;
            labelDynamic.Text = "Bad Habits";
        }

        private void ShowDogFields()
        {
            inputBadHabits.Visible = false;
            inputLastWalkDate.Visible = true;
            labelDynamic.Text = "Last Walk Date";
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputName.Text))
            {
                MessageBox.Show("Name is empty, your passport has been revoked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (inputBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("BirthDate is in future, please use a time machine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Animal animal = null;

            switch (animalType)
            {
                case AnimalType.Cat:
                {
                    animal = new Cat(administration.ChipNumberGenerator.Generate(),
                        new SimpleDate(inputBirthDate.Value.Day, inputBirthDate.Value.Month, inputBirthDate.Value.Year),
                        inputName.Text,
                        inputBadHabits.Text);
                }
                break;

                case AnimalType.Dog:
                {
                    if (inputLastWalkDate.Value > DateTime.Now)
                    {
                        MessageBox.Show("LastWalkDate is in future, please use a time machine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    animal = new Dog(administration.ChipNumberGenerator.Generate(),
                        new SimpleDate(inputBirthDate.Value.Day, inputBirthDate.Value.Month, inputBirthDate.Value.Year),
                        inputName.Text,
                        new SimpleDate(inputLastWalkDate.Value.Day, inputLastWalkDate.Value.Month, inputLastWalkDate.Value.Year));
                }
                break;
            }

            if (animal != null)
            {
                //Animal is not null and animal chip number cannot ever be the same as we just generated a new one, so this will always succeed
                animal.IsReserved = checkbox_Reserved.Checked;

                administration.Add(animal);

                administrationForm.PerformAddAnimal(animal);
            }

            this.Close();
        }

        private void inputAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (inputAnimalType.Text)
            {
                case "Cat":
                    ShowCatFields();
                    animalType = AnimalType.Cat;
                    break;

                case "Dog":
                    ShowDogFields();
                    animalType = AnimalType.Dog;
                    break;
            }
        }

        private void CreateAnimalForm_Load(object sender, EventArgs e)
        {
            inputAnimalType.SelectedIndex = 0;// NOTE: triggers inputAnimalType_SelectedIndexChanged
        }
    }
}
