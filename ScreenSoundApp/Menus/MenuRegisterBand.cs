//using OpenAI_API;
using ScreenSoundApp.Models;

namespace ScreenSoundApp.Menus;

internal class MenuRegisterBand : Menu
{
    public override void ExecuteAsync(Dictionary<string, Band> bandList)
    {
        base.ExecuteAsync(bandList);
        string choiceMenuMessage = "New Band Registry Option";

        printTitleOptions(choiceMenuMessage);

        Console.Write("Write the band name: ");
        Band newBand = new Band(Console.ReadLine()!);

        /*var client = new OpenAIAPI("sk-proj-erkbxgsk2u7KeHVT3rSpT3BlbkFJ8H9jI4K8ndIV1u61dcr8");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Give 1 paragraph summary of {newBand.BandName} band");

        string response = chat.GetResponseFromChatbotAsync()
            .GetAwaiter()
            .GetResult();

        newBand.Summary = response;*/

        bandList.Add(newBand.BandName!, newBand);

        printTitleOptions(choiceMenuMessage);

        Console.WriteLine($"Band {newBand.BandName} was sucessfully created!");

        Console.WriteLine("\nPress any key to return...");
        Console.ReadLine();
        return;
    }
}
