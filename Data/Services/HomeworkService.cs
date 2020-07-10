using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public class HomeworkService : IHomeworkService
    {
        public void AddHomework(Homework homework)
        {
            HomeworkData.Homeworks.Add(homework);
        }

        public void DeleteHomework(int homeworkId)
        {
            var homework = HomeworkData.Homeworks.Find(h => h.Id == homeworkId);
            if(homework != null)
            {
                HomeworkData.Homeworks.Remove(homework);
            }
        }

        public void UpdateHomework(int homeworkId, Homework updatedHomework)
        {
            var prevHomework = HomeworkData.Homeworks.Find(h => h.Id == homeworkId);
            if(prevHomework != null)
            {
                prevHomework.SubjectId = updatedHomework.SubjectId;
                prevHomework.Description = updatedHomework.Description;
                prevHomework.Duedate = updatedHomework.Duedate;
                prevHomework.CompletedDate = updatedHomework.CompletedDate;
            }
        }

        public List<Homework> GetAllHomeworkPerSubject(int subjectId)
        {
            var homeworks = new List<Homework>();
            foreach(Homework hw in HomeworkData.Homeworks)
            {
                if(hw.SubjectId == subjectId)
                {
                    homeworks.Add(hw);               
                }
            }
            return homeworks;
        }

        public Homework GetSingleHomework(int homeworkId)
        {
             return HomeworkData.Homeworks.Find(h => h.Id == homeworkId);
        }
    }
}