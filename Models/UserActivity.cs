using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Models
{
    
    public class UserActivity
    {
        public String? CreatedById { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatedOn { get; set; }
        [StringLength(50, MinimumLength = 2)]
        
        public String? ModifiedById { get; set; }
        
        public DateTime ModifiedOn { get; set; }

    }


}
