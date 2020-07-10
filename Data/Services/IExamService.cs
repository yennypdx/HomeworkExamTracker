using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public interface IExamService
    {
        List<Exam> GetAllExamPerSubject(int examId, int subjectId);
        Exam GetSingleExam(int examId);
        void AddExam(Exam exam);
        void DeleteExam(int examId);
        void UpdateExam(int examId, Exam updatedExam);
    }
}