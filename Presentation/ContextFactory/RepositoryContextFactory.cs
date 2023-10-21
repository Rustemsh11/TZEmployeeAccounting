
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repositiories;

namespace Presentation.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<EmployeeAccountingDbContext>
    {
        public EmployeeAccountingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EmployeeAccountingDbContext>()
                .UseSqlServer(GlobalVars.ConnectionString, b => b.MigrationsAssembly("Presentation"));
            return new EmployeeAccountingDbContext(builder.Options);
        }
    }
}
