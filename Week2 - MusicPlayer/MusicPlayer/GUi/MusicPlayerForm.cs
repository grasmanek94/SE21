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
    public partial class MusicPlayerForm : Form
    {
        private MusicPlayer musicplayer;
        private Timer labelUpdater;

        public MusicPlayerForm()
        {
            InitializeComponent();

            musicplayer = new MusicPlayer();

            //Uncomment the line below to add fake songs
            //InitializeTestData();

            labelUpdater = new Timer();

            labelUpdater.Interval = 100;

            labelUpdater.Tick += labelUpdater_Tick;

            labelUpdater.Start();
        }

        private void labelUpdater_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabels();
        }

        private void InitializeTestData()
        {
            Artist[] artist = new Artist[4];

            artist[0] = new Artist("artiest 1", DateTime.Now);
            artist[1] = new Artist("artiest 2", DateTime.Now);
            artist[2] = new Artist("artiest 3", DateTime.Now);
            artist[3] = new Artist("artiest 4", DateTime.Now);

            foreach (Artist a in artist)
            {
                musicplayer.Add(a);
            }

            Song[] song = new Song[16];

            song[0] = (new Song("song 1", 2015, artist[0], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[1] = (new Song("song 2", 2015, artist[0], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[2] = (new Song("song 3", 2015, artist[0], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[3] = (new Song("song 4", 2015, artist[0], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
    
            song[4] = (new Song("song 5", 2015, artist[1], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[5] = (new Song("song 6", 2015, artist[1], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[6] = (new Song("song 7", 2015, artist[1], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[7] = (new Song("song 8", 2015, artist[1], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
         
            song[8] = (new Song("song 9", 2015, artist[2], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[9] = (new Song("song 10", 2015, artist[2], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[10] = (new Song("song 11", 2015, artist[2], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[11] = (new Song("song 12", 2015, artist[2], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
       
            song[12] = (new Song("song 13", 2015, artist[3], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[13] = (new Song("song 14", 2015, artist[3], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[14] = (new Song("song 15", 2015, artist[3], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));
            song[15] = (new Song("song 16", 2015, artist[3], @"C:\Downloads\Audiomachine - Chronicles 2012\02 - Reaching.mp3"));


            foreach (Song s in song)
            {
                musicplayer.Add(s);
            }

            Playlist[] playlist = new Playlist[2];

            playlist[0] = new Playlist("list 1");
            playlist[1] = new Playlist("list 2");

            for (int p = 0; p < 2; ++p)
            {
                for (int i = 0; i < 8; ++i)
                {
                    playlist[p].Add(song[p * 8 + i]);
                }
            }

            foreach (Playlist p in playlist)
            {
                musicplayer.Add(p);
            }

            UpdateArtistList();
            UpdateSongList();
            UpdatePlayList();
        }

        private void UpdateArtistList()
        {
            lbArtists.Items.Clear();
            lbArtists.BeginUpdate();
            foreach (Artist a in musicplayer.Artists())
            {
                lbArtists.Items.Add(a);
            }
            lbArtists.EndUpdate();
        }

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

        private void UpdatePlayList()
        {        
            tcPlayLists.TabPages.Clear();
            foreach (Playlist p in musicplayer.Playlists())
            {
                tcPlayLists.TabPages.Add(p.Name, p.Name);
                tcPlayLists.SelectTab(tcPlayLists.TabPages.IndexOfKey(p.Name));

                TabPage page = tcPlayLists.SelectedTab;
                ListBox box = new ListBox();

                box.Top = 0;
                box.Left = 0;
                box.Size = page.Size;
                box.DoubleClick += tcPlayListsListBox_DoubleClick;

                page.Controls.Add(box);

                foreach(Song s in p.Songs())
                {
                    box.Items.Add(s);
                }
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            new AddArtistForm(musicplayer).ShowDialog(this);
            UpdateArtistList();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            new AddSongForm(musicplayer).ShowDialog(this);
            UpdateArtistList();
            UpdateSongList();
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            new CreatePlaylistForm(musicplayer).ShowDialog(this);
            UpdateArtistList();
            UpdateSongList();
            UpdatePlayList();
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            musicplayer.StopPlaying();
            currentposLabel.Text = "0:00";
            remainingLabel.Text = "0:00";
            this.Text = "Muziek Speler 2015";
        }

        private string SecondsToStringFormat(double value)
        {
            int minutes = (int)Math.Floor(value/60.0);
            int seconds = (int)(value - ((double)minutes * 60.0));

            return minutes.ToString() + ":" + seconds.ToString("D2");//0:00
        }

        private void UpdateTimeLabels()
        {
            double max = musicplayer.MaxPosition();
            double current = musicplayer.Position();

            timeTracker.Minimum = 0;
            timeTracker.Maximum = 10 * (int)max;//allow tenth second resolution

            currentposLabel.Text = SecondsToStringFormat(current);
            remainingLabel.Text = SecondsToStringFormat(max - current);

            timeTracker.Value = (int)(current * 10.0);
        }

        private void ListBoxPlay(ListBox box)
        {
            Song song = (Song)box.SelectedItem;
            if (song != null && musicplayer.Songs().Contains(song))
            {
                musicplayer.Play(song);
                UpdateTimeLabels();
                this.Text = "Muziek Speler 2015 - Now Playing: " + song.ToString();
            }
        }

        private void lbSongs_DoubleClick(object sender, EventArgs e)
        {
            ListBoxPlay(lbSongs);
        }

        private void tcPlayLists_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tcPlayListsListBox_DoubleClick(object sender, EventArgs e)
        {
            ListBox box = (ListBox)sender;
            ListBoxPlay(box);
        }

        private void btnRemoPlaylist_Click(object sender, EventArgs e)
        {
            TabPage page = tcPlayLists.SelectedTab;
            foreach(Playlist p in musicplayer.Playlists())
            {
                if(p.Name == page.Name)
                {
                    musicplayer.Remove(p);
                    UpdatePlayList();
                    break;
                }
            }
        }

        private void timeTracker_Scroll(object sender, EventArgs e)
        {
            musicplayer.Position((double)timeTracker.Value / 10.0);
        }

        /// <summary>
        /// Set the volume  of the media player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            musicplayer.Volume(trackBar1.Value);
        }
    }
}
