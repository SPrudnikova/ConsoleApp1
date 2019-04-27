using System;
using Helpers;
using Newtonsoft.Json;

namespace hw_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = UserInput.RequestInput("Enter song name, please");
            string author = UserInput.RequestInput("Enter song author name, please");
            int year = UserInput.RequestInteger("Enter song creation year, please");
            int duration = UserInput.RequestInteger("Enter song duration in seconds, please");
            Song.Genres genre = UserInput.RequestEnumValue<Song.Genres>("Enter song genre, please");

            Song song = new Song(name, author, year, duration, genre);
            var songData = Song.GetSongData(song);

            Console.WriteLine(songData);
            Console.WriteLine(song.Genre);
            Console.WriteLine(JsonConvert.SerializeObject(songData));

            Console.Read();
        }
    }
}
