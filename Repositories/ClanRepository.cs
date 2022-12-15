namespace clashCommunity_api.Repositories
{
    public class ClanRepository : BaseRepository<Clan>
    {
        public ClanRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override List<Clan> FindAll()
        {
            throw new NotImplementedException();
        }

        public override Clan FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Save(Clan element)
        {
            throw new NotImplementedException();
        }

        public override List<Clan> SearchAll(Func<Clan, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }

        public override Clan SearchOne(Func<Clan, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }
    }
}
