using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    interface IParentService
    {
        IEnumerable<Grade> GetGrades(Parent parent,byte lastNumberOfWeeks);
    }
}
