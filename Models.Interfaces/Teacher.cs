using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public class Teacher : Person
    {
        public IEnumerable<Course> TeachCourses { get; set; }
        public Class SupervisedClass { get; set; }
    }
}
