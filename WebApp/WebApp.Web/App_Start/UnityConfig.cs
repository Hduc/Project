using System;
using Unity;
using WebApp.Web.IoC;
namespace WebApp.Web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        
        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            UnityHelper.BuildUnityContainer(container);

            UnityDependencyResolver.DependencyResolve(container);

            foreach (var task in container.ResolveAll<IUnityDependencyResolver>())
                task.ResolveDependency(container);
        }
        #region Unity Container

        private static readonly Lazy<IUnityContainer> LazyContainer = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        ///     Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => LazyContainer.Value;

        #endregion
    }
}