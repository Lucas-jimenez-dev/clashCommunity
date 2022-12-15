namespace clashCommunity_api.Repositories
{
    public class ClanRepository : BaseRepository<Clan>
    {
        public ClanRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override bool Delete(Clan element)
        {
            _dataContext.Clan.Remove(element);
            return Update();
        }

        public override List<Clan> FindAll()
        {
            return _dataContext.Clan.ToList();
        }

        public override Clan FindById(int id)
        {
            return _dataContext.Clan.FirstOrDefault(clan => clan.Id == id);
        }

        public override bool Save(Clan element)
        {
            _dataContext.Clan.Add(element);
            return Update();
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
