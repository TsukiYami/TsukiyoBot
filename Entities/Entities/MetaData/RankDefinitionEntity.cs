namespace Entities.Entities.MetaData
{
    public class RankDefinitionEntity
    {
        public Guid oRankDefinitionID { get; init; }
        public Guid oScopeID { get; init; }
        public ulong nRequired_XP { get; init; }
        public ulong nXPPerMessage { get; init; }
        public string sXPRank { get; init; }

		public RankDefinitionEntity (Guid oRankDefinitionID, Guid oScopeID, ulong nRequired_XP, ulong nXPPerMessage, string sXPRank) {
			this.oRankDefinitionID = oRankDefinitionID;
			this.oScopeID = oScopeID;
			this.nRequired_XP = nRequired_XP;
			this.nXPPerMessage = nXPPerMessage;
			this.sXPRank = sXPRank;
		}
    }
}
