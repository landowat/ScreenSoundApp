using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRateBand : Menu
{
    public override void Execute(Dictionary<string, Band> bandList)
    {
        base.Execute(bandList);
        string choiceMenuMessage = "Rating Band";

        printTitleOptions(choiceMenuMessage);

        Console.Write("\nWrite the band name: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Console.Write("\nChoose a grade from 0 to 10:");
            Rating bandGrade = Rating.Parse(Console.ReadLine()!);

            bandList[bandName].addRate(bandGrade);

            Console.WriteLine($"Grade given was {bandGrade.Rate}");

            Console.WriteLine("\nPress any key to return...");
            Console.ReadLine();
            return;
        }

        /*foreach (Band band in bandList)
        {
            if (band.BandName == bandName)
            {
                Console.Write("\nChoose a grade from 0 to 10:");
                Rating bandGrade = Rating.Parse(Console.ReadLine()!);

                band.addRate(bandGrade);

                Console.WriteLine($"Grade given was {bandGrade.Rate}");

                Console.WriteLine("\nPress any key to return...");
                Console.ReadLine();
                return;
            }
        }

        Console.WriteLine($"The band {bandName} was not found.");
        Console.WriteLine("\nPress any key to return...");
        Console.ReadLine();
        return;*/
    }
}
