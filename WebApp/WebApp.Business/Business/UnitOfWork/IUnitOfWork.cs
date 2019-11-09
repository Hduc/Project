using System;
namespace WebApp.Business
{
    public interface IUnitOfWork: IDisposable
    {
        bool ChangeConnection(string connectionString);
        void BeginTransaction();
        void Commit();
        TContext GetContext<TContext>() where TContext : class;
    }
}
