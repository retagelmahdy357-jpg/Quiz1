using Quiz1.Data;
using Quiz1.Model;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public class SubjectRepo : GenericRepo<Subject>,ISubject
    {
         private readonly AppDbContext _context;

            public SubjectRepo(AppDbContext context) : base(context)
            {
                _context = context;
            }

        public List<Subject> CheckWeather(int teachid)
        {
            var sub=_context.SubjectSet.Where(x=>x.TeachearId == teachid).ToList();
            return sub;

        }

        public Subject GetSbjectStoredIdAndFilterTeachId(int teachid)
        {
           var sub=_context.SubjectSet.Where(x=>x.TeachearId == teachid).OrderByDescending(x=>x.SubjectId).LastOrDefault();
            return sub;
        }

        public Subject GetSubjectFiltirAndSorted(int teachid)
        {
            var sub=_context.SubjectSet.Where(x=>x.TeachearId == teachid).OrderBy(x=>x.Name).First();
            return sub;
        }

       
    }
}
