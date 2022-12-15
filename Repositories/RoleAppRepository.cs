namespace clashCommunity_api.Repositories
{
    public class RoleAppRepository : BaseRepository<RoleApp>
    {
        public RoleAppRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override List<RoleApp> FindAll()
        {
            throw new NotImplementedException();
        }

        public override RoleApp FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Save(RoleApp element)
        {
            throw new NotImplementedException();
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
