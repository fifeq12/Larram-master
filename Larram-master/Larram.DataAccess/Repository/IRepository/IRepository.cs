﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Larram.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int? id);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            string includeProperties = null);
        IEnumerable<T> GetAllNotAsync(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null);
        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null,
            string includeProperties = null);
        Task Add(T entity);
        Task Remove(int id);
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entity);
    }
}
