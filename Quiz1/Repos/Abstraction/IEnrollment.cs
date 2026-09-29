using Quiz1.Model;

namespace Quiz1.Repos.Abstraction
{
    public interface IEnrollment
    {
        public Enrollment GetOldestEnrollment(int subid);
    }
}
