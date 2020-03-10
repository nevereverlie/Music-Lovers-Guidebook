using System;

namespace MusicLoversGuide
{
    [Serializable]
    public class Song
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Lyrics { get; set; }

        public Song() { }
        public Song(string artist, string album, string name, string year, string genre, string lyrics)
        {
            Artist = artist;
            Album = album;
            Name = name;
            Year = year;
            Genre = genre;
            Lyrics = lyrics;
        }
    }//Song
}
