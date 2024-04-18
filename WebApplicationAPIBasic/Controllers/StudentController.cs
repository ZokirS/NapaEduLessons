﻿using Microsoft.AspNetCore.Mvc;
using WebApplicationAPIBasic.Context;
using WebApplicationAPIBasic.Models;

namespace WebApplicationAPIBasic.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _studentContext;

        public StudentController(AppDbContext studentContext)
        {
            _studentContext = studentContext;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Student>> GetStudents()
        //{
        //    var students = _studentContext.Students;
        //    return Ok(students);
        //}

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _studentContext.Students.Find(id);
            if(student !=null)
              return Ok(student);
            else
                return NotFound();
        }

        [HttpGet]
        public ActionResult<Student> GetStudentWithParam([FromQuery]int id)
        {
            var student = _studentContext.Students.Find(id);
            if (student != null)
                return Ok(student);
            else
                return NotFound();
        }
        [HttpPost]
        public ActionResult AddStudent([FromBody]Student student)
        {
            _studentContext.Students.Add(student);
            _studentContext.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public ActionResult GetAction()
        {
            return RedirectToAction(nameof(GetStudents));
        }

        [HttpPut]
        public ActionResult<bool> UpdateStudent([FromQuery] int id, [FromBody]Student student)
        {
            var result = _studentContext.Students.Find(id);
            if(result != null)
            {
                result.FirstName = student.FirstName;
                result.LastName = student.LastName;
                result.BirthDate = student.BirthDate;
                _studentContext.Students.Update(result);
                _studentContext.SaveChanges();
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var result = _studentContext.Students.Find(id);
            if (result != null)
            {
                _studentContext.Students.Remove(result);
                _studentContext.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public ActionResult<IQueryable<Student>> GetStudents([FromQuery]string name = null, [FromQuery] string birthDate= null,
            [FromQuery] int page = 1, [FromQuery] int pageSize = 4)
        {
            var students = _studentContext.Students.OrderBy(s=>s.BirthDate).ToList();
            if(name != null)
            {
                students = students.Where(x=>x.FirstName.Equals(name)).ToList();
            }
            if(birthDate != null && birthDate.Contains("desc"))
            {
                students = students.OrderByDescending(students => students.BirthDate).ToList() ;
            }

            var totalCount = students.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            students = students.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var result = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Students = students
            };
            return Ok(result);
        }
    }
}
