using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public interface ISubjectService
    {
        List<Subject> GetAllSubject();
        void AddSubject(Subject subject);
        void DeleteSubject(int subjectId);
        void UpdateSubject(int subjectId, Subject updatedSubject);
    }
}