namespace ScreenSound.Models;

internal class Band
{
    public Band(string bandName )
    {
        BandName = bandName;
    }

    public List<Album> Albums = new List<Album>();
    public List<int> Rates = new List<int>();
    public string? BandName { get; }
    public double BandAverage 
    {
        get
        {
            if (!Rates.Any())
            {
                return 0;
            }
            else
            {
                return Rates.Average();
            }
        }
    }

    public void addAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void addRate(int rate)
    {
        Rates.Add(rate);
    }
}