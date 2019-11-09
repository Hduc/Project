using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;

namespace WebApp.Business
{
   public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        int Count();
        int Count(Expression<Func<TEntity, bool>> filter);
        void Delete(TEntity entity);
        void Delete(object id);
        ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, params ObjectParameter[] parameters);
        TResult ExecuteStoreProcedure<TResult>(string storeName, params object[] parameters);
        IList<TEntity> GetAll();
        IList<TEntity> GetAll(out int total, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, List<Expression<Func<TEntity, object>>> selectFields = null, List<Expression<Func<TEntity, object>>> includes = null, int? pageNumber = null, int? pageSize = null);
        IList<TEntity> GetAll(out int total, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, List<Expression<Func<TEntity, object>>> includes = null, int? pageNumber = null, int? pageSize = null);
        IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, List<Expression<Func<TEntity, object>>> includes = null);
        IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetByID(object entityID);
        IList<TResult> GetByStoreProcedure<TResult>(string storeName, params object[] parameters);
        IQueryable<TEntity> GetQueryable();
        IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);
        void Update(TEntity entity);

    }
}
