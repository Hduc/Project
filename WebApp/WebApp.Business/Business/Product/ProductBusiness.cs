using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DataAccess;

namespace WebApp.Business
{
    public class ProductBusiness:IProductBusiness
    {
        #region Attributes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Product> _repository;

        #endregion
        #region Constructors
        public ProductBusiness(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion
        #region Add/Update/Delete/Select/Count
        public void Add(Product item)
        {
            this._repository.Add(item);
        }
        public void Update(Product item)
        {
            this._repository.Update(item);
        }
        public void Delete(Product item)
        {
            this._repository.Delete(item);
        }
        public void Delete(object id)
        {
            var dbContext = this._unitOfWork.GetContext<DBContext>();
            dbContext.Database.ExecuteSqlCommand(
               string.Format(@"
                DELETE Product
                WHERE ID = '{0}'", id), new object[] { });
        }
        public Product GetByID(object id)
        {
            return this._repository.GetByID(id);
        }
        public IQueryable<Product> GetAll()
        {
            return this._repository.GetQueryable();
        }
        public void AddRange(IEnumerable<Product> products)
        {
            _unitOfWork.BeginTransaction();
            foreach (var product in products)
            {
                _repository.Add(product);
            }
            _unitOfWork.Commit();
        }
        public int Count()
        {
            return _repository.Count();
        }
        #endregion

    }
}
