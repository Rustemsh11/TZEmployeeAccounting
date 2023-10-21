using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Repositiories.Configuration;

namespace Repositiories
{
    public class EmployeeAccountingDbContext: DbContext
    {
        public EmployeeAccountingDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Department>? Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentEntityConfiguration());
        }
    }
}
