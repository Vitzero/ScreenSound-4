using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    internal class FavoriteSongs
    {
        public string? Name{get; set; }

        public List<Song> ListOfFavoriteSongs { get;  }

        public FavoriteSongs(string name, List<Song> songs)
        {
            Name = name;
            ListOfFavoriteSongs = songs;
        }

        public void AddFavoriteMusic(Song song)
        {
            ListOfFavoriteSongs.Add(song);
        }

        public void ShowFavoriteSongs()
        {
            foreach (var song in ListOfFavoriteSongs){ Console.WriteLine($"- Name song: {song.Name} by artist: {song.Artist}"); }
        }



    }
}
