using System.ComponentModel.DataAnnotations;

namespace Quiz1.DTO
{
    public class createStudentDto
    {
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(150), EmailAddress]
        public string Email { get; set; }
        [MaxLength(20), Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }

        public int ClassRoomId { get; set; }
    }
}
