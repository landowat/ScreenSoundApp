namespace ScreenSoundApp.Models;

internal class Album : IRate
{
    public Album(string albumName)
    {
        AlbumName = albumName;
    }

    public List<Music> musics = new List<Music>();
    public List<Rating> Rates = new ();
    public string? AlbumName { get; }
    public int DuracaoTotal => musics.Sum(music => music.Duration);
    public double BandAverage 
    { 
        get
        {   
            if (Rates.Any()) return Rates.Average(rt => rt.Rate);
            else return 0;
        }
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumMusics()
    {
        foreach (Music music in musics)
        {
            Console.WriteLine($"Music: {music.MusicName}, Duration: {music.Duration} seconds, Rate: {music.BandAverage}");
        }
        Console.WriteLine($"\nThe {AlbumName} Album has a total duration of {DuracaoTotal} seconds");
    }

    public void AddRate(Rating rate)
    {
        Rates.Add(rate);
    }
}