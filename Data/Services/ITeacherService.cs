using System.Collections.Generic;

namespace HomeworkExamTracker.Data
{
    public interface ITeacherService
    {
        List<Teacher> GetAllTeacher();
        Teacher GetTeacher(int teacherId);
        void AddTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
        void UpdateTeacher(int teacherId, Teacher updatedTeacher);
    }
}