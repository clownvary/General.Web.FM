using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Model
{
  public  class Teacher:Entity
    {
      public int Salary { get; set; }
      public IList<Student> Students { get; set; }
      public string Dog { get; set; }

    }
}
