using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz1.Data;
using Quiz1.DTO;
using Quiz1.Mappings;
using Quiz1.Model;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _repo;
        private readonly IMapper _mapper;
        public StudentController(IStudentRepo repo, IMapper mapper)
        {
           _repo= repo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<StudentDto>> GetStudents()
        {
            return Ok(_repo.StudentGetAll());
        }

        //[HttpGet]
        [HttpGet("{id}")]
        public ActionResult<StudentDto> GetById(int id)
        {
            var res=_repo.GetById(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpPost]
        public IActionResult CreateStudent(createStudentDto studentdto)
        {
            var stdto = _mapper.Map<Student>(studentdto);
            _context.Add(stdto);
            _context.SaveChanges();
            return StatusCode(201, stdto);
        }


        [HttpGet("Get linq")]
        public IActionResult GetStudent()
        {
            var t = _context.Students.OrderBy(x => x.ClassRoomId).ThenBy(s => s.FirstName).Select(x => x.FirstName).ToList();
            return Ok(t);

        }






    }
}
