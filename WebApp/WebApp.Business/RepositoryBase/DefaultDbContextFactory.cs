using System;
using System.Data.Entity;

namespace WebApp.Business.RepositoryBase
{
    public class DefaultDbContextFactory : IDbContextFactory
    {
        public TDbContext CreateDbContext<TDbContext>() where TDbContext : DbContext
        {
            return Activator.CreateInstance<TDbContext>();
        }
    }
}