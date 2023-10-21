using System.ComponentModel;

namespace Shared
{
    public record EmployeeDTO
    {
        [DisplayName("№")]
        public int EmployeeId { get; set; }
        [DisplayName("ФИО")]
        public string? Fio { get; init; }
        [DisplayName("Табель №")]
        public string? TabelNumber { get; init; }
        [DisplayName("Должность")]
        public string? Position { get; init; }
        [DisplayName("Подразделение")]
        public string? Department { get; init; }
        [DisplayName("Email")]
        public string? Email { get; init; }
        [DisplayName("Телефон")]
        public string? Phone { get; init; }
        [DisplayName("Дата принятия")]
        public string? EmploymentDate { get; init; }
        [DisplayName("Дата увольнения")]
        public string? TerminationDate { get; init; }
    }
}
