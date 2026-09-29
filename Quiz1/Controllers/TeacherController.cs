using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz1.Data;
using Quiz1.DTO;
using Quiz1.Model;
using Quiz1.UnitOfWork;

namespace Quiz1.Controllersb
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _UitOfWork;
        public TeacherController(IUnitOfWork unitOfWork)
        {

            _UitOfWork = unitOfWork;

        }
        [HttpGet("{deptid}/{salsry}")]
        public IActionResult GetTeachearHaveSepecificDepartmentIdAndSalary(int deptid, int salsry)
        {
          var teach=  _UitOfWork.teachear.GetTeachearHaveSepecificDepartmentIdAndSalary(deptid, salsry);
            return Ok(teach);
             
            
        }

        [HttpGet("{email}")]
        public IActionResult GetTeatcherByEmail(string email)
        {
           var teach= _UitOfWork.teachear.GetTeatcherByEmail(email);
            return Ok(teach);

        }







































     //   [HttpGet]
     //public ActionResult<List<TeachearDto>> GetAllTeacher()
     //{
     //    var teach = _context.Teachears.Include(x => x.Department).ToList();

        //    if (teach.Count == 0 || teach == null)
        //    {
        //        return NotFound();
        //    }
        //    var teachdto = new List<TeachearDto>();
        //    foreach (var x in teach)
        //    {
        //        var dto = new TeachearDto
        //        {
        //            TeachearId = x.TeachearId,
        //            FirstName = x.FirstName,
        //            LastName = x.LastName,
        //            Email = x.Email,
        //            PhoneNumber = x.PhoneNumber,
        //            Salary = x.Salary,
        //            DepartmentName = x.Department?.Name

        //        };
        //        teachdto.Add(dto);
        //    }
        //    return Ok(teachdto);

        //}


    }
}
