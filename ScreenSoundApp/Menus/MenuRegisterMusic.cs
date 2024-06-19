using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRegisterMusic : Menu
{
    public override void Execute(Dictionary<string, Band> bandList)
    {
        base.Execute(bandList);
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

        /*foreach (Band band in bandList)
        {
            if (band.BandName == bandName)
            {
                Console.Write("Write the Album name: ");
                string bandAlbum = Console.ReadLine()!;

                foreach (Album album in band.Albums)
                {
                    if (album.AlbumName == bandAlbum)
                    {
                        Console.Write("Write the Music name: ");
                        string musicName = Console.ReadLine()!;

                        Console.Write("Write the Music duration: ");
                        int musicDuration = int.Parse(Console.ReadLine()!);

                        Console.WriteLine("Prime Music? (true or false)");
                        bool musicPrime = bool.Parse(Console.ReadLine()!);

                        Music music = new Music(band, musicName, musicDuration, musicPrime);
                        album.AddMusic(music);

                        printTitleOptions(choiceMenuMessage);

                        Console.WriteLine($"Music {musicName} added to the Album {album.AlbumName}!");

                        Console.WriteLine("\nPress any key to return...");
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine($"Album {bandAlbum} not found!");

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
