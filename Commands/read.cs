using TwitchLib.Client.Events;

namespace Commands
{
    public class read
    {
        public static async Task Client_OnChatCommandReceivedAsync(object? oSender, OnChatCommandReceivedArgs oOnChatCommandReceivedArgs)
        {
            string sChannel = oOnChatCommandReceivedArgs.ChatMessage.Channel;
            string sID = oOnChatCommandReceivedArgs.ChatMessage.Id;
            var sCommand = oOnChatCommandReceivedArgs.Command;
            List<string> vsCommands = new List<string>() { "0" };
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
                        int.TryParse(vsCommands[0], out nTimerInSeconds);

                        Console.WriteLine($"Timer: {nTimerInSeconds}");
                        break;
                    case "lurk":
                        await Connection.oClient.SendReplyAsync(sChannel, sID, "Hey, vielen Dank für dein Lurk! :3");
                        break;
                    case "dc":
                        await Connection.oClient.SendReplyAsync(sChannel, sID, "Klicke auf den Link um den Discord zu joinen :D \n https://discord.gg/ZnwzVv34jr");
                        break;
                    default:
                        await Connection.oClient.SendReplyAsync("tsukiyamix", sID, "Unknown Command");
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