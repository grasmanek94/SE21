using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter.Forms
{
    public partial class ExceptionOccuredForm : Form
    {
        public ExceptionOccuredForm(string errorText, string infoText)
        {
            InitializeComponent();
            errorTextBox.Text = errorText;
            infoTextBox.Text = infoText;
        }

        //even Microsoft does this! (MessageBox.Show), so I'll allow myself to take Microsoft as an example and do the same stuff
        //remember: Microsoft **MADE** C#, they are ALWAYS right.
        static public void Show(IWin32Window owner, string errorText, string infoText)
        {
            new ExceptionOccuredForm(errorText, infoText).ShowDialog(owner);
        }
    }
}
