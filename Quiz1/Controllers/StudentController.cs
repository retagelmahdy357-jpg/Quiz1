using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz1.Data;
using Quiz1.Model;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentController()
        {
            _context = new AppDbContext();
        }

        //[HttpGet]
        //public ActionResult<List<Student>> GetStudents()
        //{
        //    {
        //        var students = _context.Students.ToList();
        //        return students;
        //    }
        //}



        [HttpGet]
        //[HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }





        
    }
}
