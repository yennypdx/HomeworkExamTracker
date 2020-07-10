using System;
using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public static class HomeworkData
    {
        public static List<Homework> Homeworks => allHomeworks;
        static List<Homework> allHomeworks = new List<Homework>()
        {
            new Homework()
            {
                Id=1,
                SubjectId=1,
                Description="Chapter2 Understanding Basic Algebra excersice. Page 8 to 12.",
                Duedate = new DateTime(2020,07,17),
                CompletedDate = null
            },
            new Homework()
            {
                Id=2,
                SubjectId=1,
                Description="Chapter3 Understanding Order of Operation excersice. Page 14 to 16.",
                Duedate = new DateTime(2020,07,24),
                CompletedDate = null
            },
            new Homework()
            {
                Id=3,
                SubjectId=2,
                Description="Chapter2 Understanding the global interaction. Page 16 to 17.",
                Duedate = new DateTime(2020,07,16),
                CompletedDate = null
            },
            new Homework()
            {
                Id=4,
                SubjectId=2,
                Description="Chapter3 Walk the talk. Page 23 to 25.",
                Duedate = new DateTime(2020,07,24),
                CompletedDate = null
            },
        };
    }
}