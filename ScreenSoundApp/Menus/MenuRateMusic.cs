using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRateMusic : Menu
{
    public override void ExecuteAsync(Dictionary<string, Band> bandList)
    {
        base.ExecuteAsync(bandList);
        string choiceMenuMessage = "Rating Music";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Console.Write("Write the album name: ");
            string bandAlbum = Console.ReadLine()!;

            if (bandList[bandName].Albums.ContainsKey(bandAlbum))
            {
                Console.Write("Write the music name: ");
                string albumMusic = Console.ReadLine()!;

                foreach (Music music in bandList[bandName].Albums[bandAlbum].musics)
                {
                    if (music.MusicName == albumMusic)
                    {
                        Console.Write("\nChoose a grade from 0 to 10:");
                        Rating musicGrade = Rating.Parse(Console.ReadLine()!);

                        music.AddRate(musicGrade);

                        Console.WriteLine($"Grade given was {musicGrade.Rate}");

                        Console.WriteLine("\nPress any key to return...");
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine($"The music {albumMusic} was not found.");
                Console.WriteLine("\nPress any key to return...");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine($"The Album {bandAlbum} was not found.");
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
