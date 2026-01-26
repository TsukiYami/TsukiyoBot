namespace Entities.Entities.Identity
{
    public class ChannelsEntity
    {
        public ChannelsEntity(Guid oChannelID, string sTwitchID, string sChannelName, string sActiveScopeID)
        {
            this.oChannelID = oChannelID;
            this.sTwitchID = sTwitchID;
            this.sChannelName = sChannelName;
            this.sActiveScopeID = sActiveScopeID;
        }

        public Guid oChannelID { get; set; }
        public string sTwitchID { get; set; }
        public string sChannelName { get; set; }
        public string sActiveScopeID { get; set; }
    }
}
