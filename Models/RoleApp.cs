namespace clashCommunity_api.Models
{
    [Table("roleApp")]
    public class RoleApp
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("role")]
        public string? Role { get; set; }
    }
}
