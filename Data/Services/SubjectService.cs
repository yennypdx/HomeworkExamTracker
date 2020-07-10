using System.Collections.Generic;
using System.Linq;

namespace HomeworkExamTracker.Data
{
    public class SubjectService : ISubjectService
    {
        public void AddSubject(Subject subject)
        {
            SubjectData.Subjects.Add(subject);
        }

        public void DeleteSubject(int subjectId)
        {
            var subject = SubjectData.Subjects.Find(s => s.Id == subjectId);

            if(subject != null)
            {
                SubjectData.Subjects.Remove(subject);
            }
        }

        public void UpdateSubject(int subjectId, Subject updatedSubject)
        {
            var prevSubject = SubjectData.Subjects.Find(s => s.Id == subjectId);

            if(prevSubject != null)
            {
                prevSubject.Name = updatedSubject.Name;
                prevSubject.TeacherId = updatedSubject.TeacherId;
                prevSubject.HomeworkIds= null;
            }
        }

        public List<Subject> GetAllSubject()
        {
            return SubjectData.Subjects.ToList();
        }
    }
}