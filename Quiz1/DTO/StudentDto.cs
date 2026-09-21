using System.ComponentModel.DataAnnotations;

namespace Quiz1.DTO
{
    public class StudentDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        [MaxLength(20), Phone]
        public string? PhoneNumber { get; set; }
       
    }
}
