using Quiz1.Data;
using Quiz1.Model;
using Quiz1.Repos;
using Quiz1.Repos.Abstraction;

namespace Quiz1.UnitOfWork
{
    public class UnitOfWorkRepo : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IStudent  student { get; }
        public ITeachear teachear { get; }
        public IGenericRepo<Department> department { get; }
        public ISubject subject { get ; }
        public IClassRoom classroom { get; }
        public IEnrollment enrollment { get ; }
       
        public void SaveChange()
        {
           _context.SaveChanges();
        }


        
        public UnitOfWorkRepo(AppDbContext context, IStudent _student, ITeachear _teachear, IGenericRepo<Department> _department, ISubject _subject, IClassRoom _classroom, IEnrollment _enrollment)
        {
            _context = context;
            student = _student;
            teachear = _teachear;
            department = _department;
            subject = _subject;
            classroom = _classroom;
            enrollment = _enrollment;
        }
    }
}
