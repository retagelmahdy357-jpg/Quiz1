using Quiz1.Model;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public interface ISubject:IGenericRepo<Subject>
    {
        public Subject GetSubjectFiltirAndSorted(int teachid);
        public Subject GetSbjectStoredIdAndFilterTeachId(int teachid);
        public List<Subject> CheckWeather(int teachid);

    }
}
