﻿using System.Linq.Expressions;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByConditional(Expression<Func<T, bool>> expression, bool trackChanges);
        void Update(T entity);
        void Create(T entity);
        void Delete(T entity);

    }
}
