using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]{15,}$", ErrorMessage = "Name must contain only alphabets and spaces and be at least 15 characters long.")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "2002-01-01", "2005-12-31", ErrorMessage = "Date of Birth must be between 2002 and 2005.")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        [Range(12000, 60000, ErrorMessage = "Salary must be between 12000 and 60000.")]
        public decimal? Salary { get; set; }

        [Required]
        [EnumDataType(typeof(Department))]
        public Department Dept { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string RetypePassword { get; set; }
    }
}

    public enum Department
    {
        HR,
        Accts,
        IT
    }


