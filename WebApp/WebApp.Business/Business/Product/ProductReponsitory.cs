using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Business.RepositoryBase;
using WebApp.DataAccess;

namespace WebApp.Business
{
   public class ProductReponsitory: Repository<WebAppContext, Product>, IProductReponsitory
    {
        public ProductReponsitory(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {
        }
        public async Task<List<Product>> GetAll()
        {
            return await DbSet.ToListAsync();
        }
    }
}
