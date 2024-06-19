namespace ScreenSoundApp.Models;

public class Rating
{
    public int Rate { get; }

    public Rating(int rate)
    {
        Rate = rate;
    }

    public static Rating Parse(string input)
    {
        int rate = int.Parse(input);
        return new Rating(rate);
    }
}
