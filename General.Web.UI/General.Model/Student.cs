using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Model
{
  public  class Student:Entity
    {
      public int Point { get; set; }
      public Teacher Teacher { get; set; }
      public int TeacherId { get; set; }
    }
}
