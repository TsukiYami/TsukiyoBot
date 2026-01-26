namespace Entities.Entities.Identity
{
    public class UsersEntity
    {
        public UsersEntity(string sUsername, string sTwitchID)
        {
            this.sUsername = sUsername;
            this.sTwitchID = sTwitchID;
        }

        public string sTwitchID { get; set; }
        public string sUsername { get; set; }
    }
}