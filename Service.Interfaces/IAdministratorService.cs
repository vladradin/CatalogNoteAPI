using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    interface IAdministratorService
    {
        Teacher AddTeacher(Name teacherName);
    }
}
