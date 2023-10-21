namespace Entity;

public class Department
{
    public int DepartmentId { get; set; }

    public string? Name { get; set; }

    public int? MainDepartmentid { get; set; }

    public int? BossId { get; set; } = null;

    public RecordState? RecordState { get; set; } = Entity.RecordState.Active;

    public virtual Employee? Boss { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Department> InverseMainDepartment { get; set; } = new List<Department>();

    public virtual Department? MainDepartment { get; set; }
}
