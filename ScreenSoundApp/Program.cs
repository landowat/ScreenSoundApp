using ScreenSound.Models;

// Creating Bands
Band bandLP = new Band("Linkin Park");
Band bandIra = new Band("Ira");

// Giving rates
bandLP.addRate(10);
bandLP.addRate(8);
bandLP.addRate(9);
bandIra.addRate(10);
bandIra.addRate(6);
bandIra.addRate(8);

// Creating Albums
Album albumLP = new Album("Meteora");
Album albumIra = new Album("Vivendo e Não Aprendendo");

// Vinculating ALbums with Band
bandLP.addAlbum(albumLP);

// Creating music vinculated to the band
Music musicLP = new(bandLP, "Numb", 150);
Music musicLP2 = new(bandLP, "Breaking the Habit", 130, false);
Music musicIra = new(bandIra, "Envelheço na cidade", 150);
Music musicIra2 = new(bandIra, "Dias de luta", 130, false);

// Adding music to album
albumLP.AddMusic(musicLP);
albumLP.AddMusic(musicLP2);
//albumLP.ShowAlbumMusics();

albumIra.AddMusic(musicIra);
albumIra.AddMusic(musicIra2);
//albumIra.ShowAlbumMusics();

/*musicLP.musicDetails();
musicLP2.musicDetails();

Console.WriteLine("\nPress any key to return...");
Console.ReadLine();*/

// Screen Sound Application
string logo = @"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
string welcomeMessage = "Welcome to the Screen Sound Application";

//List<string> bandsList = new List<string>() { "Linkin Park", "Aerosmith", "Evanescence" };
//Dictionary<string, List<int>> bandsListDictionary = new Dictionary<string, List<int>>() { { "Linkin Park", new List<int>() { 10, 1 } }, { "Aerosmith", new List<int>() }, { "Evanescence", new List<int>() } };
List<Band> bandList = new List<Band>();
bandList.Add(bandLP);
bandList.Add(bandIra);

void showWelcomeMessage()
{
    Console.Clear();
    Console.WriteLine("#############################################################################################");
    Console.WriteLine(logo);
    Console.WriteLine("#############################################################################################");
    Console.WriteLine(welcomeMessage);
}

bool menuOptions()
{
    showWelcomeMessage();
    Console.WriteLine("\nPress 1 to register a new Band");
    Console.WriteLine("Press 2 to register a new Album");
    Console.WriteLine("Press 3 to register a new Music");
    Console.WriteLine("Press 4 to show all Bands");
    Console.WriteLine("Press 5 to show all Band Albums");
    Console.WriteLine("Press 6 to show all Musics from Album");
    Console.WriteLine("Press 7 to rate a band");
    Console.WriteLine("Press 8 to show band average");
    Console.WriteLine("Press -1 to leave\n");

    Console.Write("Choose your option: ");
    string choice = Console.ReadLine()!;

    int choiceInt = int.Parse(choice);

    switch (choiceInt)
    {
        case 1:
            registerBand();
            break;
        case 2:
            registerAlbum();
            break;
        case 3:
            registerMusic();
            break;
        case 4:
            listBands();
            break;
        case 5:
            listBandAlbums();
            break;
        case 6:
            listAlbumMusics();
            break;
        case 7:
            rateBand();
            break;
        case 8:
            showBandAverage();
            break;
        case -1: return false;
        default:
            Console.WriteLine("Your choice is [" + choiceInt + "]");
            break;
    }
    return true;
}
void printTitleOption(string message)
{
    int messageSize = message.Length;

    string messageLine = string.Empty.PadLeft(messageSize, '*');

    Console.Clear();
    Console.WriteLine(messageLine);
    Console.WriteLine(message);
    Console.WriteLine(messageLine + "\n");
}

void registerBand()
{
    string choiceMenuMessage = "New Band Registry Option";

    printTitleOption(choiceMenuMessage);

    Console.Write("Write the band name: ");
    Band newBand = new Band(Console.ReadLine()!);

    bandList.Add(newBand);

    printTitleOption(choiceMenuMessage);

    Console.WriteLine($"Band {newBand.BandName} was sucessfully created!");

    Console.WriteLine("\nPress any key to return...");
    Console.ReadLine();
    return;
}

