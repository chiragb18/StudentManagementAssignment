using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAssignment.Models;
using StudentManagementAssignment.Services;
using Microsoft.AspNetCore.Authorization;

namespace StudentManagementAssignment.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // view all students method
        [HttpGet]
        public IActionResult GetAllStud()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }


        // add student method
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return Ok("Student added successfully");
        }


        // delete student method
        [HttpDelete("{id}")]
        public IActionResult DeleteStud(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok("Student deleted successfully");
        }


        //update student method

        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            _studentService.UpdateStudent(student);
            return Ok("Student updated successfully");
        }


        // view student method by using ID
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound("Student not found");
            }
            return Ok(student);

        }
    }
}
