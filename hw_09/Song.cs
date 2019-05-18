using System;

namespace hw_09
{
    class Song
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public int Duration { get; private set; }
        public Genres Genre { get; private set; }

        public Song (string name, string author, int year, int duration, Genres genre)
        {
            Name = name;
            Author = author;
            Year = year;
            Duration = duration;
            Genre = genre;
        }

        public static dynamic GetSongData (Song song)
        {
            double songDurationInMinutes = song.Duration / Constants.SecondsInMinute;

            return new
            {
                Title = song.Name,
                AlbumYear = song.Year,
                Minutes = Math.Round(songDurationInMinutes, 2)
            };
        }

        public enum Genres
        {
            Pop,
            Rock,
            Сountry,
            Jazz,
            Blues
        }
    }
}
