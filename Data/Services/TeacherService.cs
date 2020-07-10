using System.Collections.Generic;
using System.Linq;

namespace HomeworkExamTracker.Data
{
    public class TeacherService : ITeacherService
    {
        public void AddTeacher(Teacher teacher)
        {
            TeacherData.Teachers.Add(teacher);
        }

        public void DeleteTeacher(int teacherId)
        {
            var teacher = TeacherData.Teachers.Find(t => t.Id == teacherId);

            if(teacher != null)
            {
                TeacherData.Teachers.Remove(teacher);
            }
        }

        public List<Teacher> GetAllTeacher()
        {
            return TeacherData.Teachers.ToList();
        }

        public Teacher GetTeacher(int teacherId)
        {
            return TeacherData.Teachers.FirstOrDefault(t => t.Id == teacherId);
        }

        public void UpdateTeacher(int teacherId, Teacher updatedTeacher)
        {
            var prevTeacher = TeacherData.Teachers.Find(t => t.Id == teacherId);

            if(prevTeacher != null)
            {
                prevTeacher.Name = updatedTeacher.Name;
                prevTeacher.Email = updatedTeacher.Email;
            }
        }
    }
}