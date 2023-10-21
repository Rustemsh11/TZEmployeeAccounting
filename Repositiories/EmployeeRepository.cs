using Contracts;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Repositiories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeAccountingDbContext context) : base(context)
        {
        }

        public void CreateEmployee(Employee employee)
        {
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).Include(c=>c.Department).ToListAsync();
        }

        public async Task<Employee> GetEmployeeAsync(int employeeId, bool trackChanges)
        {
            return await FindByConditional(c => c.EmployeeId.Equals(employeeId), trackChanges).SingleOrDefaultAsync();
        }

        public void UpdateEmployee(Employee employee)
        {
            Update(employee);
        }
    }
}
