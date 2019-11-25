using System;
using System.Data.Entity;

namespace WebApp.DataAccess
{
    public class WebAppContext : DbContext,IDisposable
    {
        public WebAppContext()
            : base("name=WebAppContext")
        {
            // when loading entity, you should you Include method for every navigation properties you need
            Configuration.LazyLoadingEnabled = false;
            // we do not use lazy load, so proxy creation not necessary anymore
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }

    }
}
