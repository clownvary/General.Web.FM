using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Model;
namespace General.Data.Repository
{
    public interface IBaseRepository<T>where T:Entity
    {
        T Add(T entity);
        T GetById(int id);
        bool Remove(T entity);
        bool Update(T entity);
        IEnumerable<T> FindAll();
        IEnumerable<T> Query(Func<T, bool> where);
    }
}
