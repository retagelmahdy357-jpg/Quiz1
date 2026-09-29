using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz1.Data;
using Quiz1.DTO;
using Quiz1.Mappings;
using Quiz1.Model;
using Quiz1.Repos.Abstraction;
using Quiz1.UnitOfWork;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;
        private readonly IStudent _CustoumStudentRepo;
        public StudentController(IUnitOfWork unitOfWork , IMapper mapper , IStudent CustoumStudentRepo)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
            _CustoumStudentRepo = CustoumStudentRepo;

        }
        [HttpGet("GetAll")]
        public ActionResult<List<StudentDto>> GetStudents()
        {
            var st = _UnitOfWork.student.GetAll();
            var stdto = _mapper.Map<List<StudentDto>>(st);
            return Ok(stdto);

        }

        //[HttpGet]
        [HttpGet("{id}")]
        public ActionResult<StudentDto> GetById(int id)
        {

            var stu = _UnitOfWork.student.GetById(id);
            var stdo = _mapper.Map<StudentDto>(stu);
            return Ok(stdo);
        }

        [HttpPost("Create")]
        public IActionResult CreateStudent(createStudentDto studentdto)
        {
            var std = _mapper.Map<Student>(studentdto);
            _UnitOfWork.student.Create(std);
            _UnitOfWork.SaveChange();
            return StatusCode(201, std);
        }

        [HttpPut("Upadte")]
        public IActionResult UpdateStudent(int id, createStudentDto studentdto)
        {
            var exisitingStd = _UnitOfWork.student.GetById(id);

            if (exisitingStd == null)
                return BadRequest();

            var std = _mapper.Map(studentdto, exisitingStd);

            _UnitOfWork.student.Update(std);
            _UnitOfWork.SaveChange();

            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {

            _UnitOfWork.student.Delete(id);
            _UnitOfWork.SaveChange();
            return NoContent();
        }
        [HttpGet("ByClassRoomId")]
        public IActionResult GetStudentbyClassRoomId(int roomId)
        {
          var StudentsList =  _UnitOfWork.student.GetStudentbyClassRoomId(roomId);
            return Ok(StudentsList);
        }








    }
}
