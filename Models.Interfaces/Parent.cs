using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public class Parent : Person
    {
        public IEnumerable<Student> Kids { get; set; }
    }
}
