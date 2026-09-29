using Microsoft.EntityFrameworkCore;
using Quiz1.Data;
using Quiz1.Model;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public class StudentRepo : GenericRepo<Student>, IStudent 
    {
        private readonly AppDbContext _context;

        public StudentRepo(AppDbContext context) : base(context) 
        {
            _context = context;
        }

       


        public List<Student> GetStudentbyClassRoomId(int roomId)
        {
            var ClassNumber = _context.Students.Where(op => op.ClassRoomId == roomId).ToList();

           

            return ClassNumber;


        }
        public List<Student> StoredStudet()
        {
            var stu=_context.Students.OrderBy(x=>x.ClassRoomId).ToList();
            return stu;
        }

        public Student Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
