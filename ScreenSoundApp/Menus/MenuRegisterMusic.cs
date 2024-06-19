using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRegisterMusic : Menu
{
    public override void ExecuteAsync(Dictionary<string, Band> bandList)
    {
        base.ExecuteAsync(bandList);
        string choiceMenuMessage = "New Music Registry Option";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Console.Write("Write the Album name: ");
            string bandAlbum = Console.ReadLine()!;

            if (bandList[bandName].Albums.ContainsKey(bandAlbum)) 
            {
                Console.Write("Write the Music name: ");
                string musicName = Console.ReadLine()!;

                Console.Write("Write the Music duration: ");
                int musicDuration = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Prime Music? (true or false)");
                bool musicPrime = bool.Parse(Console.ReadLine()!);

                Music music = new Music(bandList[bandName], musicName, musicDuration, musicPrime);
                bandList[bandName].Albums[bandAlbum].AddMusic(music);

                printTitleOptions(choiceMenuMessage);

                Console.WriteLine($"Music {musicName} added to the Album {bandAlbum}!");

                Console.WriteLine("\nPress any key to return...");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine($"Album {bandAlbum} not found!");

                Console.WriteLine("\nPress any key to return...");
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
