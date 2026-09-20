using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz1.Model
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required,MaxLength(100)]
        public string Name {  get; set; }
        [MaxLength(500)]
        public string Description {  get; set; }
        [Required ,Range(1,100)]
        public decimal Grade {  get; set; }
        [ForeignKey("TeachearId")]
        public int TeachearId { get; set; }
        public Teachear? Teachear { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
