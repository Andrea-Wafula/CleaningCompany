using System.ComponentModel.DataAnnotations;
namespace CityCleaningCompanyMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}