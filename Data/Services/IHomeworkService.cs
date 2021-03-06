using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public interface IHomeworkService
    {
        List<Homework> GetAllHomeworkPerSubject(int subjectId);
        Homework GetSingleHomework(int homewordId);
        void AddHomework(Homework homework);
        void DeleteHomework(int homeworkId);
    }
}