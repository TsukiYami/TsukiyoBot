namespace Entities.Entities.Config
{
    public class ChannelBotIdentityEntity
    {
        public Guid oChannelID { get; init; }
        public string sBotTwitchUsername { get; init; }
        public string sAccessToken { get; init; }
        public string sRefreshToken { get; init; }

		public ChannelBotIdentityEntity (Guid oChannelID, string sBotTwitchUsername, string sAccessToken, string sRefreshToken) {
			this.oChannelID = oChannelID;
			this.sBotTwitchUsername = sBotTwitchUsername;
			this.sAccessToken = sAccessToken;
			this.sRefreshToken = sRefreshToken;
		}
    }
}
