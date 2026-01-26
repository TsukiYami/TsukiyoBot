namespace Entities.Entities.Config
{
    public class ChannelSettingsEntity
    {
        public ChannelSettingsEntity(Guid oChannelID, char cCommandPrefix, bool bReactOnPing, bool bXPSystemEnabled, bool bCustomCommandsEnabled, bool bAutoModEnabled, bool bWelcomeMessagesEnabled, bool bRaidAnnouncementsEnabled, bool bStreamStartAnnouncementsEnabled, bool bStreamEndAnnouncementsEnabled, bool bFollowerAnnouncementsEnabled, bool bSubscriberAnnouncementsEnabled, bool bBitsAnnouncementsEnabled, bool bDonationAnnouncementsEnabled, bool bGiveawayEnabled, bool bAutoFilterEnabled, bool bLinkFilterEnabled, bool bStayHydratedEnabled, bool bCustomRolesEnabled)
        {
            this.oChannelID = oChannelID;
            this.cCommandPrefix = cCommandPrefix;
            this.bReactOnPing = bReactOnPing;
            this.bXPSystemEnabled = bXPSystemEnabled;
            this.bCustomCommandsEnabled = bCustomCommandsEnabled;
            this.bAutoModEnabled = bAutoModEnabled;
            this.bWelcomeMessagesEnabled = bWelcomeMessagesEnabled;
            this.bRaidAnnouncementsEnabled = bRaidAnnouncementsEnabled;
            this.bStreamStartAnnouncementsEnabled = bStreamStartAnnouncementsEnabled;
            this.bStreamEndAnnouncementsEnabled = bStreamEndAnnouncementsEnabled;
            this.bFollowerAnnouncementsEnabled = bFollowerAnnouncementsEnabled;
            this.bSubscriberAnnouncementsEnabled = bSubscriberAnnouncementsEnabled;
            this.bBitsAnnouncementsEnabled = bBitsAnnouncementsEnabled;
            this.bDonationAnnouncementsEnabled = bDonationAnnouncementsEnabled;
            this.bGiveawayEnabled = bGiveawayEnabled;
            this.bAutoFilterEnabled = bAutoFilterEnabled;
            this.bLinkFilterEnabled = bLinkFilterEnabled;
            this.bStayHydratedEnabled = bStayHydratedEnabled;
            this.bCustomRolesEnabled = bCustomRolesEnabled;
        }

        public Guid oChannelID { get; set; }
        public char cCommandPrefix { get; set; }
        public bool bReactOnPing { get; set; }
        public bool bXPSystemEnabled { get; set; }
        public bool bCustomCommandsEnabled { get; set; }
        public bool bAutoModEnabled { get; set; }
        public bool bWelcomeMessagesEnabled { get; set; }
        public bool bRaidAnnouncementsEnabled { get; set; }
        public bool bStreamStartAnnouncementsEnabled { get; set; }
        public bool bStreamEndAnnouncementsEnabled { get; set; }
        public bool bFollowerAnnouncementsEnabled { get; set; }
        public bool bSubscriberAnnouncementsEnabled { get; set; }
        public bool bBitsAnnouncementsEnabled { get; set; }
        public bool bDonationAnnouncementsEnabled { get; set; }
        public bool bGiveawayEnabled { get; set; }
        public bool bAutoFilterEnabled { get; set; }
        public bool bLinkFilterEnabled { get; set; }
        public bool bStayHydratedEnabled { get; set; }
        public bool bCustomRolesEnabled { get; set; }
    }
}
