using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public class Name : IEquatable<Name>
    {
        public string First { get; set; }
        public string Last { get; set; }

        public bool Equals(Name other) => First == other.First &&
                                          Last == other.Last;
    }
}
