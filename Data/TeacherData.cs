using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public static class TeacherData
    {
        public static List<Teacher> Teachers => allTeachers;
        static List<Teacher> allTeachers = new List<Teacher>()
        {
            new Teacher()
            {
                Id=1,
                Name="Gregory Adam",
                Email="gregoryadam@school.org"
            },
            new Teacher()
            {
                Id=2,
                Name="Louis McKnight",
                Email="louismcknight@school.org"
            }
        };
    }
}