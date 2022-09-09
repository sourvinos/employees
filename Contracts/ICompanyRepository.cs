using Entities;

namespace Contracts {

    public interface ICompanyRepository {

        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompanyById(Guid companyId, bool trackChanges);
        IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        void CreateCompany(Company company);
        void DeleteCompany(Company company);

    }

}