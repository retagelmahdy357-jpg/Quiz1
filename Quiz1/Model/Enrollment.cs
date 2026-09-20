using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz1.Model
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        [ForeignKey("StudentId")]
        public int StudentId {  get; set; }
        public Student? Student { get; set; }
        [ForeignKey("SubjectId")]
        public int SubjectId {  get; set; }
        public Subject? Subject { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [Range(0,100)]
        public decimal Grade {  get; set; }
    }
}
