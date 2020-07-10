using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public interface IHomeworkService
    {
        List<Homework> GetAllHomeworkPerSubject(int subjectId);
        Homework GetSingleHomework(int homeworkId);
        void AddHomework(Homework homework);
        void DeleteHomework(int homeworkId);
        void UpdateHomework(int homeworkId, Homework updatedHomework);
    }
}