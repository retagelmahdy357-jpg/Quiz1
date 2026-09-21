using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz1.Data;
using Quiz1.DTO;
using Quiz1.Mappings;
using Quiz1.Model;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public StudentController()
        {
            _context = new AppDbContext();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<StudentProfile>();

            });
            _mapper = config.CreateMapper();
        }
        [HttpGet]
        public ActionResult<List<StudentDto>> GetStudents()
        {
            var students = _context.Students.ToList();

            var studentDtos = _mapper.Map<List<StudentDto>>(students);

            return Ok(studentDtos);
        }







        //[HttpGet]
        [HttpGet("{id}")]
        public ActionResult<StudentDto> GetById(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            var st = _mapper.Map<StudentDto>(student);
            return st;
        }

        [HttpPost]
        public IActionResult CreateStudent(createStudentDto studentdto)
        {
            var stdto=_mapper.Map<Student>(studentdto);
            _context.Add(stdto);
            _context.SaveChanges();
            return StatusCode(201,stdto);
        }






    }
}
