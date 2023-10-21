using Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repositiories
{
    public abstract class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        protected EmployeeAccountingDbContext _context;

        protected BaseRepository(EmployeeAccountingDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges ? _context.Set<T>() : _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByConditional(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return trackChanges ? _context.Set<T>().Where(expression) : _context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
