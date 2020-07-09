using System;

namespace HomeworkExamTracker.Data
{
    public class Homework 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}