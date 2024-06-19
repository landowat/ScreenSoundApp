using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class Menu
{
    private static string Logo => @"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
    private static string WelcomeMessage => "Welcome to the Screen Sound Application";

    public static void showWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine("#############################################################################################");
        Console.WriteLine(Logo);
        Console.WriteLine("#############################################################################################");
        Console.WriteLine(WelcomeMessage);

        Console.WriteLine("\nPress 1 to register a new Band");
        Console.WriteLine("Press 2 to register a new Album");
        Console.WriteLine("Press 3 to register a new Music");
        Console.WriteLine("Press 4 to show all Bands");
        Console.WriteLine("Press 5 to show all Band Albums");
        Console.WriteLine("Press 6 to show all Musics from Album");
        Console.WriteLine("Press 7 to rate a Band");
        Console.WriteLine("Press 8 to rate a Album");
        Console.WriteLine("Press 9 to rate a Music");
        Console.WriteLine("Press -1 to leave\n");
    }

    public void printTitleOptions(string message)
    {
        int messageSize = message.Length;

        string messageLine = string.Empty.PadLeft(messageSize, '*');

        Console.WriteLine(messageLine);
        Console.WriteLine(message);
        Console.WriteLine(messageLine + "\n");
    }

    public virtual void ExecuteAsync(Dictionary<string, Band> bandList)
    {
        Console.Clear();
    }
}
