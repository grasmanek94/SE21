using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    /// <summary>
    /// The main music player class
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// The Artist name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Artist birthday
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// List of the Songs from the Artist
        /// </summary>
        private List<Song> songs;

        /// <summary>
        /// Create an artist
        /// </summary>
        /// <param name="name">Name of the Artist</param>
        /// <param name="birthday">bDay of the Artist</param>
        public Artist(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;

            songs = new List<Song>();
        }

        /// <summary>
        /// Add a Song to the Artist
        /// </summary>
        /// <param name="song">Song from Artist</param>
        public void Add(Song song)
        {
            if (!songs.Contains(song))
            {
                song.Preformer = this;
                songs.Add(song);
            }
        }

        /// <summary>
        /// Get the Name of the Artist
        /// </summary>
        /// <returns>The Name of the Artist</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
