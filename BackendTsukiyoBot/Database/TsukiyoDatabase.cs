using Microsoft.EntityFrameworkCore;
using Entities.Entities.Identity;
using Entities.Entities.Config;
using Entities.Entities.XPConfig;
using Entities.Entities.MetaData;

namespace BackendTsukiyoBot.Database
{
    public class TsukiyoDatabase : DbContext
    {
        // Identity
        public DbSet<UsersEntity> Users { get; set; }
        public DbSet<ChannelsEntity> Channels { get; set; }

        // Configuration
        public DbSet<ChannelSettingsEntity> ChannelSettings { get; set; }
        public DbSet<ChannelBotIdentityEntity> BotSettings { get; set; }

        // XP Configuration
        public DbSet<XPScopesEntity> XPScopes { get; set; }
        public DbSet<UserScopeStatsEntity> UserScopeStats { get; set; }

        // Metadata
        public DbSet<RankDefinitionEntity> RankDefinitions { get; set; }
    }
}