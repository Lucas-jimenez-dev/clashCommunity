namespace clashCommunity_api.Repositories
{
    public class CandidatureRepository : BaseRepository<Candidature>
    {
        public CandidatureRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override bool Delete(Candidature element)
        {
            _dataContext.Candidature.Remove(element);
            return Update();
        }

        public override List<Candidature> FindAll()
        {
            return _dataContext.Candidature.ToList();
        }

        public override Candidature FindById(int id)
        {
            return _dataContext.Candidature.FirstOrDefault(cand => cand.Id == id);
        }

        public override bool Save(Candidature element)
        {
            _dataContext.Candidature.Add(element);
            return Update();
        }

        public override List<Candidature> SearchAll(Func<Candidature, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }

        public override Candidature SearchOne(Func<Candidature, bool> SearchMethod)
        {
            throw new NotImplementedException();
        }
    }
}
