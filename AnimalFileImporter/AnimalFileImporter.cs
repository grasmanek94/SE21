using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;

namespace AnimalFileImporter
{
    public partial class AnimalFileImporter : Form
    {
        private const string dateTimeFormat = "dd-MM-yyyy";

        public AnimalFileImporter()
        {
            InitializeComponent();
        }

        private void ClearLists()
        {
            lbDogs.Items.Clear();
            lbCats.Items.Clear();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog {Filter = "AnimalDB files(*.txt) | *.txt"};
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader r = new StreamReader(openFile.FileName))
                    {
                        string line;

                        ClearLists();
                        lbError.Items.Clear();

                        while ((line = r.ReadLine()) != null)
                        {
                            string[] data = line.Split(",".ToArray(), 6);
                            string chipnr = data[0].Substring(data[0].IndexOf(':') + 1);
                            string name = data[2];
                            string bday = data[1].Trim();

                            DateTime goodBirthDay;

                            if (!DateTime.TryParseExact(bday, dateTimeFormat, null,
                                DateTimeStyles.None, out goodBirthDay))
                            {
                                lbError.Items.Add(line);
                            }
                            else if (data[0].IndexOf("Dog:", StringComparison.Ordinal) == 0)
                            {
                                lbDogs.Items.Add(string.Format("{0}, {1}, {2}", chipnr, name, goodBirthDay.ToString(dateTimeFormat, CultureInfo.InvariantCulture)));
                            }
                            else if (data[0].IndexOf("Cat:", StringComparison.Ordinal) == 0)
                            {
                                string badhabbit = data[5];
                                lbCats.Items.Add(string.Format("{0}, {1}, {2}, {3}", chipnr, name, goodBirthDay.ToString(dateTimeFormat, CultureInfo.InvariantCulture), badhabbit));
                            }
                            else
                            {
                                lbError.Items.Add(line);
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException ex)//Note: exception has misleading name, directory should be path
            {
                ExceptionOccuredForm.Show(this, "The specified path is invalid, such as being on an unmapped drive.", ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                ExceptionOccuredForm.Show(this, "The file cannot be found.", ex.Message);
            }
            catch (IOException ex)
            {
                ExceptionOccuredForm.Show(this, "path includes an incorrect or invalid syntax for file name, directory name, or volume label.", ex.Message);
            }
            catch (ArgumentException ex)
            {
                ExceptionOccuredForm.Show(this, "path is empty.", ex.Message);
            }           
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearLists();
        }
    }
}
