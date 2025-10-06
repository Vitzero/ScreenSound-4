using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filters;

List<Song> retornaListaSonsTons(List<Song> listaSons, string tom)
{
    var songsCSharp = listaSons.Where(s => s.Tone == tom).ToList();

    return songsCSharp;
}

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var songs = JsonSerializer.Deserialize<List<Song>>(response)!;

        //LinqOrder.ShowOrderListArtist(songs);
        //LinqOrder.ShowGenresPerArtist("rock", songs);
        //LinqOrder.ShowSongsPerArtist("U2", songs);
        //LinqOrder.ShowSongsPerYear(2012, songs);

        //filter
        //LinqOrder.ShowAllGenres(songs);

        var FavoriteSongsVitor = new FavoriteSongs("Vitor");
        FavoriteSongsVitor.AddFavoriteMusic(songs[234]);
        FavoriteSongsVitor.AddFavoriteMusic(songs[654]);
        FavoriteSongsVitor.AddFavoriteMusic(songs[356]);
        FavoriteSongsVitor.AddFavoriteMusic(songs[112]);
        FavoriteSongsVitor.AddFavoriteMusic(songs[511]);

        FavoriteSongsVitor.ShowFavoriteSongs();

        FavoriteSongsVitor.CreateJsonWithSongs();

        //foreach (var song in songs)
        //{
        //    song.ShowDetailsOfSong();
        //    Console.WriteLine();
        //}
        var x = retornaListaSonsTons(songs, "C#");

        foreach (var somComTonalidadeCsharp in x)
        {
            somComTonalidadeCsharp.ShowDetailsOfSong();
            Console.WriteLine();
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
