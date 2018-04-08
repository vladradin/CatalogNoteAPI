using Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface ITeacherService
    {
        void GiveGrade(Course course, Grade grade, Teacher byTeacher, Student toStudent);
        void ChangeGrade(Course course, Grade gradToChange, Grade newGrade, Teacher byTeacher, Student forStudent);
        IEnumerable<Student> GetStudentsFor(Course course);
        IEnumerable<Course> GetCoursesFor(Teacher teacher);
    }
}
