namespace Repository {

    public class Employee : RepositoryBase<Employee>, IEmployeeRepository {

        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

    }

}