using Microsoft.AspNetCore.Mvc;
using WebApplicationAPIBasic.Context;
using WebApplicationAPIBasic.Models;
using WebApplicationAPIBasic.Services.Interfaces;

namespace WebApplicationAPIBasic.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        
        private readonly IStudentService _studentService;
        public StudentController(IStudentService service)
        {
            _studentService = service;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Student>> GetStudents()
        //{
        //    var students = _context.Students;
        //    return Ok(students);
        //}

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
           var student = _studentService.GetStudent(id);
            _studentService.AddStudent(student);
            return Ok(student);
        }

        [HttpGet]
        public ActionResult<Student> GetStudentWithParam([FromQuery]int id)
        {
            var student = _studentService.GetStudent(id);
            return Ok(student);
        }
        [HttpPost]
        public ActionResult AddStudent([FromBody]Student student)
        {
            var studentAdd = _studentService.AddStudent(student);
            return Ok(studentAdd);
        }


        [HttpPut]
        public ActionResult<bool> UpdateStudent([FromQuery] int id, [FromBody]Student student)
        {
            var studentUpdated = _studentService.UpdateStudent(id, student);
            if (studentUpdated) 
            { 
                return Ok("Student successfuly updated");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var studentUpdated = _studentService.DeleteStudent(id);
            if (studentUpdated)
            {
                return Ok("Student successfuly deleted");
            }
            else
            {
                return BadRequest();
            }
        }

        //[HttpGet]
        //public ActionResult<IQueryable<Student>> GetStudents([FromQuery]string name = null, [FromQuery] string birthDate= null,
        //    [FromQuery] int page = 1, [FromQuery] int pageSize = 4)
        //{
        //    var students = _context.Students.OrderBy(s=>s.BirthDate).ToList();
        //    if(name != null)
        //    {
        //        students = students.Where(x=>x.FirstName.Equals(name)).ToList();
        //    }
        //    if(birthDate != null && birthDate.Contains("desc"))
        //    {
        //        students = students.OrderByDescending(students => students.BirthDate).ToList() ;
        //    }

        //    var totalCount = students.Count();
        //    var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

        //    students = students.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        //    var result = new
        //    {
        //        TotalCount = totalCount,
        //        TotalPages = totalPages,
        //        CurrentPage = page,
        //        PageSize = pageSize,
        //        Students = students
        //    };
        //    return Ok(result);
        //}
    }
}
