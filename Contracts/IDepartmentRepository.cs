using Entity;

namespace Contracts
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartmentsAsync(bool trackChanges);
        Task<Department> GetDepartmentAsync(int departmentId, bool trackChanges);        
        Task<IEnumerable<Department>> GetChildDepartmentAsync(int departmentId, bool trackChages);
        Task<IEnumerable<Department>> GetBossEmployeeDepartmnet(int bossId, bool trackChanges);
        void CreateDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);
    }
}
