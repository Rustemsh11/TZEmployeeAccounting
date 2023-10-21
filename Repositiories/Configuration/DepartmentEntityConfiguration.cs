using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositiories.Configuration
{
    public class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(c=>c.DepartmentId).ValueGeneratedOnAdd();
            builder.Property(c=>c.Name).IsUnicode(true);
            builder.HasOne(d => d.Boss)
                                .WithMany(p => p.Departments)
                                .HasForeignKey(d => d.BossId);

            builder.HasOne(d => d.MainDepartment)
                .WithMany(p => p.InverseMainDepartment)
                .HasForeignKey(d => d.MainDepartmentid);
        }
    }
}
