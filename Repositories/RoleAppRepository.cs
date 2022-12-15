namespace clashCommunity_api.Repositories
{
    public class RoleAppRepository : BaseRepository<RoleApp>
    {
        public RoleAppRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override bool Delete(RoleApp element)
        {
            _dataContext.RoleApp.Remove(element);
            return Update();
        }

        public override List<RoleApp> FindAll()
        {
            return _dataContext.RoleApp.ToList();
        }

        public override RoleApp FindById(int id)
        {
            return _dataContext.RoleApp.FirstOrDefault(roleApp => roleApp.Id == id);
        }

        public override bool Save(RoleApp element)
        {
            _dataContext.RoleApp.Add(element);
            return Update();
        }

        public override List<RoleApp> SearchAll(Func<RoleApp, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }

        public override RoleApp SearchOne(Func<RoleApp, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }
    }
}
