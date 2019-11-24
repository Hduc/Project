using System;
using System.Collections.Generic;
using WebApp.DataAccess;
using WebApp.Business.RepositoryBase;
using System.Threading.Tasks;
using RefactorThis.GraphDiff;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace WebApp.Business
{
    public class ProductBusiness : IProductBusiness
    {
        #region Attributes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductReponsitory _productReponsitory;
        private readonly IDbContextScopeFactory _dbContextScopeFactory;

        #endregion
        public ProductBusiness(IDbContextScopeFactory dbContextScopeFactory,
            IUnitOfWork unitOfWork,
            IProductReponsitory productReponsitory)
        {
            _dbContextScopeFactory = dbContextScopeFactory;
            _unitOfWork = unitOfWork;
            _productReponsitory = productReponsitory;
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Product, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity, Expression<Func<IUpdateConfiguration<Product>, object>> expression, Func<Product, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<Product> FindAsync(Expression<Func<Product, bool>> predicate, IncludingQuery<Product> includingQuery = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll()
        {
            using (_dbContextScopeFactory.Create())
            {
                return await _productReponsitory.GetAll();
            }
        }

        public Task<IReadOnlyList<Product>> GetAsync(Expression<Func<Product, bool>> predicate, IncludingQuery<Product> includingQuery = null, OrderingQuery<Product> orderingQuery = null, PagingQuery pagingQuery = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Modify(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(Product entity, Expression<Func<IUpdateConfiguration<Product>, object>> expression, bool allowDelete = false)
        {
            throw new NotImplementedException();
        }

        IQueryable<TProject> IRepository<Product>.Query<TProject>()
        {
            throw new NotImplementedException();
        }
    }
}
