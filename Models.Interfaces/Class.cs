using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public class Class
    {
        public ClassID ClassId { get; set; }
        public Teacher Supervisor { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
