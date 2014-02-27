using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using General.Model;
namespace General.Data.Sql
{
    public class GeneralDbContext : DbContext
    {
        public GeneralDbContext() : base("GeneralDbContext") { }
         
        public IDbSet<Student> Stduents { get; set; }
        public IDbSet<Teacher> Teachers { get; set; }
        
    }

}
