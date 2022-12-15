namespace clashCommunity_api.Models
{
    [Table("clan")]
    public class Clan
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("tag")]
        public string Tag { get; set; }
    }
}
