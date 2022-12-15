
namespace clashCommunity_api.Tools
{

    public class DataDbContext : DbContext
    {

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public DbSet<Userapp>? Users { get; set; }


    }

}
