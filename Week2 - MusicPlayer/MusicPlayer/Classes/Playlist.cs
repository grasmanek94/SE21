using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Playlist
    {
        private List<Song> songs;
        private Song currentlyPlaying;

        public string Name { get; set; }

        /// <summary>
        /// Creat a playlist
        /// </summary>
        /// <param name="name">Name of the playlist</param>
        public Playlist(string name)
        {
            this.Name = name;
            songs = new List<Song>();
            currentlyPlaying = null;
        }

        /// <summary>
        /// Add a song to the playlist
        /// </summary>
        /// <param name="song">The song to add</param>
        public void Add(Song song)
        {
            //if 'Contains' is not allowed:
            //if(!Present(song))
            if (!songs.Contains(song))
            {
                songs.Add(song);
            }        
        }

        /// <summary>
        /// Add a list of songs to the playlist
        /// </summary>
        /// <param name="songs">The list of songs to add</param>
        public void Add(List<Song> songs)
        {
            foreach(Song song in songs)
            {
                //if 'Contains' is not allowed:
                //if(!Present(song))
                if (!this.songs.Contains(song))
                {
                    this.songs.Add(song);
                }
            }
        }

        /// <summary>
        /// Remove a song from the playlist
        /// </summary>
        /// <param name="song">The song to remove</param>
        public void Remove(Song song)
        {
            //if 'Contains' is not allowed:
            //if(Present(song))
            if (songs.Contains(song))
            {
                songs.Remove(song);
            }   
        }

        /// <summary>
        /// Returns the name of the playlist
        /// </summary>
        /// <returns>Name of the playlist</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Plays the first or next song in the playlist
        /// </summary>
        /// <returns>The song that is playing, if nothing is playing returns null</returns>
        public Song PlayFirstOrNextSong()
        {
            if (currentlyPlaying == null || !songs.Contains(currentlyPlaying))
            {
                if (songs.Count() > 0)
                {
                    currentlyPlaying = songs.ElementAt(0);
                }
                else
                {
                    currentlyPlaying = null;
                }
            }
            else
            {
                if (songs.Contains(currentlyPlaying))
                {
                    currentlyPlaying = songs.ElementAt(songs.IndexOf(currentlyPlaying) + 1);
                }
            }
            return currentlyPlaying;
        }

        /// <summary>
        /// Stop playing the playlist
        /// </summary>
        public void StopPlaying()
        {
            currentlyPlaying = null;
        }
        /// <summary>
        /// Get a copy of the songs list
        /// </summary>
        /// <returns>Returns a list of songs in this playlist</returns>
        public List<Song> Songs()
        {
            return new List<Song>(songs);
        }

    }
}
