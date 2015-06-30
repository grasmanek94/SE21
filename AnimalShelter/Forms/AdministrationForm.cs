using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security;
using System.IO;
using System.Runtime.Serialization;
using AnimalShelter.Classes;

namespace AnimalShelter.Forms
{
    public partial class AdministrationForm : Form
    {
        private Administration administration;
        private Animal currentlySelected;

        public AdministrationForm()
        {
            InitializeComponent();
            administration = new Administration();

            currentlySelected = null;
        }

        public void PerformAddAnimal(Animal animal)
        {
            if (animal.IsReserved)
            {
                listboxReserved.Items.Add(animal);
            }
            else
            {
                listboxNotReserved.Items.Add(animal);
            }
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            new CreateAnimalForm(administration, this).ShowDialog(this);
        }

        private void RefreshLists()
        {          
            //Note: Somehow the .RefreshItem method is missing in our solution and we can't find a fix for this, 
            //so we need to refresh the whole control, else our data will be out of sync with the listboxes

            //Fetch updated strings
            if (listboxReserved.SelectedItem != null)
            {
                listboxReserved.DisplayMember = "";
                listboxReserved.DisplayMember = ((Animal)listboxReserved.SelectedItem).ToString();
            }

            if (listboxNotReserved.SelectedItem != null)
            {
                listboxNotReserved.DisplayMember = "";
                listboxNotReserved.DisplayMember = ((Animal)listboxNotReserved.SelectedItem).ToString();
            }

            //Apply
            listboxReserved.Refresh();
            listboxNotReserved.Refresh();
        }

        private void CheckModificationChange()
        {
            if (currentlySelected != null)
            {
                buttonModify.Visible = true;
                buttonSell.Visible = true;

                if(currentlySelected.IsReserved)
                {
                    buttonUnReserve.Visible = true;
                    buttonReserve.Visible = false;
                }
                else
                {
                    buttonUnReserve.Visible = false;
                    buttonReserve.Visible = true;
                }
            }
            else
            {
                buttonModify.Visible = false;
                buttonSell.Visible = false;
                buttonUnReserve.Visible = false;
                buttonReserve.Visible = false;
            }
        }

        private void buttonModify_Click(object sender, System.EventArgs e)
        {
            //currentlySelected cannot be null here, thanks to 'CheckModificationChange'
            new ModifyAnimalForm(currentlySelected, this).ShowDialog(this);

            CheckModificationChange();
            RefreshLists();
        }

        private void listboxNotReserved_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlySelected = listboxNotReserved.SelectedItem as Animal;

            //BEFORE JUDGING THIS CODE READ THE COMMENTS BELOW IN THIS FUNCTION
            listboxReserved.SelectedIndexChanged -= listboxReserved_SelectedIndexChanged;
            listboxReserved.ClearSelected();//triggers "listboxReserved_SelectedIndexChanged", HOW TO FIX? See below!
            //listboxReserved.SelectedItem = null;//triggers "listboxReserved_SelectedIndexChanged", HOW TO FIX? See below!
            listboxReserved.SelectedIndexChanged += listboxReserved_SelectedIndexChanged;
            /*  http://stackoverflow.com/a/905489/2548287
                > There are three ways you can go about this.
                > 
                > A) Don't hook into the SelectedIndexChanged event until AFTER you've called this method.
                > 
                > B)  Have a private boolean in your class that's initially set to true. 
                >     At the start of your PopulateListBoxmethod, set it to false, and at 
                >     the end set it back to true. In your event handler for SelectedIndexChanged , 
                >     if the flag is false, just return and do nothing.
                > 
                > C)  In the start of your PopulateListBoxmethod, unhook from the event (this.listbox1.SelectedIndexChanged -= myMethod;) 
                >     and then right before the method is done, rehook into that event.
             
                We are not allowed to use B) because our teacher says it's not allowed, we can't do A) because we need index changed event
                So we will go for C), that is our only left option! 
                This fixes our multiple-event-fire bug that causes ALL items to be DESELECTED when we select ANYTHING
              
                We can also use 'http://stackoverflow.com/a/10091206/2548287', though, this will still fire the events, and is fundamentally the same as option B) (which we are not allowed to use),
                which in turn can have unforseen future consequences and cause even more bugs. So.. this "option D)" will NOT be used.
             
                If you know any better ways to fix this issue just let us know and we will surely implement the fix!
             */
            CheckModificationChange();
        }

