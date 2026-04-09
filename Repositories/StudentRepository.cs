using StudentManagementAssignment.Models;
using StudentManagementAssignment.Data;

namespace StudentManagementAssignment.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }
        //to view all students method
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
        // get student by id method
        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }
        // add studemnt method
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        // update student method

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        // delete method by id
        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
