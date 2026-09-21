using Quiz1.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Quiz1.DTO
{
    public class TeachearDto
    {
        public int TeachearId { get; set; }
        
        public string FullName { get; set; }
        
        //public string LastName { get; set; }
        
        public string Email { get; set; }
        
        public string? PhoneNumber { get; set; }
        
        public decimal Salary { get; set; }
        
        
       public string DepartmentName {  get; set; }
    }
}
