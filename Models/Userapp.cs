

using System.ComponentModel.DataAnnotations;

namespace clashCommunity_api.Models
{
    [Table("userApp")]
    [Index(nameof(Email), IsUnique = true)]
    public class UserApp
    {
        [Column("id")]

        public int Id { get; set; }


        [Column("pseudo")]
        public string Pseudo { get; set; }


        [Column("email")]
        [Required(ErrorMessage ="Email is required.")]
        public string Email { get; set; }


        [Column("password")]
        [StringLength(maximumLength:200, MinimumLength =10)]
        public string Password { get; set; }

        [Column("tag")]
        public string Tag { get; set; }

        [Column("can_approve")]
        public bool CanApprove { get; set; }


        // FK

        [Column("roleapp_id")]
        public int RoleAppId { get; set; }

        [ForeignKey("RoleAppId")]
        public RoleApp RoleApp { get; set; }

        [Column("clan_id")]
        public int ClanId { get; set; }

        [ForeignKey("ClanId")]
        public Clan Clan { get; set; }
    }
}
