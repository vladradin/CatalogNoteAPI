using Models.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service.Implementations
{
    public class TeacherService : ITeacherService
    {
        public void ChangeGrade(Course course, Grade gradToChange, Grade newGrade, Teacher byTeacher, Student forStudent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesFor(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudentsFor(Course course)
        {
            throw new NotImplementedException();
        }

        public void GiveGrade(Course course, Grade grade, Teacher byTeacher, Student toStudent)
        {
            throw new NotImplementedException();
        }
    }
}
