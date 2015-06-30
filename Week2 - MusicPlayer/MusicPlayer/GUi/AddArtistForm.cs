using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class AddArtistForm : Form
    {
        private MusicPlayer musicplayer;

        public AddArtistForm(MusicPlayer externalmusicplayer)
        {
            InitializeComponent();
            musicplayer = externalmusicplayer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbArtistName.TextLength < 1)
            {
                MessageBox.Show("Er is geen artiest naam opgegeven!");
                return;
            }

            if(dtpArtistBday.Value >= DateTime.Now)
            {
                MessageBox.Show("Geboortedatum moet in het verleden zijn!");
                return;
            }

            foreach(Artist a in musicplayer.Artists())
            {
                if(a.Name == tbArtistName.Text)
                {
                    MessageBox.Show("Artiest bestaat al!");
                    return;
                }
            }

            musicplayer.Add(new Artist(tbArtistName.Text, dtpArtistBday.Value));

            this.Close();
        }

        private void AddArtistForm_Load(object sender, EventArgs e)
        {

        }
    }
}
