using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Model;
using General.Data.Repository;
using System.Data.Entity;
namespace General.Data.Sql
{
    public class BaseRepo<T> : IBaseRepository<T> where T:Entity
    {

        GeneralDbContext db = new GeneralDbContext();
        public T Add(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Added;
            db.SaveChanges();
            return entity;
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public bool Remove(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry<T>(entity).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public IEnumerable<T> FindAll()
        {
            return db.Set<T>().AsQueryable();
        }

        public IEnumerable<T> Query(Func<T, bool> where)
        {
            if (where != null)
                return db.Set<T>().Where(where).AsQueryable();
            return db.Set<T>().AsQueryable();
        }
    }
}
