using Quiz1.DTO;
using Quiz1.Model;

namespace Quiz1.Repos.Abstraction
{
    public interface IStudentRepo
    {
      //  void Add(StudentDto dto);
    List<StudentDto> StudentGetAll();
        StudentDto GetById(int id);
        
    }
}
