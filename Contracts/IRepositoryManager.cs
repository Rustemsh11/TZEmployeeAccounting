namespace Contracts
{
    public interface IRepositoryManager
    {
        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        Task SaveAsync();
    }
}
