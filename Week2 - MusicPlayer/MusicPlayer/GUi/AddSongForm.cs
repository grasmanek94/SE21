using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class AddSongForm : Form
    {
        private MusicPlayer musicplayer;

        private void UpdateArtistList()
        {
            lbArtists.Items.Clear();
            lbArtists.BeginUpdate();
            foreach(Artist a in musicplayer.Artists())
            {
                lbArtists.Items.Add(a);
            }
            lbArtists.EndUpdate();
        }

        public AddSongForm(MusicPlayer externalmusicplayer)
        {
            InitializeComponent();

            musicplayer = externalmusicplayer;

            UpdateArtistList();
        }

        private void AddSongForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if(tbName.TextLength < 1)
            {
                MessageBox.Show("De naam van de song mag niet leeg zijn!");
                return;
            }

            if (dtpDate.Value >= DateTime.Now)
            {
                MessageBox.Show("Datum moet in het verleden zijn!");
                return;
            }

            if (lbArtists.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een artiest!");
                return;
            }

            if(tbFilePath.TextLength < 1)
            {
                MessageBox.Show("Het opgegeven bestand bestaat niet of is geen muziek bestand!");
                return;
            }

            FileInfo fi = new FileInfo(tbFilePath.Text);
            if (!fi.Exists || fi.Extension.CompareTo(".mp3") != 0)
            {
                MessageBox.Show("Het opgegeven bestand bestaat niet of is geen mp3 bestand!");
                return;
            }

            foreach (Song s in musicplayer.Songs())
            {
                if (s.PathOfFile == tbFilePath.Text)
                {
                    MessageBox.Show("Song bestaat al!");
                    return;
                }
            }

            Song song = new Song(tbName.Text, dtpDate.Value.Year, (Artist)lbArtists.SelectedItem, tbFilePath.Text);
            if (rtbLyrics.TextLength > 0)
            {
                song.Lyrics = rtbLyrics.Text;
            }

            musicplayer.Add(song);

            this.Close();
        }

        private void btnfilePath_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                tbFilePath.Text = openFileDialog1.FileName;
                if (tbFilePath.TextLength > 0)
                {
                    try 
                    {
                        FileInfo fi = new FileInfo(tbFilePath.Text);
                        if (fi.Exists && fi.Extension.CompareTo(".mp3") == 0)
                        {
                            //File OK
                            TagLib.File musicfile = TagLib.File.Create(tbFilePath.Text);
                            if (musicfile.Tag != null)
                            {
                                if (musicfile.Tag.Year != 0)
                                {
                                    dtpDate.Value = new DateTime((int)musicfile.Tag.Year, 1, 1);
                                }
                                if(musicfile.Tag.Title != null)
                                {
                                    tbName.Text = musicfile.Tag.Title;
                                }

                                //toevoegen van artiest
                                Artist creator = null;

                                if (musicfile.Tag.AlbumArtists.Count() != 0 && musicfile.Tag.AlbumArtists[0] != null)
                                {
                                    string artist = musicfile.Tag.AlbumArtists[0];
                       
                                    foreach (Artist a in musicplayer.Artists())
                                    {
                                        if (a.Name == artist)
                                        {
                                            creator = a;
                                            break;
                                        }
                                    }

                                    if (creator == null)
                                    {
                                        creator = new Artist(artist, DateTime.Now);
                                        musicplayer.Add(creator);
                                        UpdateArtistList();
                                    }

                                    lbArtists.SelectedItem = creator;
                                }
                            }
                        }
                 
                    }
                    catch(ArgumentNullException)
                    {

                    }
                    catch (ArgumentException)
                    {

                    }
                }
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            new AddArtistForm(musicplayer).ShowDialog(this);

            UpdateArtistList();
        }
    }
}
