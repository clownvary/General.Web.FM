using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Model;
using General.Data.Repository;
using General.Service.Contract;
namespace General.Service
{
    public class StudentService : IBaseService<Student>
    {
        IStudentRepository stu;
        public StudentService(IStudentRepository stu)
        {
            this.stu = stu;
        }
        public Student Add(Student entity)
        {
            return stu.Add(entity);
        }

        public Student GetEntityById(int id)
        {
            return stu.GetById(id);
        }

        public bool Update(Student entity)
        {
            return stu.Update(entity);
        }

        public bool Remove(Student entity)
        {
            return stu.Remove(entity);
        }

        public bool RemoveById(int id)
        {
            return stu.Remove(stu.GetById(id));
        }

        public IEnumerable<Student> Query(Func<Student, bool> lambda)
        {
            return stu.Query(lambda).AsQueryable();
        }
    }
}
