using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}