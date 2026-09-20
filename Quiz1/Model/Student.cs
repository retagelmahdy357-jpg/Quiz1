using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz1.Model
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(150), EmailAddress]
        public string Email { get; set; }
        [MaxLength(20), Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [ForeignKey("ClassRoomId")]
        public int ClassRoomId { get; set; }
        public ClassRoom? ClassRoom { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
