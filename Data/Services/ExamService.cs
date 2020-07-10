using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public class ExamService : IExamService
    {
        public void AddExam(Exam exam)
        {
            ExamData.Exams.Add(exam);
        }

        public void DeleteExam(int examId)
        {
            var exam = ExamData.Exams.Find(e => e.Id == examId);

            if(exam != null)
            {
                ExamData.Exams.Remove(exam);
            }
        }

        public void UpdateExam(int examId, Exam updatedExam)
        {
            var prevExam = ExamData.Exams.Find(e => e.Id == examId);

            if(prevExam != null)
            {
                prevExam.Description = updatedExam.Description;
                prevExam.ExamDate = updatedExam.ExamDate;
            }
        }

        public List<Exam> GetAllExamPerSubject(int examId, int subjectId)
        {
            var exams = new List<Exam>();            
            foreach(Exam ex in ExamData.Exams)
            {
                if(ex.Id == examId && ex.SubjectId == subjectId)
                {
                    exams.Add(ex);
                }
            }
            return exams;
        }

        public Exam GetSingleExam(int examId)
        {
            return ExamData.Exams.Find(e => e.Id == examId);
        }
    }
}