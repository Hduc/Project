using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebApp.DataAccess
{
    public class WebAppContext : DbContext,IDisposable
    {
        public WebAppContext()
            : base("name=WebAppContext")
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    }
}
