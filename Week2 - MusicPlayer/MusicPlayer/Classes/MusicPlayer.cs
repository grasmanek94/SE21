using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class MusicPlayer
    {
        private List<Artist> artists;
        private List<Song> songs;
        private List<Playlist> playlists;

        private Song currentlyPlaying;
        private Playlist currentlyPlayingList;

        private WMPLib.WindowsMediaPlayer wplayer;

        /// <summary>
        /// Get a copy of the Artists list
        /// </summary>
        /// <returns>a copy of the Artists list</returns>
        public List<Artist> Artists()
        {
            return new List<Artist>(artists);
        }

        /// <summary>
        /// Get a copy of the Sons list
        /// </summary>
        /// <returns>a copy of the Sons list</returns>
        public List<Song> Songs()
        {
            return new List<Song>(songs);
        }

        /// <summary>
        /// Get a copy of the Playlists list
        /// </summary>
        /// <returns>a copy of the Playlists list</returns>
        public List<Playlist> Playlists()
        {
            return new List<Playlist>(playlists);
        }

        /// <summary>
        /// Construct the Music Player
        /// </summary>
        public MusicPlayer()
        {
            artists = new List<Artist>();
            songs = new List<Song>();
            playlists = new List<Playlist>();

            wplayer = new WMPLib.WindowsMediaPlayer();

            currentlyPlaying = null;
            currentlyPlayingList = null;
        }

        /// <summary>
        /// Add a song to the list Songs
        /// </summary>
        /// <param name="song">The Song to add to the list</param>
        public void Add(Song song)
        {
            if (!songs.Contains(song))
            {
                songs.Add(song);
            }
        }

        /// <summary>
        /// Add an artist
        /// </summary>
        /// <param name="artist">The Artist to add to the list</param>
        public void Add(Artist artist)
        {
            if (!artists.Contains(artist))
            {
                artists.Add(artist);
            }
        }

        /// <summary>
        /// Add a playlist
        /// </summary>
        /// <param name="playlist">The Playlist to add to the list</param>
        public void Add(Playlist playlist)
        {
            if (!playlists.Contains(playlist))
            {
                playlists.Add(playlist);
            }
        }

        /// <summary>
        /// Remove a playlist
        /// </summary>
        /// <param name="playlist">The playlist to remove from the list</param>
        public void Remove(Playlist playlist)
        {
            if(playlists.Contains(playlist))
            {
                playlists.Remove(playlist);
            }
        }
        
        /// <summary>
        /// Plays a MP3 file by the Path of File
        /// </summary>
        /// <param name="song">The song to play, if this is null only stopping the current song will be performed, if not null, the next song will be player</param>
        private void PlayUrl(Song song)
        {
            //the .stop() fixes a bug where the user would switch tracks really fast and the player component would freeze
            wplayer.controls.stop();
            if(song != null)
            {   
                wplayer.URL = song.PathOfFile;
                wplayer.controls.play();              
            }
        }

        /// <summary>
        /// The the volume of the music player
        /// </summary>
        /// <param name="newvolume">The new volume, 0 is mute, 100 is full</param>
        public void Volume(int newvolume)
        {
            wplayer.settings.volume = newvolume;
        }

        /// <summary>
        /// Set the position of the progressbar
        /// </summary>
        /// <param name="newposition">The new position</param>
        public void Position(double newposition)
        {
            wplayer.controls.currentPosition = newposition;
        }

        /// <summary>
        /// Get the position of the progressbar
        /// </summary>
        /// <returns>Double of the position of the pogressbar</returns>
        public double Position()
        {
            return wplayer.controls.currentPosition;
        }

        /// <summary>
        /// Get the max position of the progressbar
        /// </summary>
        /// <returns>Double of the max position</returns>
        public double MaxPosition()
        {
            if (wplayer.controls.currentItem != null)
            {
                return wplayer.controls.currentItem.duration;
            }
            return 0.00;
        }


        /// <summary>
        /// Play a song
        /// </summary>
        /// <param name="song">The song to play</param>
        public void Play(Song song)
        {
            if (currentlyPlayingList != null)
            {
                currentlyPlayingList.StopPlaying();
                currentlyPlayingList = null;
            }

            currentlyPlaying = song;

            PlayUrl(currentlyPlaying);
        }

        /// <summary>
        /// Play a playlist
        /// </summary>
        /// <param name="playlist">The playlist to play</param>
        public void Play(Playlist playlist)
        {
            if(currentlyPlayingList == playlist)
            {
                currentlyPlaying = currentlyPlayingList.PlayFirstOrNextSong();
            }
            else
            {
                if (currentlyPlayingList != null)
                {
                    currentlyPlayingList.StopPlaying();
                }

                currentlyPlayingList = playlist;
                currentlyPlaying = currentlyPlayingList.PlayFirstOrNextSong();
            }

            PlayUrl(currentlyPlaying);
        }

        /// <summary>
        /// Stop playing music
        /// </summary>
        public void StopPlaying()
        {
            Play((Song)null);
        }

        /// <summary>
        /// The song that is currently playing
        /// </summary>
        /// <returns></returns>
        public Song IsPlaying()
        {
            return currentlyPlaying;
        }
    }
}
