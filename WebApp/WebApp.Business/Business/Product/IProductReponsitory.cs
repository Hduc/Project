using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Business.RepositoryBase;
using WebApp.DataAccess;

namespace WebApp.Business
{
    public interface IProductReponsitory : IRepository<Product>
    {
        Task<List<Product>> GetAll();
    }
}
