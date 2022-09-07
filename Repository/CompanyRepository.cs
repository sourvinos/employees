namespace Repository {

    public class Company : RepositoryBase<Company>, ICompanyRepository {

        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

    }

}