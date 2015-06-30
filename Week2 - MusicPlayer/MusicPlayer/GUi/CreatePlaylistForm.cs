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
    public partial class CreatePlaylistForm : Form
    {
        private MusicPlayer musicplayer;

        private void UpdateSongList()
        {
            lbSongs.Items.Clear();
            lbSongs.BeginUpdate();
            foreach (Song s in musicplayer.Songs())
            {
                lbSongs.Items.Add(s);
            }
            lbSongs.EndUpdate();
        }

        public CreatePlaylistForm(MusicPlayer externalmusicplayer)
        {
            InitializeComponent();

            musicplayer = externalmusicplayer;

            UpdateSongList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbName.TextLength < 1)
            {
                MessageBox.Show("Er is geen naam opgegeven!");
                return;
            }

            if(lbSongs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Er zijn geen songs geselecteerd!");
                return;
            }

            foreach (Playlist p in musicplayer.Playlists())
            {
                if (p.Name == tbName.Text)
                {
                    MessageBox.Show("Playlist met dezelfde naam bestaat al!");
                    return;
                }
            }

            Playlist playlist = new Playlist(tbName.Text);

            foreach(Song s in lbSongs.SelectedItems)
            {
                playlist.Add(s);
            }

            musicplayer.Add(playlist);

            this.Close();
        }

        private void CreatePlaylistForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewSong_Click(object sender, EventArgs e)
        {
            new AddSongForm(musicplayer).ShowDialog(this);
            UpdateSongList();
        }
    }
}
