using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        [MinLength(3, ErrorMessage ="Name has to be more than 3 characters.")]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [Range(1000, 100000, ErrorMessage = "Salary must be between 1000 and 100000.")]
        public int Salary { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, DepartmentId: {DepartmentId}";
        }
    }
}
