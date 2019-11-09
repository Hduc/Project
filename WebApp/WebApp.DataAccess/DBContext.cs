using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebApp.DataAccess
{
    public class DBContext : DbContext,IDisposable
    {
        public DBContext()
            : base("name=DBContext")
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
