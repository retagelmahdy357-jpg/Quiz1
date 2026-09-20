using System.ComponentModel.DataAnnotations;

namespace Quiz1.DTO
{
    public class DepartmentDto
    {
        public int DepId { get; set; }
        public string Name { get; set; }
       
        public string? Description { get; set; }
    }
}
