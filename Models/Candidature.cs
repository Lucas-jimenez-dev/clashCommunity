namespace clashCommunity_api.Models
{
    [Table("candidature")]
    public class Candidature
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("status")]
        public string Status { get; set; }

        // FK

        [Column("userapp_id")]
        public int UserAppId { get; set; }

        [ForeignKey("UserAppId")]
        public UserApp UserApp { get; set; }

        [Column("clan_id")]
        public int ClanId { get; set; }

        [ForeignKey("ClanId")]
        public Clan Clan { get; set; }




    }
}
