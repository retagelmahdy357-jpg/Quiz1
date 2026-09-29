using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz1.UnitOfWork;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IUnitOfWork _UitOfWork;
        public SubjectController(IUnitOfWork unitOfWork)
        {

            _UitOfWork = unitOfWork;

        }
        [HttpGet("{teachid:int}")]
        public IActionResult SetSubjectFiltirAndSorted(int teachid)
        {
          var sub=  _UitOfWork.subject.GetSubjectFiltirAndSorted(teachid);
            return Ok(sub);
        }
        [HttpGet("{teahid:int}storedbyid")]
        public IActionResult GetSbjectStoredIdAndFilterTeachId(int teahid)
        {
          var sub=  _UitOfWork.subject.GetSbjectStoredIdAndFilterTeachId(teahid);
            return Ok(sub);
        }
        [HttpGet("{teachid:int}cheack")]
        public IActionResult CheckWeather(int teachid)
        {
            var sub = _UitOfWork.subject.CheckWeather(teachid);
            if (sub == null)
            {
                return BadRequest("hasnot Teacher Teach it");
            }
            return Ok(sub );
        }
    }
}
