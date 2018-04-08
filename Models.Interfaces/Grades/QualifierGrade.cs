using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces.Grades
{
    class QualifierGrade : Grade
    {
        public QualifierTypes Qualifier { get; set; }
    }
}
