

namespace clashCommunity_api.Repositories
{
    public class UserAppRepository : BaseRepository<UserApp>
    {

        public UserAppRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override List<UserApp> FindAll()
        {
            throw new NotImplementedException();
        }

        public override UserApp FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Save(UserApp element)
        {
            throw new NotImplementedException();
        }


        public override List<UserApp> SearchAll(Func<UserApp, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }

        public override UserApp SearchOne(Func<UserApp, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }
        public string Test()
        {
            return "oktest";
        }
    }
}
