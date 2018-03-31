using System;
using System.Collections.Generic;

namespace Test.Models
{
  public class Student
  {
    public Guid Id { get; set; }
    public string Name { get; set; }

    //Navigation property
    public List<Subject> Subjects { get; set; }
  }
}

