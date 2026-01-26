namespace Entities.Entities.XPConfig
{
    public class XPScopesEntity
    {
        public XPScopesEntity(Guid oScopeID, string sScopeName, bool bIsGlobal)
        {
            this.oScopeID = oScopeID;
            this.sScopeName = sScopeName;
            this.bIsGlobal = bIsGlobal;
        }

        public Guid oScopeID { get; set; }
        public string sScopeName { get; set; }
        public bool bIsGlobal { get; set; }
    }
}
