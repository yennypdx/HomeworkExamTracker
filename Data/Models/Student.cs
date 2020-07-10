using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<int> TeacherIds { get; set; }
        public List<int> SubjectIds { get; set; }
    }
}