using ScreenSoundApp.Models;

internal interface IRate
{
    double BandAverage { get; }

    void AddRate(Rating rate);
}