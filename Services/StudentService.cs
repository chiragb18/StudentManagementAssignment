using StudentManagementAssignment.Models;
using StudentManagementAssignment.Repositories;

namespace StudentManagementAssignment.Services
{
    public class StudentService : IStudentService
    {
        // here we used for logic and for validations
        private readonly IStudentRepository _studentRepo;

        public StudentService(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        // get all studnets
        public List<Student> GetAllStudents()
        {
            return _studentRepo.GetAllStudents();
        }
        //get student by id
        public Student GetStudentById(int id)
        {
            return _studentRepo.GetStudentById(id);
        }


        // add student method
        public void AddStudent(Student student)
        {
            // Adding business logic: Setting the creation date before saving
            student.CreatedDate = DateTime.Now;
            _studentRepo.AddStudent(student);
        }


        //update the student method
        public void UpdateStudent(Student student)
        {
            _studentRepo.UpdateStudent(student);
        }


        //delete the student method
        public void DeleteStudent(int id)
        {
            _studentRepo.DeleteStudent(id);
        }
    }
}
