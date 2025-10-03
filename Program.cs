using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filters;

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


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
