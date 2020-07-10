using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public class Subject 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public List<int> HomeworkIds { get; set; }
        public List<int> ExamIds { get; set; }
    }
}