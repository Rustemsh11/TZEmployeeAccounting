using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositiories.Configuration
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(c=>c.EmployeeId).ValueGeneratedOnAdd();
            builder.Property(c=>c.Fio).IsUnicode(true);
            builder.Property(c=>c.Position).IsUnicode(true);

            builder.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
