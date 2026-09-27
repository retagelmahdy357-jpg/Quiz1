using Microsoft.EntityFrameworkCore;
using Quiz1.Data;
using Quiz1.DTO;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly AppDbContext _context;

        public StudentRepo(AppDbContext context)
        {
             _context=context;
        }
        public StudentDto GetById(int id)
        {
            var res=_context.Students.Find(id);
            return new StudentDto
            {
                Email = res.Email,
                FullName = res.FirstName,
                PhoneNumber = res.PhoneNumber,
            };    
        }
        public List<StudentDto> StudentGetAll()
        {
           var res= _context.Students.Select(x =>
            new StudentDto
            {
                Email = x.Email,
                FullName = x.FirstName,
              
               PhoneNumber=x.PhoneNumber,
            }

            ).ToList();
            return res;
        }
    }
}
