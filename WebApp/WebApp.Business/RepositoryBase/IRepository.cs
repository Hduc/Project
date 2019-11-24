using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using RefactorThis.GraphDiff;

namespace WebApp.Business.RepositoryBase
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);

        void Modify(TEntity entity);

        void Modify(
            TEntity entity,
            Expression<Func<IUpdateConfiguration<TEntity>, object>> expression,
            bool allowDelete = false);

        void Delete(TEntity entity);

        void Delete(
            TEntity entity,
            Expression<Func<IUpdateConfiguration<TEntity>, object>> expression,
            Func<TEntity, bool> predicate = null);

        IQueryable<TProject> Query<TProject>() where TProject : class, IMapping;

        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate,
            IncludingQuery<TEntity> includingQuery = null,
            CancellationToken cancellationToken = default);

        Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate,
            IncludingQuery<TEntity> includingQuery = null,
            OrderingQuery<TEntity> orderingQuery = null,
            PagingQuery pagingQuery = null,
            CancellationToken cancellationToken = default);

        Task<int> CountAsync(CancellationToken cancellationToken = default);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    }
}