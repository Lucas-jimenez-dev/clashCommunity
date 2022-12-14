
namespace clashCommunity_api.Tools
{

    public class DataDbContext : DbContext
    {
        public DbSet<Userapp> Users { get; set; }

       //TODO :  Envirnoment variable
        private string connectionString = " Server=localhost; Database=MY_DB_NAME; User=MY_USER; Password=MY_PASSWORD";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  TODO: adapter avec mySql

            //  optionsBuilder.UseSqlServer(@"Server=tcp:utopios-m2i.database.windows.net,1433;Initial Catalog=pikachu-antoine;Persist Security Info=False;User ID=m2iformation;Password=Toto.Tata12/;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }

}
