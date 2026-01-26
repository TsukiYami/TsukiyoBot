using TwitchLib.Client.Events;
using TwitchLib.Communication.Interfaces;

namespace Commands
{
    public class read
    {
        public static async Task Client_OnChatCommandReceivedAsync(object? oSender, OnChatCommandReceivedArgs oOnChatCommandReceivedArgs)
        {
            string sChannel = oOnChatCommandReceivedArgs.ChatMessage.Channel;
            var sCommand = oOnChatCommandReceivedArgs.Command;
            int nCounter = 5;
            const string sAddModName = "ShiroKitsuneLP";

            try
            {
                switch (sCommand.Name.ToLower())
                {
                    case "help":
                        Console.WriteLine("Test3");
                        await Connection.oClient.SendMessageAsync(sChannel, "Hier ist noch nichts vorhanden");
                        break;
                    case "death":
                        Console.WriteLine("Counter um 1 erhöht");
                        nCounter++;
                        await Connection.oClient.SendMessageAsync(sChannel, $"Counter wurde um 1 erhöht. Der aktuelle Counter beträgt {nCounter}");
                        break;
                    case "mod":
                        Console.WriteLine("Added Mod / deleted mod");
                        await Connection.oClient.SendMessageAsync(sChannel, $"/mod {sAddModName}");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}