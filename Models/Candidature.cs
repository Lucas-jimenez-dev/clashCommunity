namespace clashCommunity_api.Models
{
    public class Candidature
    {
        public int Id { get; set; }
        public string Status { get; set; }



        // FK

        [Column("userapp_id")]
        public int UserAppId { get; set; }

        [ForeignKey("UserAppId")]
        public Userapp Userapp { get; set; }

        [Column("clan_id")]
        public int ClanId { get; set; }

        [ForeignKey("ClanId")]
        public Clan Clan { get; set; }




    }
}
