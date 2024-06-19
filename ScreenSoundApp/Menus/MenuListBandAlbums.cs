using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuListBandAlbums : Menu
{
    public override void Execute(Dictionary<string, Band> bandList)
    {
        base.Execute(bandList);
        string choiceMenuMessage = "Listing Band Albums";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        string bandName = Console.ReadLine()!;

        if(bandList.ContainsKey(bandName))
        {
            foreach (Album album in bandList[bandName].Albums.Values)
            {
                Console.WriteLine($"Album: {album.AlbumName}, Rate: {album.BandAverage}");
            }
            Console.WriteLine("\nPress any key to return...");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine($"The band {bandName} was not found.");
            Console.WriteLine("\nPress any key to return...");
            Console.ReadLine();
            return;
        }

        /*foreach (Band band in bandList)
        {
            if (band.BandName == bandName)
            {
                foreach (Album album in band.Albums)
                {
                    Console.WriteLine($"Album: {album.AlbumName}");
                }
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
