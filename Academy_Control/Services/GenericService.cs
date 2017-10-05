using Academy_Control.Entities;
using Academy_Control.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Academy_Control.Services
{
    public class GenericService<T> : IDisposable where T : Generic
    {
        protected readonly GenericRepository<T> rep;

        public GenericService(GenericRepository<T> rep)
        {
            this.rep = rep;
        }

        public virtual void Add(T entity)
        {

            rep.Add(entity);

        }

        public void Update(T entity)
        {

            rep.Update(entity);

        }

        public void Delete(T entity)
        {

            rep.Delete(entity);

        }

        public void Find(int id)
        {

            rep.Find(id);

        }

        public virtual void Validade(T entity)
        {

        }

        public IEnumerable<T> ListAll()
        {

            List<T> list = new List<T>();
            return list = rep.ListAll().ToList();

        }

        public void Dispose()
        {

        }
    }
}