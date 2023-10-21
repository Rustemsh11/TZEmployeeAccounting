using Contracts;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Repositiories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(EmployeeAccountingDbContext context) : base(context)
        {
        }

        public void CreateDepartment(Department department)
        {
            Create(department);
        }

        public void DeleteDepartment(Department department)
        {
            Delete(department);
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).Include(c => c.Boss).Include(c => c.MainDepartment).ToListAsync();
        }

        public async Task<IEnumerable<Department>> GetBossEmployeeDepartmnet(int bossId, bool trackChanges)
        {
            return await FindByConditional(c => c.BossId == bossId, trackChanges).ToListAsync();
        }

        public async Task<IEnumerable<Department>> GetChildDepartmentAsync(int departmentId, bool trackChages)
        {
            return await FindByConditional(c => c.MainDepartmentid == departmentId, trackChages).ToListAsync();
        }

        public async Task<Department> GetDepartmentAsync(int departmentId, bool trackChanges)
        {
            return await FindByConditional(c => c.DepartmentId == departmentId, trackChanges).SingleOrDefaultAsync();
        }

       
        public void UpdateDepartment(Department department)
        {
            Update(department);
        }
    }
}
