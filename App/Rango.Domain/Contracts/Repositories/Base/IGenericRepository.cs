using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Rango.Domain.Contracts.Repositories.Base
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        T GetSingle(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Update(T entity, Expression<Func<T, bool>> predicate);

        void Delete(Expression<Func<T, bool>> predicate);
    }
}