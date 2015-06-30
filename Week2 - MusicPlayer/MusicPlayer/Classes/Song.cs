using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string PathOfFile { get; set; }
        public string Lyrics { get; set; }
        public Artist Preformer { get; set; }

        /// <summary>
        /// Create a song
        /// </summary>
        /// <param name="name">Name of the Song</param>
        /// <param name="year">Year of the Song</param>
        /// <param name="artist">Name of the preformer</param>
        /// <param name="pathOfFile">Path to the file</param>
        public Song(string name, int year, Artist artist, string pathOfFile)
        {
            Name = name;
            Year = year;
            PathOfFile = pathOfFile;
            Preformer = artist;

            artist.Add(this);
        }

        /// <summary>
        /// Get the song Name, Preformer Name, and the year
        /// </summary>
        /// <returns>The name of the Song, Preformer, and the year of the song</returns>
        public override string ToString()
        {
            return Name + " - " + Preformer.Name.ToString() + " (" + Year.ToString() + ")";
        }
    }
}
