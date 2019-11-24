using Unity;

namespace WebApp.Web.IoC
{
    public interface IUnityDependencyResolver
    {
        void ResolveDependency(IUnityContainer unityContainer);
    }
}