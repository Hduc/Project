using System.Data.Entity;

namespace WebApp.Business.RepositoryBase
{
    public class AmbientDbContextLocator : IAmbientDbContextLocator
    {
        public TDbContext Get<TDbContext>() where TDbContext : DbContext
        {
            return DbContextScope.GetAmbientScope()?.DbContexts.Get<TDbContext>();
        }
    }
}