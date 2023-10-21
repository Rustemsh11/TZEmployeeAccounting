using Contracts;

namespace Repositiories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly EmployeeAccountingDbContext _employeeAccountingDbContext;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        private readonly Lazy<IDepartmentRepository> _departmentRepository;

        public RepositoryManager(EmployeeAccountingDbContext employeeAccountingDbContext)
        {
            _employeeAccountingDbContext= employeeAccountingDbContext;
            _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(employeeAccountingDbContext));
            _departmentRepository = new Lazy<IDepartmentRepository> (() => new DepartmentRepository(employeeAccountingDbContext));
        }

        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;

        public IDepartmentRepository DepartmentRepository => _departmentRepository.Value;

        public async Task SaveAsync()
        {
            await _employeeAccountingDbContext.SaveChangesAsync();
        }
    }
}
