using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRegisterAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> bandList)
    {
        base.Execute(bandList);
        string choiceMenuMessage = "New Album Registry Option";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Console.Write("Write the Album name: ");
            string bandAlbum = Console.ReadLine()!;
            Album album = new Album(bandAlbum);
            bandList[bandName].addAlbum(album);

            printTitleOptions(choiceMenuMessage);

            Console.WriteLine($"Album {bandAlbum} was sucessfully created!");

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
                Console.Write("Write the Album name: ");
                string bandAlbum = Console.ReadLine()!;
                Album album = new Album(bandAlbum);
                band.addAlbum(album);

                printTitleOptions(choiceMenuMessage);

                Console.WriteLine($"Album {bandAlbum} was sucessfully created!");

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
