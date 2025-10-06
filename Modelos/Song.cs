using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Song
{
    [JsonPropertyName("key")]
    private string[] tone = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("year")]
    public string YearStr { get; set; }

    public int Year 
    {
        get
        {
            return int.Parse(YearStr!);
        }
    }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tone {
        get
        {
            return tone[Key];
        }
    }
    public void ShowDetailsOfSong()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Song: {Name}");
        Console.WriteLine($"Duration in seconds: {Duration /1000}");
        Console.WriteLine($"Musical genre: {Genre}");
        Console.WriteLine($"Tone: {Tone}");
    }
}
