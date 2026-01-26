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

            try
            {
                switch (sCommand.Name.ToLower())
                {
                    case "help":
                        Console.WriteLine("Test3");
                        await Connection.oClient.SendMessageAsync(sChannel, "Hier ist noch nichts vorhanden");
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