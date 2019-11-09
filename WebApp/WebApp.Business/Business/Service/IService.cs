using System;
using System.Linq;

namespace WebApp.Business
{
    public interface IService<T>
    {
        T GetByID(object id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void Delete(object id);
        IQueryable<T> GetAll();
        //IQueryable<T> GetQueryable();
        int Count();
    }
}
