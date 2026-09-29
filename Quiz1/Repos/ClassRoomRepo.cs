using Microsoft.AspNetCore.Http.HttpResults;
using Quiz1.Data;
using Quiz1.Model;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public class ClassRoomRepo : GenericRepo<ClassRoom>, IClassRoom
    {
        private readonly AppDbContext _context;

        public ClassRoomRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public string cheackClassroomCapacity(int gradelevel, int capacity)
        {
         var cls= _context.Classrooms.FirstOrDefault(x => x.GradeLevel == gradelevel);
            if (cls.Capacity >= capacity)
            {
                return "Capacity >= this Capacity";
            }
            return "Capacity Less than This Capacity";
        }

        public ClassRoom GetClassRoomBySpecefiedCapacity(int capacity)
        {
            
          var cls=   _context.Classrooms.Where(x => x.Capacity >= capacity).FirstOrDefault();
            return cls;
            
        }

        public ClassRoom GetIndex(int index)
        {
           var cls= _context.Classrooms.OrderBy(x=>x.ClassRoomId).ElementAt(index);
            return cls;

        }

        public List<ClassRoom> SearchByName(string name)
        {
           var cls= _context.Classrooms.Where(x=>x.Name== name).ToList();
            return cls;
        }
    }
}
