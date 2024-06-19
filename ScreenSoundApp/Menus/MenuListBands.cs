using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuListBands : Menu
{
    public override void ExecuteAsync(Dictionary<string, Band> bandList)
    {
        base.ExecuteAsync(bandList);
        string choiceMenuMessage = "Registered Bands List";

        printTitleOptions(choiceMenuMessage);

        foreach (Band band in bandList.Values)
        {
            Console.WriteLine($"Band: {band.BandName}, Rate: {band.BandAverage}");
        }

        Console.WriteLine("\nPress any key to return...");
        Console.ReadLine();
        return;
    }
}
