using Quiz1.Data;
using Quiz1.Model;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public class EnrollmentRepo : GenericRepo<Enrollment>, IEnrollment
    {
        private readonly AppDbContext _context;
        public EnrollmentRepo(AppDbContext context):base(context)
        {
            _context=context;
             
        }
        public Enrollment GetOldestEnrollment(int subid)
        {
           var en=_context.Enrollments.Where(x=>x.SubjectId==subid).OrderBy(x=>x.EnrollmentDate).LastOrDefault();
            return en;
        }
    }
}
