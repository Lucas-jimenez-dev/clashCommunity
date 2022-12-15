namespace clashCommunity_api.Repositories
{
    public class CandidatureRepository : BaseRepository<Candidature>
    {
        public CandidatureRepository(DataDbContext dataContext) : base(dataContext)
        {
        }

        public override List<Candidature> FindAll()
        {
            throw new NotImplementedException();
        }

        public override Candidature FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Save(Candidature element)
        {
            throw new NotImplementedException();
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