void registerAlbum()
{
    string choiceMenuMessage = "New Album Registry Option";

    printTitleOption(choiceMenuMessage);

    Console.Write("Write the band name: ");
    string bandName = Console.ReadLine()!;

    foreach (Band band in bandList)
    {
        if (band.BandName == bandName)
        {
            Console.Write("Write the Album name: ");
            string bandAlbum = Console.ReadLine()!;
            Album album = new Album(bandAlbum);
            band.addAlbum(album);

            printTitleOption(choiceMenuMessage);

            Console.WriteLine($"Album {bandAlbum} was sucessfully created!");

            Console.WriteLine("\nPress any key to return...");
            Console.ReadLine();
            return;
        }
    }

    Console.WriteLine($"The band {bandName} was not found.");
    Console.WriteLine("\nPress any key to return...");
    Console.ReadLine();
    return;
}

void registerMusic()
{
    string choiceMenuMessage = "New Music Registry Option";

    printTitleOption(choiceMenuMessage);

    Console.Write("Write the band name: ");
    string bandName = Console.ReadLine()!;

    foreach (Band band in bandList)
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

                    printTitleOption(choiceMenuMessage);

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
    return;
}


void listBands()
{
    Console.Clear();
    string choiceMenuMessage = "Registered Bands List";

    printTitleOption(choiceMenuMessage);

    foreach (Band band in bandList)
    {
        Console.WriteLine($"Band: {band.BandName}");
    }

    Console.WriteLine("\nPress any key to return...");
    Console.ReadLine();
    return;
}

void listBandAlbums()
{
    Console.Clear();
    string choiceMenuMessage = "Listing Band Albums";

    printTitleOption(choiceMenuMessage);

    Console.Write("Write the band name: ");
    string bandName = Console.ReadLine()!;

    foreach (Band band in bandList)
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
    return;
}

void listAlbumMusics()
{
    Console.Clear();
    string choiceMenuMessage = "Listing Album Musics";

    printTitleOption(choiceMenuMessage);

    Console.Write("Write the band name: ");
    string bandName = Console.ReadLine()!;

    foreach (Band band in bandList)
    {
        if (band.BandName == bandName)
        {
            Console.Write("Write the Album name: ");
            string bandAlbum = Console.ReadLine()!;

            foreach (Album album in band.Albums)
            {
                if (album.AlbumName == bandAlbum)
                {
                    Console.Clear();
                    printTitleOption(choiceMenuMessage);

                    Console.WriteLine($"Band: {band.BandName}\nAlbum: {album.AlbumName}\n");
                    
                    album.ShowAlbumMusics();

                    Console.WriteLine("\nPress any key to return...");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine($"The Album {bandAlbum} was not found.");
            Console.ReadLine();
            return;
        }
    }

    Console.WriteLine($"The band {bandName} was not found.");
    Console.WriteLine("\nPress any key to return...");
    Console.ReadLine();
    return;
}

void rateBand()
{
    string choiceMenuMessage = "Give a rate to the band";

    printTitleOption(choiceMenuMessage);

    Console.Write("\nWrite the band name: ");
    string bandName = Console.ReadLine()!;

    foreach (Band band in bandList)
    {
        if (band.BandName == bandName)
        {
            int bandGrade = -1;

            while (bandGrade > 10 || bandGrade < 0)
            {
                Console.Write("\nChoose a grade from 0 to 10:");
                bandGrade = int.Parse(Console.ReadLine()!);
            };

            band.addRate(bandGrade);

            Console.WriteLine($"Grade given was {bandGrade}");

            Console.WriteLine("\nPress any key to return...");
            Console.ReadLine();
            return;
        }
    }

    Console.WriteLine($"The band {bandName} was not found.");
    Console.WriteLine("\nPress any key to return...");
    Console.ReadLine();
    return;
}

void showBandAverage()
{
    string choiceMenuMessage = "Band Average Rate";

    printTitleOption(choiceMenuMessage);

    Console.Write("Write the band name: ");
    string bandName = Console.ReadLine()!;

    foreach (Band band in bandList)
    {
        if (band.BandName == bandName)
        {
            Console.WriteLine($"Grade given for {band.BandName} was {band.BandAverage}!");

            Console.WriteLine("\nPress any key to return...");
            Console.ReadLine();
            return;
        }
    }

    Console.WriteLine($"\nThe band {bandName} was not found.");
    Console.WriteLine("\nPress any key to return...");
    Console.ReadLine();
    return;

}

{ } while (menuOptions()) ;

