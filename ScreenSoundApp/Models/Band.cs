namespace ScreenSoundApp.Models;

internal class Band : IRate
{
    public Band(string bandName )
    {
        BandName = bandName;
    }

    public Dictionary<string, Album> Albums = new Dictionary<string, Album>();
    public List<Rating> Rates = new ();
    public string? BandName { get; }
    public string? Summary { get; set; }
    public double BandAverage 
    {
        get
        {
            if (!Rates.Any()) return 0;
            else return Rates.Average(i => i.Rate);
        }
    }

    public void addAlbum(Album album)
    {
        Albums.Add(album.AlbumName!, album);
    }

    public void addRate(Rating rate)
    {
        Rates.Add(rate);
    }

    public void AddRate(Rating rate)
    {
        throw new NotImplementedException();
    }
}