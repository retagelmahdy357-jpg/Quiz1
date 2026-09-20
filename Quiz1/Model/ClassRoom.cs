using System.ComponentModel.DataAnnotations;

namespace Quiz1.Model
{
    public class ClassRoom
    {
        [Key]
        public int ClassRoomId { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required,Range(1,12)]
        public int GradeLevel { get; set; }
        [Required, Range(1, 100)]
        public int Capacity { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
