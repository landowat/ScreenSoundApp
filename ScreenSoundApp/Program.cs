using ScreenSoundApp.Models;
using ScreenSoundApp.Menus;

// Creating Bands
Band bandLP = new Band("Linkin Park");
Band bandIra = new Band("Ira");

// Giving rates
bandLP.addRate(Rating.Parse("10"));
bandLP.addRate(Rating.Parse("8"));
bandLP.addRate(Rating.Parse("9"));
bandIra.addRate(Rating.Parse("10"));
bandIra.addRate(Rating.Parse("6"));
bandIra.addRate(Rating.Parse("8"));

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

albumIra.AddMusic(musicIra);
albumIra.AddMusic(musicIra2);

//List<Band> bandList = new List<Band>();
Dictionary<string, Band> bandList = new Dictionary<string, Band>();
bandList.Add(bandLP.BandName!, bandLP);
bandList.Add(bandIra.BandName!, bandIra);

Dictionary<int, Menu> menuList = new Dictionary<int, Menu>() {
    { 1, new MenuRegisterBand() },
    { 2, new MenuRegisterAlbum() },
    { 3, new MenuRegisterMusic() },
    { 4, new MenuListBands() },
    { 5, new MenuListBandAlbums() },
    { 6, new MenuListAlbumMusics() },
    { 7, new MenuRateBand() },
    { 8, new MenuRateAlbum() },
    { 9, new MenuRateMusic() },
};

bool menuOptions()
{
    Menu.showWelcomeMessage();

    Console.Write("Choose your option: ");
    string choice = Console.ReadLine()!;

    int choiceInt = int.Parse(choice);

    if (menuList.ContainsKey(choiceInt))
    {
        Menu menu = menuList[choiceInt];
        menu.ExecuteAsync(bandList);
    }
    else if (choiceInt == -1)
    {
        Console.Write("\nLeaving the application\n");

        return false;
    }
    else
    {
        Console.Write("\nInvalid Option");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
    }

    return true;
}

do
{ }
while (menuOptions());

