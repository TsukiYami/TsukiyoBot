namespace Entities.Entities.Config
{
    public class ChannelBotIdentityEntity
    {
        public Guid oChannelID { get; set; }
        public string sBotTwitchUsername { get; set; }
        public string sAccessToken { get; set; }
        public string sRefreshToken { get; set; }
    }
}
