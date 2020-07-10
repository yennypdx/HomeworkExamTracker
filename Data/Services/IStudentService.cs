namespace HomeworkExamTracker.Data
{
    public interface IStudentService
    {
        Student GetSingleStudent(string studEmail);
        void UpdateStudent(string studEmail, Student updatedStudent);
    }
}