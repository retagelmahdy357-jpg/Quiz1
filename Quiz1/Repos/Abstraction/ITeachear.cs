using Quiz1.Data;
using Quiz1.Model;

namespace Quiz1.Repos.Abstraction
{
   
    public interface ITeachear:IGenericRepo<Teachear>
    {


        public List<Teachear> GetTeachearHaveSepecificDepartmentIdAndSalary(int deptid,int salary);
        public Teachear GetTeatcherByEmail(string email);
       
    }
}
