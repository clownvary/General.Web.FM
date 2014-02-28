using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Model;

namespace General.Service.Contract
{
    public interface IBaseService<T>where T:Entity
    {
        T Add(T entity);
        T GetEntityById(int id);
        bool Update(T entity);
        bool Remove(T entity);
        bool RemoveById(int id);
        IEnumerable<T> Query(Func<T, bool> lambda);

    }
}
