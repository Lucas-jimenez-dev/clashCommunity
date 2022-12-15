
using Microsoft.EntityFrameworkCore;

namespace clashCommunity_api.Tools
{

    public class DataDbContext : DbContext
    {

        /*  public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
          {

          }*/

        private string connection = @"server=localhost; port=3309;database=clashcommunitydb;uid=root;password=root;Connection Timeout=30;";
        public DbSet<Userapp>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }



    }

}
