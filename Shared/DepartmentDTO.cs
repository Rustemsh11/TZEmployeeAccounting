using System.ComponentModel;

namespace Shared
{
    public record DepartmentDTO
    {
        [DisplayName("№")]
        public int DepartmentId { get; init; }
        [DisplayName("Наименование")]
        public string? Name { get; init; }
        [DisplayName("Головное подразделение")]
        public string? MainDepartment { get; init; }
        [DisplayName("Руководитель")]
        public string? Boss { get; init; }
    }
}
