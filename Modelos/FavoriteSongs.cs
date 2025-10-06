using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    internal class FavoriteSongs
    {
        public string? Name{get; set; }

        public List<Song> ListOfFavoriteSongs { get;  }

        public FavoriteSongs(string name)
        {
            Name = name;
            ListOfFavoriteSongs = new List<Song>();
        }

        public void AddFavoriteMusic(Song song)
        {
            ListOfFavoriteSongs.Add(song);
        }

        public void ShowFavoriteSongs()
        {
            Console.WriteLine($"Favorites Songs -> {Name}");
            foreach (var song in ListOfFavoriteSongs){ Console.WriteLine($"- Name song: {song.Name} by artist: {song.Artist}"); }
            Console.WriteLine();
        }

        public void CreateJsonWithSongs()
        {
            string json = JsonSerializer.Serialize( new
            {
                name = Name,
                songs = ListOfFavoriteSongs
            });
            string fileName = $"Favorite-songs-{Name}.json";

            File.WriteAllText(fileName, json);
            Console.WriteLine($"Json was succesfully created! {Path.GetFullPath(fileName)}");
        }

    }
}
