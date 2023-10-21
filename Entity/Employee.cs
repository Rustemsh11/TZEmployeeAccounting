using Entity;
using System;
using System.Collections.Generic;

namespace Entity;

public class Employee
{
    public int EmployeeId { get; set; }

    public string? Fio { get; set; }

    public string? TabelNumber { get; set; }
    public string? Position { get; set; }

    public int? DepartmentId { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime? EmploymentDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public RecordState? RecordState { get; set; } = Entity.RecordState.Active;

    public virtual Department? Department { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
