using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public class Subject 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Homework> Homeworks { get; set; }
        public List<Exam> Exams { get; set; }
    }
}