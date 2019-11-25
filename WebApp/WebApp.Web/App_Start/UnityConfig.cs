using System;
using Unity;
using WebApp.Web.IoC;

namespace WebApp.Web
{
    public static class UnityConfig
    {
        //public static IUnityContainer Container { get; set; }

        public static void RegisterTypes(IUnityContainer container)
        {
            UnityHelper.BuildUnityContainer(container);

            UnityDependencyResolver.DependencyResolve(container);

            foreach (var task in container.ResolveAll<IUnityDependencyResolver>())
                task.ResolveDependency(container);
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
        private static readonly Lazy<IUnityContainer> LazyContainer = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });
        public static IUnityContainer Container => LazyContainer.Value;
    }
}