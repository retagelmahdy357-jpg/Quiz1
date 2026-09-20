using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz1.Model
{
    public class Teachear
    {
        [Key]
        public int TeachearId { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(150), EmailAddress]
        public string Email { get; set; }
        [MaxLength(20), Phone]
        public string ?PhoneNumber { get; set; }
        [Range(0,int.MaxValue)]
        public decimal Salary {  get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department ?Department { get; set; }
        public List<Subject> Subjects { get; set; }=new List<Subject>();
    }
}
