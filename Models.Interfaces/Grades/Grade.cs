using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public abstract class Grade
    {
        public Course ForCourse { get; set; }
        public Teacher ByTeacher { get; set; }
        public Date OnDate { get; set; }
    }
}
