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
            List<string> vsCommands = new List<string>();
            int nCounter = 5;
            int nTimerInSeconds;

            try
            {
                switch (sCommand.Name.ToLower())
                {
                    case "help":
                        Console.WriteLine("Test3");
                        await Connection.oClient.SendMessageAsync(sChannel, "Hier ist noch nichts vorhanden");
                        break;
                    case "counter":
                        Console.WriteLine("Counter um 1 erhöht");
                        nCounter++;
                        await Connection.oClient.SendMessageAsync(sChannel, $"Counter wurde um 1 erhöht. Der aktuelle Counter beträgt {nCounter}");
                        break;
                    case "addtimer":
                        vsCommands = oOnChatCommandReceivedArgs.Command.ArgumentsAsList;
                        foreach (string sItem in vsCommands)
                        {
                            Console.WriteLine($"List Elements: {sItem}");
                        }
                        break;
                    case "lurk":
                        await Connection.oClient.SendMessageAsync(sChannel, "Hey, vielen Dank für dein Lurk! :3");
                        break;
                    default:
                        Console.WriteLine("Unknown command");
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