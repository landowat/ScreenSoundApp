namespace ScreenSoundApp.Models;

internal class Music : IRate
{
    public Music(Band band, string? musicName, int duration, bool available = true)
    {
        Artist = band;
        MusicName = musicName;
        Duration = duration;
        Available = available;
    }

    private List<Rating> rates = new ();
    public string? MusicName { get; }
    public Band Artist { get; }
    public int Duration { get; }
    public bool Available { get; }
    public string MusicDescription => $"The Music {MusicName} belongs to {Artist}";

    public double BandAverage 
    {   
        get
        {
            if (rates.Any()) { return rates.Average(rt => rt.Rate); }
            else { return 0; }
        }
    }

    public void AddRate(Rating rate)
    {
        rates.Add(rate);
    }

    public void musicDetails()
    {
        Console.WriteLine($"\nMusic: {MusicName}");
        Console.WriteLine($"Artist: {Artist.BandName}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Rate: {BandAverage}");

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

