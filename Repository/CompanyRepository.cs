using Contracts;
using Entities;

namespace Repository {

    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository {

        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.Name).ToList();

        public Company GetCompanyById(Guid companyId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(companyId), trackChanges).SingleOrDefault();

        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
             FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();

        public void CreateCompany(Company company) => Create(company);

        public void DeleteCompany(Company company) {
            Delete(company);
        }
 
    }

}