

namespace clashCommunity_api.Repositories
{
    public class UserRepository : BaseRepository<Userapp>
    {

        public UserRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override List<Userapp> FindAll()
        {
            throw new NotImplementedException();
        }

        public override Userapp FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Save(Userapp element)
        {
            throw new NotImplementedException();
        }


        public override List<Userapp> SearchAll(Func<Userapp, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }

        public override Userapp SearchOne(Func<Userapp, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }
        public string Test()
        {
            return "oktest";
        }
    }
}
