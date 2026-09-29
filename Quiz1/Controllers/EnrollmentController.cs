using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz1.UnitOfWork;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EnrollmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EnrollmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("{subid:int}")]
        public IActionResult GetOldestEnrollment(int subid)
        {
            var en=_unitOfWork.enrollment.GetOldestEnrollment(subid);
            return Ok(en);
        }
        

    }
}
