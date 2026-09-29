using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz1.Model;
using Quiz1.UnitOfWork;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClassRoomController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("{capacity:int}")]
        public IActionResult GetClassRoomBySpecefiedCapacity(int capacity)
        {


            var cls = _unitOfWork.classroom.GetClassRoomBySpecefiedCapacity(capacity);

            if (cls == null)
            {
                return NotFound();
            }
            return Ok(cls);
        }
        [HttpGet("{name:alpha}")]
        public IActionResult SearchByName(string name)
        {
            var cls = _unitOfWork.classroom.SearchByName(name);
            return Ok(cls);
        }

        [HttpGet("{index:int}getindex")]
        public IActionResult GetIndex(int index)
        {
           var cls= _unitOfWork.classroom.GetIndex(index);
            return Ok(cls);

        }
        [HttpGet("{gradelevel}/{capacity}")]
        public IActionResult cheackClassroomCapacity(int gradelevel, int capacity)
        {
          var cls=  _unitOfWork.classroom.cheackClassroomCapacity(gradelevel, capacity);
            return Ok(cls);

        }
    }
}
