using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    interface ISupervisorService
    {
        void CreateClass(ClassID createdClassId);
        void AddToClass(Student studentToAdd, ClassID classId);

        Student CreateStudent(uint registrationNumber, Name fullName);
        
        Class GetSupervisedClass(Teacher supervisorTeacher);

        IEnumerable<Student> GetStudentsWithWarning(Class teachersClass);
    }
}
