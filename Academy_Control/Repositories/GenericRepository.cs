using Academy_Control.Contexts;
using Academy_Control.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Academy_Control.Repositories
{
    public class GenericRepository<T> : IDisposable where T : Generic
    {
        private GenericContext context;

        public GenericRepository()
        {
            context = new GenericContext();
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Find(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> ListAll()
        {
            return context.Set<T>().ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}