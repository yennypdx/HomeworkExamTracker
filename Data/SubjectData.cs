using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public static class SubjectData
    {
        public static List<Subject> Subjects => allSubjects;
        static List<Subject> allSubjects = new List<Subject>()
        {
            new Subject() 
            {
                Id=1,
                Name="Math",
                TeacherId=1,
                HomeworkIds={1,2},
                ExamIds={}
            },
            new Subject() 
            {
                Id=2,
                Name="AGS",
                TeacherId=1,
                HomeworkIds={3,4},
                ExamIds={}
            }
        };
    }
}