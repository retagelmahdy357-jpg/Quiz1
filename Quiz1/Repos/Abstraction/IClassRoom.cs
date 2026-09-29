using Quiz1.Model;

namespace Quiz1.Repos.Abstraction
{
    public interface IClassRoom:IGenericRepo<ClassRoom>
    {
        public ClassRoom GetClassRoomBySpecefiedCapacity(int capacity);
        public List<ClassRoom> SearchByName(string name);
        public ClassRoom GetIndex(int index);
        public string cheackClassroomCapacity(int gradelevel,int capacity);
    }
}
