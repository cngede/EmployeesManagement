using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Models
{
    public class Employee : UserActivity
    {
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string EmpNo { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required]
        public String FullName => "${FirstName}{MiddleName}{LastName}";
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Department { get; set; }
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string CreatedById { get; set; }

    }
}