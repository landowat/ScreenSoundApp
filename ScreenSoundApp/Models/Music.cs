namespace ScreenSound.Models;

internal class Music
{
    public Music(Band band, string? musicName, int duration, bool available = true)
    {
        Artist = band;
        MusicName = musicName;
        Duration = duration;
        Available = available;
    }

    public string? MusicName { get; }
    public Band Artist { get; }
    public int Duration { get; }
    public bool Available { get; }
    public string MusicDescription => $"The Music {MusicName} belongs to {Artist}";
    public void musicDetails()
    {
        Console.WriteLine($"\nMusic: {MusicName}");
        Console.WriteLine($"Artist: {Artist.BandName}");
        Console.WriteLine($"Duration: {Duration}");

        if (Available)
        {
            Console.WriteLine($"Status: Music {MusicName} available!");
        }
        else
        {
            Console.WriteLine($"Status: Music {MusicName} unavailable, ScreenSound Prime required!");
        }
    }
}

