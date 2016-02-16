using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Rango.Domain.Contracts.Repositories.Base;

namespace Rango.Database.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity, Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}