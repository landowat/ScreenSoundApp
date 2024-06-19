using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRateAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> bandList)
    {
        base.Execute(bandList);
        string choiceMenuMessage = "Rating Band Albums";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Console.Write("Write the album name: ");
            string bandAlbum = Console.ReadLine()!;

            if (bandList[bandName].Albums.ContainsKey(bandAlbum))
            {
                Console.Write("\nChoose a grade from 0 to 10:");
                Rating albumGrade = Rating.Parse(Console.ReadLine()!);

                bandList[bandName].Albums[bandAlbum].AddRate(albumGrade);

                Console.WriteLine($"Grade given was {albumGrade.Rate}");

                Console.WriteLine("\nPress any key to return...");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine($"The band {bandAlbum} was not found.");
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
                Console.Write("Write the album name: ");
                string bandAlbum = Console.ReadLine()!;

                foreach (Album album in band.Albums)
                {
                    if (album.AlbumName == bandName)
                    {
                        Console.Write("\nChoose a grade from 0 to 10:");
                        Rating albumGrade = Rating.Parse(Console.ReadLine()!);

                        album.AddRate(albumGrade);

                        Console.WriteLine($"Grade given was {albumGrade.Rate}");

                        Console.WriteLine("\nPress any key to return...");
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine($"The band {bandAlbum} was not found.");
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
