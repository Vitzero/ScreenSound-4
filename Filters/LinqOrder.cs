using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Filters
{
    internal class LinqOrder
    {
        public static void ShowAllGenres(List<Song> songs)
        {
            var AllGenresMusic = songs.Select(s => s.Genre)
                .Distinct()
                .ToList();

            foreach(var s in AllGenresMusic)
            {
                Console.WriteLine($"{s}");
            }
        }

        public static void ShowOrderListArtist(List<Song> Songs)
        {
            var OrderedArtists = Songs.OrderBy(song => song.Artist)
                .Select(song => song.Artist)
                .Distinct()
                .ToList();

            Console.WriteLine("Artist list ordered:");

            foreach (var Artist in OrderedArtists)
            {
                Console.WriteLine($"- {Artist}");
            }
        }

        public static void ShowGenresPerArtist(string genre, List<Song> songs)
        {
            var FilteredGenres = songs.Where(songs => songs.Genre!.Contains(genre))
                .OrderBy(songs => songs.Artist)
                .Select(songs => songs.Artist)
                .Distinct()
                .ToList();

            Console.WriteLine("Show Artist per genres:");

            foreach (var Artist in FilteredGenres) { Console.WriteLine($"- {Artist}"); }
        }

        public static void ShowSongsPerArtist(string artist, List<Song> songs)
        {
            var FilteredArtists = songs.Where(songs => songs.Artist!.Equals(artist))
                .OrderBy (songs => songs.Name)
                .ToList();

            Console.WriteLine($"Show songs from {artist}:");
            foreach (var Artist in FilteredArtists) { Console.WriteLine($"- {Artist.Name}");  }
        }

        public static void ShowSongsPerYear(int year, List<Song> songs)
        {
            var FilteredByYear = songs.Where(s => s.Year == year)
                .ToList();
            Console.WriteLine($"Songs from year {year}");
            foreach (var item in FilteredByYear) Console.WriteLine($"- {item.Name} | by {item.Artist}");
        }
    }
}
