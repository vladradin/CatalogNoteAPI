using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public class Course
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
