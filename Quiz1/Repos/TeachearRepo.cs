using Quiz1.Data;
using Quiz1.Model;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public class TeachearRepo :GenericRepo<Teachear>,ITeachear
    {
        private readonly AppDbContext _context;
        public TeachearRepo(AppDbContext context):base(context) 
        {
             _context = context;
        }
        

        public List<Teachear> GetTeachearHaveSepecificDepartmentIdAndSalary(int deptid,int salsry)
        {
         var teach=   _context.Teachears.Where(x => x.DepartmentId == deptid && x.Salary > salsry).ToList();
            return teach;
        }

        public Teachear GetTeatcherByEmail(string email)
        {
           var teach=  _context.Teachears.Where(x=>x.Email== email).FirstOrDefault();
            return teach;

        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Teachear Update(Teachear entity)
        {
            throw new NotImplementedException();
        }
    }
}
