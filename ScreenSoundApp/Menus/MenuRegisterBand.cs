using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRegisterBand : Menu
{
    public override void ExecuteAsync(Dictionary<string, Band> bandList)
    {
        base.ExecuteAsync(bandList);
        string choiceMenuMessage = "New Band Registry Option";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        Band newBand = new Band(Console.ReadLine()!);

        bandList.Add(newBand.BandName!, newBand);

        printTitleOptions(choiceMenuMessage);

        Console.WriteLine($"Band {newBand.BandName} was sucessfully created!");

        Console.WriteLine("\nPress any key to return...");
        Console.ReadLine();
        return;
    }
}
