using Unity;
using Unity.Lifetime;
using WebApp.Business.RepositoryBase;

namespace WebApp.Web.IoC
{
    public static class UnityDependencyResolver
    {
        /// <summary>
        /// </summary>
        /// <param name="container"></param>
        /// <returns></returns>
        public static IUnityContainer DependencyResolve(IUnityContainer container)
        {
            container.RegisterType<IDbContextFactory, DefaultDbContextFactory>(new PerResolveLifetimeManager());
            return container;
        }
    }
}