        private void listboxReserved_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BEFORE JUDGING THIS CODE READ THE COMMENTS ABOVE IN 'listboxNotReserved_SelectedIndexChanged' FUNCTION
            currentlySelected = listboxReserved.SelectedItem as Animal;
            listboxNotReserved.SelectedIndexChanged -= listboxNotReserved_SelectedIndexChanged;
            listboxNotReserved.ClearSelected();//triggers "listboxNotReserved_SelectedIndexChanged", HOW TO FIX? See above.
            //listboxNotReserved.SelectedItem = null;//triggers "listboxNotReserved_SelectedIndexChanged", HOW TO FIX? See above.
            listboxNotReserved.SelectedIndexChanged += listboxNotReserved_SelectedIndexChanged;
            CheckModificationChange();
        }

        public void PerformReserveUpdate(Animal animal)
        {
            if (animal != null)
            {
                if (animal.IsReserved)
                {
                    listboxNotReserved.Items.Remove(animal);
                    listboxReserved.Items.Add(animal);
                }
                else
                {
                    listboxReserved.Items.Remove(animal);
                    listboxNotReserved.Items.Add(animal);
                }
            }
        }

        private void PerformReserveButtonClicks(bool goingToBeReserved)
        {
            if (currentlySelected != null && currentlySelected.IsReserved != goingToBeReserved)
            {
                currentlySelected.IsReserved = goingToBeReserved;
                PerformReserveUpdate(currentlySelected);
                currentlySelected = null;
                CheckModificationChange();              
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            PerformReserveButtonClicks(true);
        }

        private void buttonUnReserve_Click(object sender, EventArgs e)
        {
            PerformReserveButtonClicks(false);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (currentlySelected != null)
            {
                Animal animal = currentlySelected;//currentlySelected becomes null when listbox.Items.Remove is called, EVENT BUGS!! which we are not allowed to fix by flags ofcourse. So we need to make inneficient code by making an additional reference (because flags aren't allowed!), which the garbage collector needs to count and handle.

                if (animal.IsReserved)
                {
                    listboxReserved.Items.Remove(animal);
                }
                else
                {
                    listboxNotReserved.Items.Remove(animal);
                }

                administration.RemoveAnimal(animal.ChipRegistrationNumber);
                currentlySelected = null;//just to be sure in case someone fixes the bug that .Remove makes currentlySelected null

                CheckModificationChange();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            currentlySelected = null;

            listboxReserved.BeginUpdate();
            listboxNotReserved.BeginUpdate();

            listboxReserved.Items.Clear();
            listboxNotReserved.Items.Clear();

            administration.SortAnimals();

            foreach (Animal animal in administration.Animals)
            {
                if (animal.IsReserved)
                {
                    listboxReserved.Items.Add(animal);
                }
                else
                {
                    listboxNotReserved.Items.Add(animal);
                }              
            }

            listboxReserved.EndUpdate();
            listboxNotReserved.EndUpdate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog {Filter = "AnimalDB files (*.adb)|*.adb"};
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    administration.Save(saveFile.FileName);
                }
                catch (PathTooLongException ex)
                {
                    ExceptionOccuredForm.Show(this, "The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.", ex.Message);
                }
                catch(DirectoryNotFoundException ex)//Note: exception has misleading name, directory should be path
                {
                    ExceptionOccuredForm.Show(this, "The specified path is invalid, such as being on an unmapped drive.", ex.Message);
                }
                catch(IOException ex)
                {
                    ExceptionOccuredForm.Show(this, "I/O error, path already exists and cannot overwrite path", ex.Message);
                }
                catch (SecurityException ex)
                {
                    ExceptionOccuredForm.Show(this, "This application does not have the security permission to access the path.", ex.Message);
                }
                catch(NotSupportedException ex)
                {
                    ExceptionOccuredForm.Show(this, "path is empty, contains only white space, or contains one or more invalid characters -or- refers to a non-file device, such as \"con:\", \"com1:\", \"lpt1:\", etc.", ex.Message);
                }
                catch(ArgumentException ex)
                {
                    ExceptionOccuredForm.Show(this, "path refers to a non-file device, such as \"con:\", \"com1:\", \"lpt1:\", etc.", ex.Message);
                }
                catch(SerializationException ex)
                {
                    ExceptionOccuredForm.Show(this, "One or more animal objects use classes that are not marked as serializable", ex.Message);
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog {Filter = "AnimalExport files (*.txt)|*.txt"};
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    administration.Export(saveFile.FileName);
                }
                catch (PathTooLongException ex)
                {
                    ExceptionOccuredForm.Show(this, "The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.", ex.Message);
                }
                catch (DirectoryNotFoundException ex)//Note: exception has misleading name, directory should be path
                {
                    ExceptionOccuredForm.Show(this, "The specified path is invalid, such as being on an unmapped drive.", ex.Message);
                }
                catch (IOException ex)
                {
                    ExceptionOccuredForm.Show(this, "I/O error, path already exists and cannot overwrite path, or another IO error occured", ex.Message);
                }
                catch (SecurityException ex)
                {
                    ExceptionOccuredForm.Show(this, "This application does not have the security permission to access the path.", ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    ExceptionOccuredForm.Show(this, "Access is denied to path", ex.Message);
                }
                catch (ArgumentException ex)
                {
                    ExceptionOccuredForm.Show(this, "path refers to a non-file device, such as \"con:\", \"com1:\", \"lpt1:\", etc.", ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    ExceptionOccuredForm.Show(this, "The animals cannot be written to the underlying file stream because a buffer overrun occured in the writer, the export is incomplete and/or corrupt.", ex.Message);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog {Filter = "AnimalDB files(*.adb) | *.adb"};
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    administration.Load(openFile.FileName);
                }
                catch (PathTooLongException ex)
                {
                    ExceptionOccuredForm.Show(this, "The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.", ex.Message);
                    return;
                }
                catch (DirectoryNotFoundException ex)//Note: exception has misleading name, directory should be path
                {
                    ExceptionOccuredForm.Show(this, "The specified path is invalid, such as being on an unmapped drive.", ex.Message);
                    return;
                }
                catch (IOException ex)
                {
                    ExceptionOccuredForm.Show(this, "I/O error, path already exists and cannot overwrite path", ex.Message);
                    return;
                }
                catch (SecurityException ex)
                {
                    ExceptionOccuredForm.Show(this, "This application does not have the security permission to access the path.", ex.Message);
                    return;
                }
                catch (NotSupportedException ex)
                {
                    ExceptionOccuredForm.Show(this, "path is empty, contains only white space, or contains one or more invalid characters -or- refers to a non-file device, such as \"con:\", \"com1:\", \"lpt1:\", etc.", ex.Message);
                    return;
                }
                catch (ArgumentException ex)
                {
                    ExceptionOccuredForm.Show(this, "path refers to a non-file device, such as \"con:\", \"com1:\", \"lpt1:\", etc.", ex.Message);
                    return;
                }
                catch (SerializationException ex)
                {
                    ExceptionOccuredForm.Show(this, "Deserialisation has failed, input file corrupt and/or invalid?", ex.Message);
                    return;
                }
            }

            listboxNotReserved.Items.Clear();
            listboxReserved.Items.Clear();

            foreach (Animal a in administration.Animals)
            {
                if (a.IsReserved)
                {
                    listboxReserved.Items.Add(a);
                }
                else if (!a.IsReserved)
                {
                    listboxNotReserved.Items.Add(a);
                } 
            }
        }
    }
}
