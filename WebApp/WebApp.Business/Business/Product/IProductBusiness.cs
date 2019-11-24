using System;
using WebApp.DataAccess;
using WebApp.Business.RepositoryBase;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Business
{
    public interface IProductBusiness: IRepository<Product>
    {
        Task<List<Product>> GetAll();
    }
}
