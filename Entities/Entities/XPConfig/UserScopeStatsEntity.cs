namespace Entities.Entities.XPConfig
{
    public class UserScopeStatsEntity
    {
        public UserScopeStatsEntity(Guid oUserID, Guid oScopeID, ulong nXPAmount, ulong nMessageCount)
        {
            this.oUserID = oUserID;
            this.oScopeID = oScopeID;
            this.nXPAmount = nXPAmount;
            this.nMessageCount = nMessageCount;
        }

        public Guid oUserID { get; set; }
        public Guid oScopeID { get; set; }
        public ulong nXPAmount { get; set; }
        public ulong nMessageCount { get; set; }
    }
}
