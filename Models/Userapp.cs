using System.ComponentModel.DataAnnotations.Schema;

namespace clashCommunity_api.Models
{
    public class Userapp
    {
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("roleapp_id")]
        public int RoleAppId { get; set; }

        [ForeignKey("RoleAppId")]
        public string RoleApp { get; set; }
    }
}
