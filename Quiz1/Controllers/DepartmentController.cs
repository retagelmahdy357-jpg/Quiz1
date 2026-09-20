using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Quiz1.Data;
using Quiz1.DTO;
using Quiz1.Model;

namespace Quiz1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public DepartmentController()
        {
            _context = new AppDbContext();
        }
        [HttpGet ("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var depart=_context.Department.Find(id);
            if (depart == null)
            {
                return NotFound();
            }
            var departmentdtoo = new DepartmentDto
            {
                DepId = depart.DepartmentId,
                Name = depart.Name,
                Description = depart.Description,
            };
            return Ok(departmentdtoo);


        }
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var departs=_context.Department.ToList();

            if (departs.Count == 0 || departs == null)
            {
                return NotFound();
            }
            var departsdto=new List<DepartmentDto>();
            foreach (var x in departs)
            {
                var dto = new DepartmentDto
                {
                    DepId = x.DepartmentId,
                    Name = x.Name,
                    Description = x.Description,

                };
                departsdto.Add(dto);
                }
            return Ok(departsdto);
            }

        [HttpPost]
        public IActionResult CreateDepartment(DepartmentDto2 department)
        {
            var depat = new Department()
            {

               Name = department.Name,
               Description = department.Description,
            };
            _context.Department.Add(depat);
            _context.SaveChanges();
            return StatusCode(201, department);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateDepartment(int id, DepartmentDto2 department)
        {
            var dep = _context.Department.Find(id);
            if (dep == null)
            {
                return NotFound();
            }
            dep.Name = department.Name;
            dep.Description = department.Description;
            
            _context.Department.Update(dep);
            _context.SaveChanges();
            return NoContent();
           
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var dep = _context.Department.Find(id);
            if (dep == null)
            {
                return NotFound();
            }
            _context.Department.Remove(dep);
            _context.SaveChanges();
            return NoContent();
        }

        }
}
