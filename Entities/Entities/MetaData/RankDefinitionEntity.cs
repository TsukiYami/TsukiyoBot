namespace Entities.Entities.MetaData
{
    public class RankDefinitionEntity
    {
        public Guid oRankDefinitionID { get; set; }
        public Guid oScopeID { get; set; }
        public ulong nRequired_XP { get; set; }
        public ulong nXPPerMessage { get; set; }
        public string sXPRank { get; set; }
    }
}
