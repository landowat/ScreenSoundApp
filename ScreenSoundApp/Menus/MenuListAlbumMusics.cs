using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuListAlbumMusics : Menu
{
    public override void ExecuteAsync(Dictionary<string, Band> bandList)
    {
        base.ExecuteAsync(bandList);
        string choiceMenuMessage = "Listing Album Musics";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Console.Write("Write the Album name: ");
            string bandAlbum = Console.ReadLine()!;

            if (bandList[bandName].Albums.ContainsKey(bandAlbum))
            {
                Console.Clear();
                printTitleOptions(choiceMenuMessage);

                Console.WriteLine($"Band: {bandList[bandName].BandName}\nAlbum: {bandList[bandName].Albums[bandAlbum].AlbumName}\n");

                bandList[bandName].Albums[bandAlbum].ShowAlbumMusics();

                Console.WriteLine("\nPress any key to return...");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine($"The Album {bandAlbum} was not found.");
                Console.ReadLine();
                return;
            }
        }
        else
        {
            Console.WriteLine($"The band {bandName} was not found.");
            Console.WriteLine("\nPress any key to return...");
            Console.ReadLine();
            return;
        }
    }
}
