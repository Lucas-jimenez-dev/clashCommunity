

namespace clashCommunity_api.Repositories
{
    public class UserAppRepository : BaseRepository<UserApp>
    {

        public UserAppRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override bool Delete(UserApp element)
        {
            _dataContext.UserApp.Remove(element);
            return Update();
        }

        public override List<UserApp> FindAll()
        {
            return _dataContext.UserApp.ToList();
        }

        public override UserApp FindById(int id)
        {
            return _dataContext.UserApp.FirstOrDefault(cand => cand.Id == id);
        }

        public override bool Save(UserApp element)
        {
            _dataContext.UserApp.Add(element);
            return Update();
        }


        public override List<UserApp> SearchAll(Func<UserApp, bool> SearchMethod)
        {
            throw new NotImplementedException();    
        }

        public override UserApp SearchOne(Func<UserApp, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }
    }
}
