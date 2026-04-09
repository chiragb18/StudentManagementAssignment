using StudentManagementAssignment.Models;

namespace StudentManagementAssignment.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();


        Student GetStudentById(int id);

        void AddStudent(Student student);

        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
