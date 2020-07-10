using System;
using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public static class ExamData
    {
        public static List<Exam> Exams => allExams;
        static List<Exam> allExams = new List<Exam>()
        {
            new Exam()
            {
                Id=1,
                SubjectId=1,
                Description="Chapter2 Understanding Basic Algebra excersice.",
                ExamDate = new DateTime(2020,07,24)
            },
            new Exam()
            {
                Id=2,
                SubjectId=1,
                Description="Chapter3 Understanding Order of Operation excersice.",
                ExamDate = new DateTime(2020,08,07)
            },
            new Exam()
            {
                Id=3,
                SubjectId=2,
                Description="Chapter2 Understanding the global interaction.",
                ExamDate = new DateTime(2020,07,23)
            },
            new Exam()
            {
                Id=4,
                SubjectId=2,
                Description="Chapter3 Walk the talk.",
                ExamDate = new DateTime(2020,07,30)
            },
        };
    }
}