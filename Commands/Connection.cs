using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace Commands
{
    public class Connection
    {
        private string sBotUsername;
        private string sBotToken;
        private string sTwitchChannel;
        private ConnectionCredentials oCredentials;
        public static TwitchClient oClient;

        public Connection()
        {
            string sJSON = File.ReadAllText("F:\\.coding\\C#\\TsukiyoBot\\Commands\\config.json");
            JObject oConfig = JObject.Parse(sJSON);
            sBotUsername = oConfig["botconfig"]["username"].ToString();
            sBotToken = oConfig["botconfig"]["token"].ToString();
            sTwitchChannel = oConfig["channels"].ToString();

            oCredentials = new ConnectionCredentials(sBotUsername, sBotToken);
            oClient = new TwitchClient();
        }

        public async Task  ConnectionHandler()
        {
            oClient.Initialize(oCredentials, "tsukiyamix");
            await StartBotAsync();
            if(oClient.IsConnected)
            {
                Console.WriteLine("Penis");
            }
            oClient.OnConnected += Client_OnConnectedAsync;
            Console.WriteLine("Test1");
            oClient.OnJoinedChannel += Client_OnJoinedChannelAsync;
            Console.WriteLine("Test2");
            if(oClient.IsInitialized)
            {
                Console.WriteLine("Init");
            }
            oClient.OnMessageReceived += Client_OnChatMessageReceived;
            oClient.OnChatCommandReceived += read.Client_OnChatCommandReceivedAsync;
            Console.WriteLine("Test4");
        }

        private Task OClient_OnMessageReceived(object? sender, OnMessageReceivedArgs e)
        {
            throw new NotImplementedException();
        }

        private static async Task StartBotAsync() {
            await oClient.ConnectAsync();
        }

        private async Task Client_OnConnectedAsync(object? oSender, OnConnectedEventArgs oConnectedEventArgs) {
            await oClient.JoinChannelAsync(sTwitchChannel);
        }

        private async Task Client_OnJoinedChannelAsync(object? oSender, OnJoinedChannelArgs onJoinedChannelArgs) {
            Console.WriteLine("Connected to: " + onJoinedChannelArgs);
            await oClient.SendMessageAsync(sTwitchChannel, "SCHALOM LE BOWSER");
        }

        private async Task Client_OnChatMessageReceived(object? sender, OnMessageReceivedArgs e) {
            Console.WriteLine($"{e.ChatMessage.Username}#{e.ChatMessage.Channel}: {e.ChatMessage.Message}");
        }
    }
}