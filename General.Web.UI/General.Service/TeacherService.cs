using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Service.Contract;
using General.Data.Repository;
namespace General.Service
{

    public class TeacherService : ITeacherService
    {
        ITeacherRepository tea;
        public TeacherService(ITeacherRepository tea)
        {
            this.tea = tea;
        }
        public Model.Teacher Add(Model.Teacher entity)
        {
            return tea.Add(entity);
        }

        public Model.Teacher GetEntityById(int id)
        {
            return tea.GetById(id);
        }

        public bool Update(Model.Teacher entity)
        {
            return Update(entity);
        }

        public bool Remove(Model.Teacher entity)
        {
            return Remove(entity);
        }

        public bool RemoveById(int id)
        {
            return tea.Remove(tea.GetById(id));
        }

        public IEnumerable<Model.Teacher> Query(Func<Model.Teacher, bool> lambda)
        {
            return tea.Query(lambda).AsQueryable();
        }

    }
}
