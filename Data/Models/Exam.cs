using System;

namespace HomeworkExamTracker.Data
{
    public class Exam
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Description { get; set; }
        public DateTime ExamDate { get; set; }
    }
}