using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public static class StudentData
    {
        public static List<Student> Students => allStudents;
        static List<Student> allStudents = new List<Student>()
        {
            new Student()
            {
                Id=1,
                Name="Cleopatra Russ",
                Email="cleopatraruss@scool.org",
                TeacherIds={1,2},
                SubjectIds={1,2}
            }
        };
    }    
}