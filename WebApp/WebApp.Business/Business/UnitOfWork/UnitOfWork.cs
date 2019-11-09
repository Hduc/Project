using System;
using System.Data.Entity;
using WebApp.DataAccess;

namespace WebApp.Business
{
    public partial class UnitOfWork :IUnitOfWork
    {
        public DBContext context;
        private DbContextTransaction transaction;
        private bool isDisposed;

        public UnitOfWork(DBContext context)
        {
            this.context = context;
        }
        public bool ChangeConnection(string connectionString)
        {
            this.context.Database.Connection.ConnectionString = connectionString;
            return true;
        }
        public TContext GetContext<TContext>() where TContext : class
        {
            return this.context as TContext;
        }
        public void BeginTransaction()
        {
            if (this.transaction == null)
            {
                this.transaction = this.context.Database.BeginTransaction();
            }
        }
        void Rollback()
        {
            if (this.transaction != null)
            {
                this.transaction.Rollback();
                this.transaction = null;
            }
        }
        public void Commit()
        {
            try
            {
                if (this.transaction == null)
                {
                    throw new Exception("You must begin transaction");
                }

                if (this.transaction != null)
                {
                    this.transaction.Commit();
                    this.transaction = null;
                }
            }
            catch (Exception ex)
            {
                Rollback();
                throw ex;

            }
        }
        public void Dispose()
        {
            Dispose(true);
            // Make sure only one dispose
            if (isDisposed)
            {
                GC.SuppressFinalize(this);
            }
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                this.context.Dispose();
            }
            isDisposed = true;
        }
    }
}
