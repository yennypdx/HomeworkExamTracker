namespace HomeworkExamTracker.Data
{
    public class StudentService : IStudentService
    {
        public Student GetSingleStudent(string studEmail)
        {
            return StudentData.Students.Find(e => e.Email == studEmail);
        }

        public void UpdateStudent(string studEmail, Student updatedStudent)
        {
            var prevStudent = StudentData.Students.Find(e => e.Email == studEmail);

            if(prevStudent != null)
            {
                prevStudent.Name = updatedStudent.Name;
                prevStudent.Email = updatedStudent.Email;
            }
        }
    }
}