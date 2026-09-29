using Quiz1.Model;

namespace Quiz1.Repos.Abstraction
{
    public interface IStudent:IGenericRepo<Student>
    {
        List<Student> GetStudentbyClassRoomId(int roomId);
        List<Student> StoredStudet();
    }
}
