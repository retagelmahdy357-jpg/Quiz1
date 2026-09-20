using System.ComponentModel.DataAnnotations;

namespace Quiz1.Model
{
    public class Department
    {
        [Key]
      public  int DepartmentId { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public List<Teachear>? Teachear { get; set; }=new List<Teachear>();



    }
}
